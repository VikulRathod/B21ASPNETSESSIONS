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
            TempData["sample"] = "Data created in Index 1 Request";

            return View();
        }

        public ActionResult Index2()
        {
            // ViewBag.data = TempData["sample"]; // from previous request

            // ViewBag.data = TempData.Peek("sample");

            ViewBag.data = TempData["sample"];
            TempData.Keep("sample");

            ViewData["name"] = "Vihaan Rathod";

            Trainer t = new Trainer() { TrainerId = 1, Name = "Usha", Experience = 3};
            ViewData["trainer"] = t;

            ViewBag.Email = "vihaan@gmail.com";
            ViewBag.newtrainer = 
                new Trainer() { TrainerId = 2, Name = "Atul", Experience = 2 };

            return View(t);
        }

        public ActionResult Index3()
        {
            // ViewBag.data = TempData["sample"]; // from previous request
            TempData["message"] = "Data passed using TempData";

            return View();
        }

        public ActionResult Index4()
        {
            ViewBag.data = TempData["sample"]; // from previous request

            return View();
        }
    }
}