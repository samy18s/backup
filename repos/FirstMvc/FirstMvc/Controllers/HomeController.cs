using FirstMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvc.Controllers
{
    public class HomeController : Controller
    {
       // private object Datetime;

        // GET: Home
        public string Index4()
        {
            string s = "Hello World";
            return s;
        }

        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greetings = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
        public ActionResult Register()
        {
            
            return View();
        }
        [HttpPost]
        public ViewResult Register(GetResponses getResponses)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", getResponses);
            }
            else
            {
                return View();
            }
        }

    }
}