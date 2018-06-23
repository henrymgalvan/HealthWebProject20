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
using HealthWebApp2._0.Models.HouseholdMember;

namespace HealthWebApp2._0.Controllers
{
    public class HouseholdMemberController : Controller
    {
        private IHouseholdProfile _householdProfile;
        private IHouseholdMember _householdMember;
        private IBarangay _barangay;
        private IProvince _province;
        private ICity _city;

        public HouseholdMemberController(IHouseholdProfile householdProfile, IHouseholdMember householdMember, IProvince province, ICity city, IBarangay barangay)
        {
            _householdProfile = householdProfile;
            _householdMember = householdMember;
            _barangay = barangay;
            _province = province;
            _city = city;
        }

        public IActionResult Index()
        {
            List<HouseholdMember> allhouseholdMember = _householdMember.GetAll().ToList();
            IEnumerable<HouseholdMemberEditModel> householdMemberModels;

            if (allhouseholdMember.Any())
            {
                householdMemberModels = Mapper.Map<List<HouseholdMember>, List<HouseholdMemberEditModel>>(allhouseholdMember);
            }
            else
            {
                householdMemberModels = null;
            }

            var model = new HouseholdMemberIndexModel()
                {
                    HouseholdMembers = householdMemberModels
                };
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new HouseholdMemberCreateModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(HouseholdMemberCreateModel newHouseholdMember)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var householdmember = Mapper.Map<HouseholdMemberCreateModel, HouseholdMember>(newHouseholdMember);
                    householdmember.DateCreated = DateTime.Now;

                    _householdMember.Add(householdmember);
                    return RedirectToAction("Index");
                }
            }
            catch (Microsoft.EntityFrameworkCore.Storage.RetryLimitExceededException err)
            {
                ModelState.AddModelError(err.ToString(), "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(newHouseholdMember);
        }

    }
}