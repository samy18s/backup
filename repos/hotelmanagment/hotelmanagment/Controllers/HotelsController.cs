using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hotelmanagment.Controllers
{
    public class HotelsController : Controller
    {
        // GET: Hotels
        public ActionResult Index()
        {
            //if (User.IsInRole(RoleName.CanManageHotels))
            //    return View("List");

            return View("ReadOnlyList");
        }
    }
}