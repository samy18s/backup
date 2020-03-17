using RazorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor;


namespace RazorDemo.Controllers
{
    public class HomeController : Controller
    {
        Product myProduct = new Product
        {
            ProductID = 1,
            Name = "Product Name 1",
            Description = "Product 1 description",
            Category = "Product 1 Category",
            Price = 275m
        };
        // GET: Home
        public ActionResult Index()
        {
            return View(myProduct);
        }

        public ActionResult DemoExpression()
        {
            ViewBag.pid = 1;
            ViewBag.ExpreeShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

            return View(myProduct);
        }

        public ActionResult DemoArray()
        {
            Product[] array =
            {
                new Product{Name="Product1",Price=275m},
                new Product{Name="Product2",Price=1880.2m},
                new Product{Name="Product3",Price=427.5m},
                new Product{Name="Product4",Price=95.5m},
            };
            return View(array);
        }
    }
}