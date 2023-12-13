using _3_ViewToController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_ViewToController.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            List<Student> students = new List<Student>() 
            {
            new Student(){ Name = "Vihaan", Gender = "Male", Email = "v@v.com"},
            new Student(){ Name = "Mihaan", Gender = "Male", Email = "m@v.com"},
            new Student(){ Name = "Pari", Gender = "Female", Email = "r@v.com"}
            };

            return View(students);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(string search)
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Create(string name, string gender, string email)
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Create(FormCollection form)
        //{
        //    string name = form["name"];
        //    string gender = form["gender"];
        //    string email = form["email"];

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Create([Bind(Exclude = "Email")] Student student)
        //{
        //    string name = student.Name;
        //    string gender = student.Gender;
        //    string email = student.Email;

        //    return View();
        //}

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            Student student = new Student();
            // UpdateModel<Student>(student);
            UpdateModel<IStudent>(student);

            //string name = student.Name;
            //string gender = student.Gender;
            //string email = student.Email;

            return View();
        }
    }
}