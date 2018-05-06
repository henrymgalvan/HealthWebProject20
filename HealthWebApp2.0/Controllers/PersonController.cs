using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HealthWebApp2._0.Data.EntityModel;
using HealthWebApp2._0.Data.Interface;
using HealthWebApp2._0.Models.Person;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HealthWebApp2._0.Controllers
{
    public class PersonController : Controller
    {
        private IPerson _person;
        private IWork _work;
        private IReligion _religion;
        private INameTitle _nameTitle;
        private IMapper _mapper;
        public PersonController(IPerson person, IWork work, IReligion religion, INameTitle nameTitle, IMapper mapper)
        {
            _person = person;
            _work = work;
            _religion = religion;
            _nameTitle = nameTitle;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            List<Person> allPersons = _person.Getall().ToList();
            IEnumerable<PersonDetailModel> PersonModels;
            if (allPersons.Any())
            {
                PersonModels = Mapper.Map<List<Person>, List<PersonDetailModel>>(allPersons);
                var model = new PersonIndexModel()
                {
                    People = PersonModels
                };
                return View(model);
            }
            return View();
            // return info - no data found
            //return RedirectToAction("Index", "Home");
        }


        public IActionResult Details(long? Id)
        {
            Person person = _person.Get((long)Id);
            if (person != null)
            {
                var model = Mapper.Map<Person, PersonDetailModel>(person);
                return View(model);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Create()
        {
            PopulateWorksDropDownList();
            PopulateNameTitleDropDownList();
            PopulateReligionDropDownList();
            var model = new PersonCreateModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PersonCreateModel newPerson)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (newPerson.PersonConsent)
                    {
                        var person = Mapper.Map<PersonCreateModel, Person>(newPerson);
                        _person.Add(person);
                        return RedirectToAction("Index");
                    }
                }
                //else
                //{
                //    return View(newPerson);
                //}
            }
            //            catch (Exception err)
            catch (Microsoft.EntityFrameworkCore.Storage.RetryLimitExceededException err)
            {
                ModelState.AddModelError(err.ToString(), "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }

            PopulateWorksDropDownList(newPerson.WorkId);
            PopulateNameTitleDropDownList(newPerson.NameTitleId);
            PopulateReligionDropDownList(newPerson.ReligionId);
            return View(newPerson);
        }

        [HttpGet]
        public IActionResult Edit(long? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                Person person = _person.Get((long)Id);
                if (person == null)
                {
                    return NotFound();
                }
                var model = Mapper.Map<Person, PersonEditModel>(person);

                PopulateWorksDropDownList(person.WorkId);
                PopulateNameTitleDropDownList(person.NameTitleId);
                PopulateReligionDropDownList(person.ReligionId);

                return View(model);
            }


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PersonEditModel editPerson)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = Mapper.Map<PersonEditModel, Person>(editPerson);
                    _person.Update(model);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception err)
            {
                ModelState.AddModelError(err.ToString(), "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }

            PopulateWorksDropDownList(editPerson.WorkId);
            PopulateNameTitleDropDownList(editPerson.NameTitleId);
            PopulateReligionDropDownList(editPerson.ReligionId);

            return View(editPerson);
        }

        [HttpGet]
        public IActionResult Delete(long? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            Person person = _person.Get((long)Id);
            if (person != null)
            {

                ViewBag["FullName"] = person.FirstName + " " + person.MiddleName + " " + person.LastName;
                return View(ViewBag);
            }
            else
            {
                return View("ErrorDelete");
            }
        }


        private void PopulateWorksDropDownList(object selectedWork = null)
        {
            var worksQuery = from w in _work.Getall().ToList<Work>()
                             orderby w.Name
                             select w;
            ViewBag.WorkID = new SelectList(worksQuery, "WorkId", "Name", selectedWork);
        }

        private void PopulateNameTitleDropDownList(object selectedNameTitle = null)
        {
            var nameTitleQuery = from nt in _nameTitle.Getall().ToList<NameTitle>()
                                 orderby nt.Name
                                 select nt;
            ViewBag.NameTitleID = new SelectList(nameTitleQuery, "NameTitleId", "Name", selectedNameTitle);
        }

        private void PopulateReligionDropDownList(object selectedReligion = null)
        {
            var ReligionsQuery = from r in _religion.Getall().ToList<Religion>()
                                 orderby r.Name
                                 select r;
            ViewBag.ReligionID = new SelectList(ReligionsQuery, "ReligionId", "Name", selectedReligion);
        }
    }
}
