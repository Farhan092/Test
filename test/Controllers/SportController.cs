using labtask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labtask.Controllers
{
    public class SportController : Controller
    {
        // GET: Sport
     

        public ActionResult Player()
        {

            List<Player> list = new List<Player>() {
            new Player { Id = 1 ,Name = "farhan",Salary = "10000"},
            new Player { Id = 2, Name = "siam", Salary = "10000" },
            new Player { Id = 3, Name = "shahriar", Salary = "10000" }

            };

            ViewBag.List = list;
          

            return View();
        }

        public ActionResult Staff()
        {

            List<Staff> list = new List<Staff>() {
            new Staff { Id = 1 ,Name = "farhan",Position = "salesman"},
            new Staff { Id = 2, Name = "siam", Position = "employee" },
            new Staff { Id = 3, Name = "shahriar", Position = "manager" }

            };

            ViewBag.List = list;


            return View();
        }

        public ActionResult Stadium()
        {

            List<Stadium> list = new List<Stadium>() {
            new Stadium { Location = "sylhet" ,Capacity = "Fifty Thousand"},
            new Stadium { Location = "Dhaka", Capacity = "Sixty Thousand" },
     

            };

            ViewBag.List = list;


            return View();
        }




    }
}