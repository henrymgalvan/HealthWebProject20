using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthWebApp2._0.Data.EntityModel.Household;
using HealthWebApp2._0.Data.Interface;
using HealthWebApp2._0.Models.HouseholdProfile;
using Microsoft.AspNetCore.Mvc;
using HealthWebApp2._0.Data.EntityModel.Barangays;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HealthWebApp2._0.Controllers
{
    public class HouseholdController : Controller
    {
        private IHouseholdProfile _householdProfile;
        private IBarangay _barangay;
        private IProvince _province;
        private ICity _city;

        public HouseholdController(IHouseholdProfile householdProfile, IProvince province, ICity city, IBarangay barangay)
        {
            _householdProfile = householdProfile;
            _barangay = barangay;
            _province = province;
            _city = city;
        }

        public IActionResult Index()
        {
            List<HouseholdProfile> allhouseholds = _householdProfile.GetAll().ToList();
            IEnumerable<HouseholdProfileDetailModel> householdModels;

            if (allhouseholds.Any())
            {
                householdModels = Mapper.Map<List<HouseholdProfile>, List<HouseholdProfileDetailModel>>(allhouseholds);
            }
            else
            {
                householdModels = null;
            }

            var model = new HouseholdProfileIndexModel()
                {
                    Households = householdModels
                };
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var ProvinceId = _province.GetId("Pangasinan");
            var CityId = _city.GetId("Dagupan City");
            //var BarangayId = _barangay.GetBarangayById(0);

            PopulateDropDownList(ProvinceId, CityId, null);

            var model = new HouseholdProfileCreateModel();
            model.CityId = CityId;
            model.ProvinceId = ProvinceId;
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(HouseholdProfileCreateModel newHousehold)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var household = Mapper.Map<HouseholdProfileCreateModel, HouseholdProfile>(newHousehold);
                    household.DateCreated = DateTime.Now;

                    _householdProfile.Add(household);
                    return RedirectToAction("Index");
                }
                PopulateDropDownList(newHousehold.ProvinceId, newHousehold.CityId, newHousehold.BarangayId);
            }
            catch (Microsoft.EntityFrameworkCore.Storage.RetryLimitExceededException err)
            {
                ModelState.AddModelError(err.ToString(), "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(newHousehold);
        }

        private void PopulateDropDownList(object selectedProvince = null, object selectedCity = null, object selectedBarangay = null)
        {
            var provinceQuery = from pq in _province.Getall().ToList<Province>()
                                orderby pq.Name
                                select pq;
            var cityQuery = from cq in _city.Getall().ToList<CityMunicipality>()
                            orderby cq.Name
                            select cq;
            var barangayQuery = from bq in _barangay.GetAll().ToList<Barangay>()
                                orderby bq.Name
                                select bq;

            if (selectedBarangay != null)
            {
                var barangay = _barangay.GetBarangayById((int)selectedBarangay);
                int CityId = barangay.CityMunicipalityId;
                barangayQuery = from bq in _barangay.GetAll().Where(c => c.Id == CityId).ToList<Barangay>()
                                orderby bq.Name
                                select bq;
                selectedCity = (CityMunicipality)_city.Get(CityId);
                int provinceId =  _city.Get(CityId).ProvinceId;
                selectedProvince = _province.Get(provinceId);
            }
            else if (selectedCity != null)
            {
                var City = _city.Get((int)selectedCity);
                barangayQuery = from bq in _barangay.GetAll().Where(c => c.CityMunicipalityId == City.Id).ToList<Barangay>()
                                orderby bq.Name
                                select bq;
                int provinceId = City.ProvinceId;
                selectedProvince = _province.Get(provinceId);
            }
            else if (selectedProvince != null)
            {
                var province = _province.Get((int)selectedProvince);
                cityQuery = from cq in _city.Getall().Where(p => p.ProvinceId == province.Id).ToList<CityMunicipality>()
                            orderby cq.Name
                            select cq;
            }

            ViewBag.ProvinceID = new SelectList(provinceQuery, "Id", "Name", selectedProvince);
            ViewBag.CityID = new SelectList(cityQuery, "Id", "Name", selectedCity);
            ViewBag.BarangayID = new SelectList(barangayQuery, "Id", "Name", selectedBarangay);

        }

    }
}