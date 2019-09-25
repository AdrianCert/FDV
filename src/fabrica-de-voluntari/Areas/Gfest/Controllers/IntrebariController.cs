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
    public class IntrebariController : Controller
    {
        private Gfest2019 db = new Gfest2019();

        // GET: Gfest/Intrebari
        public ActionResult Index()
        {
            return View(db.Intrebari.ToList());
        }

        // GET: Gfest/Intrebari/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intrebare intrebare = db.Intrebari.Find(id);
            if (intrebare == null)
            {
                return HttpNotFound();
            }
            return View(intrebare);
        }

        // GET: Gfest/Intrebari/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gfest/Intrebari/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Enunt,Image,Path_Icon,Var1,Var2,Var3,Var4,IstrueVar1,IstrueVar2,IstrueVar3,IstrueVar4")] Intrebare intrebare)
        {
            if (ModelState.IsValid)
            {
                db.Intrebari.Add(intrebare);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(intrebare);
        }

        // GET: Gfest/Intrebari/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intrebare intrebare = db.Intrebari.Find(id);
            if (intrebare == null)
            {
                return HttpNotFound();
            }
            return View(intrebare);
        }

        // POST: Gfest/Intrebari/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Enunt,Image,Path_Icon,Var1,Var2,Var3,Var4,IstrueVar1,IstrueVar2,IstrueVar3,IstrueVar4")] Intrebare intrebare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(intrebare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(intrebare);
        }

        // GET: Gfest/Intrebari/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intrebare intrebare = db.Intrebari.Find(id);
            if (intrebare == null)
            {
                return HttpNotFound();
            }
            return View(intrebare);
        }

        // POST: Gfest/Intrebari/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Intrebare intrebare = db.Intrebari.Find(id);
            db.Intrebari.Remove(intrebare);
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
