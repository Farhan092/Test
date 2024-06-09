using practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practice.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var model = new Product()
            {
                Id = 1,
                Name = "Test",
                Price = 50000

            };

            ViewData["pro"] = model;

            ViewBag.Product = model;
            return View();
        }
    }
}