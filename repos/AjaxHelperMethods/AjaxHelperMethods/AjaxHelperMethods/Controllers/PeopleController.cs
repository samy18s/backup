using AjaxHelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AjaxHelperMethods.Controllers
{
    public class PeopleController : Controller
    {
        private Person[] personData = {
            new Person{FirstName= "Sameeksha", LastName= "Shinde", Role= Role.Admin },
            new Person{FirstName= "Tejaswini", LastName= "Rajurkar", Role= Role.User },
            new Person{FirstName= "Manoj", LastName= "Bhosale", Role= Role.Admin },
            new Person{FirstName= "Aman", LastName= "Verma", Role= Role.Guest }
        };

        public PartialViewResult GetPeopleData(String selectedRole= "All")
        {
            IEnumerable<Person> data = personData;
            if(selectedRole != "All")
            {
                Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
                data = personData.Where(p => p.Role == selected);
            }
            return PartialView(data);
        }
      
        //public ActionResult GetPeople()
        //{
        //    return View();
        //}

        public ActionResult GetPeople(string selectedRole= "All")
        {
            return View((object)selectedRole);
        }
        //[HttpPost]
        //public ActionResult GetPeople(string selectedRole)
        //{
        //    if(selectedRole== null || selectedRole== "All")
        //    {
        //        return View(personData);

        //    }
        //else
        //{
        //    Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
        //        return View(personData.Where(p => p.Role == selected));
        //}

    }
}