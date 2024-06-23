using practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            //return View();
            return Content("hi there");
        }

        public ActionResult Contact(int id)
        {
            //return View();

            string result = "siam sarker" + id;
            return Content(result);
        }

        public string ABC(int x)
        {
             return "siam sarker" + x;

            



        }

        public ActionResult XYZ()
        {
            return View("ABC");
        }


        public ActionResult Club()
        {


            return Content("hi there");
        }







    }
}