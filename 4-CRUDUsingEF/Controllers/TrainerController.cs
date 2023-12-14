using _4_CRUDUsingEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_CRUDUsingEF.Controllers
{
    public class TrainerController : Controller
    {
        // GET: Trainer
        public ActionResult Index()
        {
            // retrieve trainers data from table
            // show trainers list on view

            StudentDbContext db = new StudentDbContext();
            var trainers = db.Trainers.ToList(); // List<Trainer>

            return View(trainers);
        }
    }
}