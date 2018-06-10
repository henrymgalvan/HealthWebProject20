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
                var model = new HouseholdProfileIndexModel()
                {
                    Households = householdModels
                };
                return View(model);
            }
            
            return View("No Households");
        }

        [HttpGet]
        public IActionResult Create()
        {
            PopulateDropDownList();
            var model = new HouseholdProfileCreateModel();
            return View(model);
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
                var barangay = (Barangay)selectedBarangay;
                int CityId = barangay.CityMunicipalityId;
                selectedCity = (CityMunicipality)_city.Get(CityId);
                int provinceId = _city.Get(CityId).ProvinceId;
                selectedProvince = _province.Get(provinceId);
            }
            if (selectedCity != null)
            {
                var City = (CityMunicipality)selectedCity;
                int provinceId = City.ProvinceId;
                selectedProvince = _province.Get(provinceId);
            }

            ViewBag.ProvinceID = new SelectList(provinceQuery, "Id", "Name", selectedProvince);
            ViewBag.CityID = new SelectList(cityQuery, "Id", "Name", selectedCity);
            ViewBag.BarangayID = new SelectList(barangayQuery, "Id", "Name", selectedBarangay);

        }
        private void PopulateCityDropDownList(object selectedProvince = null, object selectedCity = null)
        {
            var cityQuery = from cq in _city.Getall().ToList<CityMunicipality>()
                            orderby cq.Name
                            select cq;

            if (selectedProvince != null)
            {
                cityQuery = from cq in _city.Getall().Where(p => p.ProvinceId == (int)selectedProvince).ToList<CityMunicipality>()
                                orderby cq.Name
                                select cq;
            }

            ViewBag.CityID = new SelectList(cityQuery, "Id", "Name", selectedCity);
            
        }
        private void PopulateBarangayDropDownList(object selectedProvince = null, object selectedCity = null, object selectedBarangay = null)
        {
            var provinceQuery = from pq in _province.Getall().ToList<Province>()
                                orderby pq.Name
                                select pq;
            if (selectedCity != null)
            {
                var City = (CityMunicipality)selectedCity;
                int provinceId = City.ProvinceId;
                selectedProvince = _province.Get(provinceId);
            }
            ViewBag.ProvinceID = new SelectList(provinceQuery, "Id", "Name", selectedProvince);
        }
    }
}