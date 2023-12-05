using _1_MVCProjectStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _1_MVCProjectStructure.Controllers
{
    // [RoutePrefix("trainer")]
    [RoutePrefix("vhaash")]
    public class TrainerController : Controller
    {
        // vhaash
        [Route("")]
        public string Welcome()
        {
            return "<h1>My MVC First Application</h1>";
        }

        // vhaash/vishal
       //  [Route("{name:string}")]
        // [Route("{id:int}")]
        public string Hello(string name)
        {
            return $"Good Morning, {name}";
        }

        // trainer/alltrainers
        // trainer/dashboard
        // vhaash/dashboard
        [Route("dashboard")]
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

        [Route("index1/{id?}")]
        public string Index1(int? id)
        {
            return $"Index 1 : Url passed values : {id ?? 0}";
        }

        [Route("index2/{id?}/{name?}")]
        public string Index2(int? id, string name)
        {
            return $"Index 2 : Url passed values : {id ?? 0} {name}";
        }
    }
}