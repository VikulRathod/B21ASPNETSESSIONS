using _4_CRUDUsingEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_CRUDUsingEF.Areas.student.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index(int? trainerId)
        {
            StudentDbContext db = new StudentDbContext();
            List<Student> students = null;

            if (trainerId == null)
            {                
                students = db.Students.ToList();
            }
            else
            {
                students = db.Students.Where(t => t.TrainerId == (int)trainerId)?.ToList();
                ViewBag.TrainerName = db.Trainers.
                    FirstOrDefault(t => t.Id == trainerId)?.Name;
            }

            return View(students);
        }
    }
}