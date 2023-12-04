using _1_MVCProjectStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_MVCProjectStructure.Controllers
{
    public class TrainerController : Controller
    {
        public string Welcome()
        {
            return "<h1>My MVC First Application</h1>";
        }

        public ActionResult AllTrainers()
        {
            List<Trainer> trainers = new List<Trainer>() 
            {
            new Trainer(){ Id= 101, Name = "Vikul", Experience = 14},
            new Trainer(){ Id= 102, Name = "Usha", Experience = 3},
            new Trainer(){ Id= 103, Name = "Atul", Experience = 2}
            };

            ViewBag.Trainers = trainers;

            return View();
        }
    }
}