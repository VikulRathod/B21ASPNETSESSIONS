using _2_ViewsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_ViewsDemo.Controllers
{
    public class TrainerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            ViewData["name"] = "Vihaan Rathod";

            Trainer t = new Trainer() { TrainerId = 1, Name = "Usha", Experience = 3};
            ViewData["trainer"] = t;

            ViewBag.Email = "vihaan@gmail.com";
            ViewBag.newtrainer = 
                new Trainer() { TrainerId = 2, Name = "Atul", Experience = 2 };

            return View(t);
        }
    }
}