using ProductCRUD.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductCRUD.Controllers
{
    public class ProductController : Controller
    {
              
            AspDbEntities _dbContext;

            public ProductController()
            {

                _dbContext = new AspDbEntities();


            }
       


        
            public ActionResult Index()
            {
                var proList = _dbContext.Products.ToList();
                return View(proList);
            }
            [HttpGet]
            public ActionResult AddProduct()
            {

                return View();

            }
            [HttpPost]
            public ActionResult CreateProduct(Product pro)
            {
                if (ModelState.IsValid)
                {
                    _dbContext.Products.Add(pro);
                    _dbContext.SaveChanges();
                    TempData["MsgAdd"] = "Product Added Successfully";



                    return RedirectToAction("Index");
                }
                return View("AddProduct", pro);


            }




            [HttpGet]
            public ActionResult EditProduct(int id)
            {
                var pro = _dbContext.Products.Find(id);
                if (pro == null)
                {
                    TempData["MsgEditError"] = "Product Not Found";
                    return RedirectToAction("Index");
                }
                return View(pro);
            }

           

            public ActionResult Delete(int id)
            {

                var data = _dbContext.Products.Where(x => x.Id == id).FirstOrDefault();
                _dbContext.Products.Remove(data);
                _dbContext.SaveChanges();
                TempData["MsgDel"] = "Product Deleted Successfully";

                return RedirectToAction("Index");



            }








        }
    }


