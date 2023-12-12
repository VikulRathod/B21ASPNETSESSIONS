using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_ViewToController.Controllers
{
    public class TrainerController : Controller
    {
        // GET: Trainer
        public ActionResult Index()
        {
            return View();
        }

        // [HttpGet]
        [HttpPost]
        // [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Details(string trainerName, string Name, 
            string Email)
        {
            ViewBag.message = trainerName;
            ViewBag.name = Name;
            ViewBag.email = Email;
            return View();
        }
    }
}