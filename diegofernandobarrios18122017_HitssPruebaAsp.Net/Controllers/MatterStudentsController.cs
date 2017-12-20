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
    public class MatterStudentsController : Controller
    {
        private diegofernandobarrios18122017_HitssPruebaAspNetContext db
            = new diegofernandobarrios18122017_HitssPruebaAspNetContext();

        
        public ActionResult Index()
        {
            return View(db.MattersStudents.ToList());
        }

        
        public ActionResult Create()
        {
            ViewBag.IdMatter = new SelectList(db.Matters, "Id", "Name");
            ViewBag.IdStudent = new SelectList(db.Students, "Id", "Name", "Lastname");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMatter,IdStudent,NoteOne,NoteTwo")] MatterStudent matterStudent)
        {
            if (ModelState.IsValid)
            {
                db.MattersStudents.Add(matterStudent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(matterStudent);
        }

        
        public ActionResult Edit(int? IdMatter, int? IdStudent)
        {
            if (IdMatter == null && IdStudent == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatterStudent matterStudent = db.MattersStudents.Find(IdMatter, IdStudent);
            if (matterStudent == null)
            {
                return HttpNotFound();
            }
            return View(matterStudent);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdMatter,IdStudent,NoteOne,NoteTwo")] MatterStudent matterStudent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(matterStudent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(matterStudent);
        }

        
        public ActionResult Delete(int? IdMatter, int? IdStudent)
        {
            if (IdMatter == null && IdStudent == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatterStudent matterStudent = db.MattersStudents.Find(IdMatter, IdStudent);
            if (matterStudent == null)
            {
                return HttpNotFound();
            }
            return View(matterStudent);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? IdMatter, int? IdStudent)
        {
            MatterStudent matterStudent = db.MattersStudents.Find(IdMatter, IdStudent);
            db.MattersStudents.Remove(matterStudent);
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
