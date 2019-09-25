using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Data;

namespace fabrica_de_voluntari.Areas.Gfest.Controllers
{
    public class ActivitatesController : Controller
    {
        private Gfest2019 db = new Gfest2019();

        // GET: Gfest/Activitates
        public ActionResult Index()
        {
            return View(db.Activitati.ToList());
        }

        // GET: Gfest/Activitates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activitate activitate = db.Activitati.Find(id);
            if (activitate == null)
            {
                return HttpNotFound();
            }
            return View(activitate);
        }

        // GET: Gfest/Activitates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gfest/Activitates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nume,Descriere,Path_Icon")] Activitate activitate)
        {
            if (ModelState.IsValid)
            {
                db.Activitati.Add(activitate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(activitate);
        }

        // GET: Gfest/Activitates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activitate activitate = db.Activitati.Find(id);
            if (activitate == null)
            {
                return HttpNotFound();
            }
            return View(activitate);
        }

        // POST: Gfest/Activitates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nume,Descriere,Path_Icon")] Activitate activitate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activitate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(activitate);
        }

        // GET: Gfest/Activitates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activitate activitate = db.Activitati.Find(id);
            if (activitate == null)
            {
                return HttpNotFound();
            }
            return View(activitate);
        }

        // POST: Gfest/Activitates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Activitate activitate = db.Activitati.Find(id);
            db.Activitati.Remove(activitate);
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
    }
}
