using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _5_ListingFeatures.Models;
using PagedList;
using PagedList.Mvc;

namespace _5_ListingFeatures.Controllers
{
    public class TrainersController : Controller
    {
        private StudentDbContext db = new StudentDbContext();

        // GET: Trainers
        public ActionResult Index(string search, string sort, int? page)
        {
            //SqlConnection con = new SqlConnection();
            //SqlTransaction transaction = con.BeginTransaction();

            //try
            //{
            //    //
            //    //
            //    transaction.Commit();
            //}
            //catch
            //{
            //    // 
            //    transaction.Rollback();
            //}


            ViewBag.NameSort = (string.IsNullOrEmpty(sort) ||
                sort != "Name") ? "Name" : "Name desc";
            ViewBag.ExperienceSort = sort == "Experience" ? "Experience desc" : "Experience";

            IEnumerable<Trainer> trainers = new List<Trainer>();

            if (string.IsNullOrEmpty(search))
            {
                switch (sort)
                {
                    case "Name":
                        trainers = db.Trainers.ToList().OrderBy(s => s.Name);
                        break;
                    case "Name desc":
                        trainers = db.Trainers.ToList().OrderByDescending(s => s.Name);
                        break;
                    case "Experience":
                        trainers = db.Trainers.ToList().OrderBy(t => t.Experience);
                        break;
                    case "Experience desc":
                        trainers = db.Trainers.ToList().OrderByDescending(t => t.Experience);
                        break;
                    default:
                        trainers = db.Trainers.ToList().OrderBy(s => s.Name);
                        break;
                }

                return View(trainers.ToPagedList(page ?? 1, 5));
            }
            else
            {
                //var trainers = db.Trainers.ToList()
                //    .Where(t => IsSearchedMatch(t, search));

                switch (sort)
                {
                    case "Name desc":
                        trainers = db.Trainers.ToList()
                    .Where(t => IsSearchedMatch(t, search)).OrderByDescending(s => s.Name);
                        break;
                    case "Experience":
                        trainers = db.Trainers.ToList()
                    .Where(t => IsSearchedMatch(t, search)).OrderBy(t => t.Experience);
                        break;
                    case "Experience desc":
                        trainers = db.Trainers.ToList()
                    .Where(t => IsSearchedMatch(t, search)).OrderByDescending(t => t.Experience);
                        break;
                    default:
                        trainers = db.Trainers.ToList()
                    .Where(t => IsSearchedMatch(t, search)).OrderBy(s => s.Name);
                        break;
                }

                return View(trainers.ToPagedList(page ?? 1, 5));
            }
        }

        public PartialViewResult TrainersList()
        {
            return PartialView("_TrainersList", db.Trainers.ToList().ToPagedList(1, 5));
        }

        private bool IsSearchedMatch(Trainer t, string search)
        {
            bool n1 = t.Name.Contains(search);
            bool c1 = (t.City != null) ? t.City.Contains(search) : false;
            bool e1 = t.Experience.ToString() == search;
            bool e2 = (t.Email != null) ? t.Email.Contains(search) : false;

            return n1 || c1 || e1 || e2;
        }

        // GET: Trainers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainer trainer = db.Trainers.Find(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            return View(trainer);
        }

        // GET: Trainers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trainers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Experience,City,Email,DateOfBirth")] Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                db.Trainers.Add(trainer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trainer);
        }

        // GET: Trainers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainer trainer = db.Trainers.Find(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            return View(trainer);
        }

        // POST: Trainers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Experience,City,Email,DateOfBirth")] Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trainer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trainer);
        }

        // GET: Trainers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainer trainer = db.Trainers.Find(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            return View(trainer);
        }

        // POST: Trainers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trainer trainer = db.Trainers.Find(id);
            db.Trainers.Remove(trainer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        [HttpPost]
        public ActionResult DeleteMultiple(IEnumerable<int> TrainerToDelete)
        {
            foreach (int id in TrainerToDelete)
            {
                Trainer t = db.Trainers.Find(id);
                db.Trainers.Remove(t);
            }
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
