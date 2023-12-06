using _1_MVCProjectStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_MVCProjectStructure.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ViewResult Create()
        {
            // return View(); // by default it searches for Create name view inside Student folder
            // return View("NewStudent");
            return View("~/Views/Custom/CreateNewStudent.cshtml");
        }

        public JsonResult AllStudents()
        {
            List<Student> students = new List<Student>() 
            {
            new Student(){ RollNumber = 1, Name = "Vishal",City = "Pune"},
            new Student(){ RollNumber = 2, Name = "Mahesh",City = "Mumbai"},
            new Student(){ RollNumber = 3, Name = "Kunal",City = "Satara"}
            };

            return Json(students, JsonRequestBehavior.AllowGet);
        }

        // get:  http://localhost/student/studentname
        [HttpGet]
        [ActionName("StudentName")]
        public ContentResult StudentName_1()
        {
            return Content("Vishal");
        }

        // post: http://localhost/student/studentname
        [HttpPost]
        [ActionName("StudentName")]
        public ContentResult StudentName_2()
        {
            return Content("Mahesh");
        }
    }
}