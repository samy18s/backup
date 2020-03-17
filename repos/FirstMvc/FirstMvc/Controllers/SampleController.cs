using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvc.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            //string s1 = "By";
            return View();
        }
        public string Index1()
        {
            string s2 = "Get Lost";
            return s2;
            
        }
    }
}