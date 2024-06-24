using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practice.Models;

namespace practice.Controllers
{
    public class ProductController : Controller
    {





        public ActionResult Product1()
        {
            var pro = new Product()
            {

                Id = 1,
                Name = "Potatoto Chip",
                Price = 20,
                Quantity = 100,
                Category = "Lays",
                ProductionDate = "05/10/2023",
                IsDisposable = true,
                Helpline = 01781151001,
                SupportMail = "farhanamin092@gmail.com"


            };


            return View(pro);
        }


        public ActionResult Product2()
        {

            List<Product> list = new List<Product>() {
            new Product { Id = 1, Name = "Potatoto Chip",Price = 20, Quantity = 100,Category = "Lays",ProductionDate = "05/10/2023",IsDisposable = true,Helpline = 01781151001,SupportMail = "farhanamin092@gmail.com"},
           new Product { Id = 2, Name = "Fruit",Price = 200, Quantity = 200,Category = "Mango",ProductionDate = "05/10/2023",IsDisposable = true,Helpline = 01781151001,SupportMail = "farhanamin092@gmail.com"},
           new Product { Id = 3, Name = "Vegetable",Price = 70, Quantity = 300,Category = "Potato",ProductionDate = "05/10/2023",IsDisposable = true,Helpline = 01781151001,SupportMail = "farhanamin092@gmail.com"},

            };




            return View(list);
        }


        public ActionResult Product3()
        {

            List<Product> list = new List<Product>() {
            new Product { Id = 1, Name = "Potatoto Chip",Price = 20, Quantity = 100,Category = "Lays",ProductionDate = "05/10/2023",IsDisposable = true,Helpline = 01781151001,SupportMail = "farhanamin092@gmail.com"},
           new Product { Id = 2, Name = "Fruit",Price = 200, Quantity = 200,Category = "Mango",ProductionDate = "05/10/2023",IsDisposable = true,Helpline = 01781151001,SupportMail = "farhanamin092@gmail.com"},
           new Product { Id = 3, Name = "Vegetable",Price = 70, Quantity = 300,Category = "Potato",ProductionDate = "05/10/2023",IsDisposable = true,Helpline = 01781151001,SupportMail = "farhanamin092@gmail.com"},

            };




            return View(list);
        }



    }



}