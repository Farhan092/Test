using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practice.Models;
using practice.ViewModel;

namespace practice.Controllers
{
    public class SportController : Controller
    {


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


        [Route("Sport/stadium")]
        public ActionResult Stadium()
        {

            List<Stadium> list = new List<Stadium>() {
            new Stadium { Location = "sylhet" ,Capacity = "Fifty Thousand"},
            new Stadium { Location = "Dhaka", Capacity = "Sixty Thousand" },


            };

            /*ViewBag.List = list;*/


            return View(list);
        }

        [Route("combined/abc")]
        public ActionResult SampleModel()
        {
            List<Player> players = new List<Player>() {
        new Player { Id = 1 ,Name = "farhan", Salary = "10000" },
        new Player { Id = 2, Name = "siam", Salary = "10000" },
        new Player { Id = 3, Name = "shahriar", Salary = "10000" }
    };

            List<Staff> staffs = new List<Staff>() {
        new Staff { Id = 1 ,Name = "farhan", Position = "salesman" },
        new Staff { Id = 2, Name = "siam", Position = "employee" },
        new Staff { Id = 3, Name = "shahriar", Position = "manager" }
    };

            List<Stadium> stadiums = new List<Stadium>() {
        new Stadium { Location = "sylhet", Capacity = "Fifty Thousand" },
        new Stadium { Location = "Dhaka", Capacity = "Sixty Thousand" }
    };

            var viewModel = new SampleModel
            {
                Player = players,
                Staff = staffs,
                Stadium = stadiums
                
            };

            return View(viewModel);
        }



        public ActionResult OOP()
        {

            return View(Club());
         } 


    }



}