﻿using _4_CRUDUsingEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace _4_CRUDUsingEF.Controllers
{
    // [Authorize]
    public class TrainerController : Controller
    {
        // [Authorize]
        // [AllowAnonymous]
        // GET: Trainer
        public ActionResult Index()
        {
            // retrieve trainers data from table
            // show trainers list on view

            StudentDbContext db = new StudentDbContext();
            var trainers = db.Trainers.ToList(); // List<Trainer>

            return View(trainers);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Trainer trainer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    StudentDbContext db = new StudentDbContext();
                    db.Trainers.Add(trainer);

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int? trainerId)
        {
            StudentDbContext db = new StudentDbContext();
            Trainer trainer = db.Trainers.FirstOrDefault(t => t.Id == trainerId);

            return View(trainer);
        }

        [HttpPost]
        public ActionResult Edit(Trainer trainer)
        {
            StudentDbContext db = new StudentDbContext();
            try
            {
                Trainer dbTrainer = db.Trainers.FirstOrDefault(t =>
                t.Id == trainer.Id);

                dbTrainer.Name = trainer.Name;
                dbTrainer.Experience = trainer.Experience;
                dbTrainer.City = trainer.City;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                Trainer loadTrainer = db.Trainers.FirstOrDefault(t => t.Id == trainer.Id);

                return View(loadTrainer);
            }
        }

        [HttpGet]
        public ActionResult Delete(int? trainerId)
        {
            StudentDbContext db = new StudentDbContext();
            Trainer dbTrainer = db.Trainers.FirstOrDefault(t => t.Id == trainerId);

            //db.Trainers.Remove(dbTrainer);
            //db.SaveChanges();

            return View(dbTrainer);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete_Confirmed(int? Id)
        {
            StudentDbContext db = new StudentDbContext();
            Trainer dbTrainer = db.Trainers.FirstOrDefault(t => t.Id == Id);
            try
            {

                db.Trainers.Remove(dbTrainer);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(dbTrainer);
            }
        }

        [HttpGet]
        public ActionResult Details(int? trainerId)
        {
            StudentDbContext db = new StudentDbContext();
            Trainer trainer = db.Trainers.FirstOrDefault(t => t.Id == trainerId);

            return View(trainer);
        }

        [HttpGet]
        public JsonResult IsEmailExists(string Email)
        {
            StudentDbContext db = new StudentDbContext();

            bool isExists = db.Trainers.Any(t => t.Email == Email);

            return Json(!isExists, JsonRequestBehavior.AllowGet);
        }
    }
}