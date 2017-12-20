using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Rotativa;
using diegofernandobarrios18122017_HitssPruebaAsp.Net.Models;

namespace diegofernandobarrios18122017_HitssPruebaAsp.Net.Controllers
{
    public class ReportsController : Controller
    {
        private diegofernandobarrios18122017_HitssPruebaAspNetContext db
            = new diegofernandobarrios18122017_HitssPruebaAspNetContext();

        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TeacherReport()
        {
            return View(db.Teachers.ToList());
        }

        public ActionResult GeneralReport()
        {
            return View();
        }

        public ActionResult ExportTeacherReport()
        {
            ActionAsPdf report = new ActionAsPdf("TeacherReport")
            {
                FileName = Server.MapPath("~/Content/TeacherReport_" + Guid.NewGuid() + ".pdf")
            };
            return report;
        }
    }
}