using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using diegofernandobarrios18122017_HitssPruebaAsp.Net.Models;

namespace diegofernandobarrios18122017_HitssPruebaAsp.Net.Controllers
{
    public class MattersController : Controller
    {
        private diegofernandobarrios18122017_HitssPruebaAspNetContext db 
            = new diegofernandobarrios18122017_HitssPruebaAspNetContext();

        public ActionResult Index()
        {
            return View(db.Matters.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Matter matter = db.Matters.Find(id);
            if (matter == null)
            {
                return HttpNotFound();
            }
            return View(matter);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Grade")] Matter matter)
        {
            if (ModelState.IsValid)
            {
                db.Matters.Add(matter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(matter);
        }

        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Matter matter = db.Matters.Find(id);
            if (matter == null)
            {
                return HttpNotFound();
            }
            return View(matter);
        }

        public ActionResult addTeacher(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Matter matter = db.Matters.Find(id);
            if (matter == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdTeacher = new SelectList(db.Teachers,"Id","Lastname");
            return View(matter);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Grade")] Matter matter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(matter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(matter);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Matter matter = db.Matters.Find(id);
            if (matter == null)
            {
                return HttpNotFound();
            }
            return View(matter);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Matter matter = db.Matters.Find(id);
            db.Matters.Remove(matter);
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
