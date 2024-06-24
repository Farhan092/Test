using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using practice.Models;


namespace practice.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var emp = new Employee()
            {
                Id = 1,
                Name = "farhan",
                Password = "12345"

            };
            return View(emp);
        }
    }
}