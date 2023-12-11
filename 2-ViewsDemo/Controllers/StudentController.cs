using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_ViewsDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index1()
        {
            return View();
        }

        public ViewResult Index2()
        {
            return View();
        }

        public PartialViewResult PartialView2Content()
        {
            return PartialView("_PartialView2","Vishal");
        }
    }
}