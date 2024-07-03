using CRUDEF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDEF.Controllers
{
    public class UserController : Controller
    {
        AspDbEntities _dbContext;

        public UserController()
        {

            _dbContext = new AspDbEntities();


        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User u)
        {
            ModelState.Remove("RePassword");
            if (ModelState.IsValid)
            {
                var data = _dbContext.Users.Where(x => x.Username == u.Username && x.Password ==u.Password).FirstOrDefault();
                if (data != null) 
                {
                    Session["username"] = data.Username;
                    Session["type"] = data.Type;
                    return RedirectToAction("Index", "Employee");
                
                }
                ViewBag.Invalid = "Invalid User";
                ModelState.Clear();
                return View();


            }

            ModelState.Clear();
            return View();
        }

        public ActionResult Logout()
        {

            Session.Clear();
            Session.Abandon();
            ViewBag.Logout = "Logged out from the system";
            return View("Login");
        }


        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(User u) 
        {
            if(_dbContext.Users.Any(x => x.Username == u.Username))
            {
                ModelState.Clear(); 
                return View();
            }
            _dbContext.Users.Add(u);
            _dbContext.SaveChanges();
            return View("Login");
        }
    }
}