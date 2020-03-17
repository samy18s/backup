using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fruits = new string[] { "Apple", "Grapes", "Chickoo" };
            ViewBag.Cities = new string[] { "Pune", "Mumbai", "Jalgaon" };
            string msg = "This is html element:<Input>";
            return View((object)msg);
        }

        public ActionResult Index2()
        {
            ViewBag.Fruits = new string[] { "Apple", "Grapes", "Chickoo" };
            ViewBag.Cities = new string[] { "Pune", "Mumbai", "Jalgaon" };
            string msg = "This is html element:<Input>";
            return View((object)msg);
        }
    }

}