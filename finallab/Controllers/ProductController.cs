using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalLabCF.Context;
using FinalLabCF.Models;

namespace FinalLabCF.Controllers
{
    public class ProductController : Controller
    {
        private AppProductDBContext _dbContext;


        public ProductController()
        {
            this._dbContext = new AppProductDBContext();
        }
        // GET: Product
        public ActionResult Index()
        {
            var proList = _dbContext.Product.Include(m=>m.Category).ToList();
            return View(proList);
           
        }

        public ActionResult AddProduct()
        {
            

            return View();

        }
        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {


            if (ModelState.IsValid)
            {
                _dbContext.Product.Add(product);
                _dbContext.SaveChanges();
                TempData["MsgAdd"] = "Product Information Added Successfully";



                return RedirectToAction("Index");
            }
            return View("AddProduct", product);


        }
    }
}