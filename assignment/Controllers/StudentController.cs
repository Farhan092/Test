using assignment.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practice.Controllers
{
    public class StudentController : Controller
    {
        AspDbEntities _dbContext;

        public StudentController()
        {

            _dbContext = new AspDbEntities();


        }
        public ActionResult Index()
        {
            var studentList = _dbContext.Students.ToList();
            return View(studentList);

        }



        public ActionResult AddStudent()
        {

            var dep = _dbContext.Departments.ToList();
            ViewData["departments"] = new SelectList(dep, "DepId", "DepName");
            return View();



        }
        [HttpPost]
        public ActionResult CreateStudent(Student stu)
        {



            if (ModelState.IsValid)
            {
                _dbContext.Students.Add(stu);
                _dbContext.SaveChanges();
                TempData["MsgAdd"] = "Student Information Added Successfully";



                return RedirectToAction("Index");
            }
            var dep = _dbContext.Departments.ToList();
            ViewData["departments"] = new SelectList(dep, "DepId", "DepName");


            return View("AddStudent", stu);


        }
    }
}