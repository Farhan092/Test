using CRUDEF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDEF.Controllers
{
    public class EmployeeController : Controller
    {

        AspDbEntities _dbContext;

        public EmployeeController()
        {

            _dbContext = new AspDbEntities();


        }



        // GET: Employee
        
        public ActionResult Index()
        {
            if (Session["username"] == null)
                return RedirectToAction("Login","User");
            var empList = _dbContext.Employees.ToList();
            return View(empList);
        }
        [HttpGet]

        public ActionResult AddEmployee()
        {
            if (Session["username"] == null)
                return RedirectToAction("Login", "User");

            if(Session["username"] != null && Session["type"].ToString().Equals("member"))
                return RedirectToAction("Index", "Employee");

            return View();

        }
        [HttpPost]
        public ActionResult CreateEmployee(Employee emp)
        {

           

            if (ModelState.IsValid)
            {
                _dbContext.Employees.Add(emp);
                _dbContext.SaveChanges();
                TempData["MsgAdd"] = "Employee Information Added Successfully";



                return RedirectToAction("Index");
            }
            return View("AddEmployee",emp);


        }




        [HttpGet]
        public ActionResult EditEmployee(int id)
        {

            if (Session["username"] == null)
                return RedirectToAction("Login", "User");

            if (Session["username"] != null && Session["type"].ToString().Equals("member"))
                return RedirectToAction("Index", "Employee");

            var emp = _dbContext.Employees.Find(id);
            if (emp == null)
            {
                TempData["MsgEditError"] = "Employee Not Found";
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        [HttpPost]
        public ActionResult UpdateEmployee(Employee emp)
        {
            if (ModelState.IsValid)
            {
                var existingEmp = _dbContext.Employees.Find(emp.Id);
                if (existingEmp != null)
                {
                    existingEmp.Name = emp.Name;
                    existingEmp.JoinDate = emp.JoinDate;
                    existingEmp.Email = emp.Email;
                    existingEmp.Cell = emp.Cell;
                    existingEmp.Salary = emp.Salary;
                    existingEmp.Designation = emp.Designation;

                    _dbContext.SaveChanges();
                    TempData["MsgEdit"] = "Employee Information Updated Successfully";
                    return RedirectToAction("Index");
                }
                    
                TempData["MsgEditError"] = "Employee Not Found";
                return RedirectToAction("Index");
                    
                
                
            }
            
            return View("EditEmployee", emp);
        }

        public ActionResult Delete(int id)
        {
            if (Session["username"] == null)
                return RedirectToAction("Login", "User");

            if (Session["username"] != null && Session["type"].ToString().Equals("member"))
                return RedirectToAction("Index", "Employee");

            var data = _dbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
            _dbContext.Employees.Remove(data);
            _dbContext.SaveChanges();
            TempData["MsgDel"] = "Employee Information Deleted Successfully";

            return RedirectToAction("Index");



        }





 


    }
}
