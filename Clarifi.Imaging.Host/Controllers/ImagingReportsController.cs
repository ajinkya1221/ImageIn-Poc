using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Clarifi.Imaging.Host.Models;

namespace Clarifi.Imaging.Host.Controllers
{
    public class ImagingReportsController : Controller
    {
        public ActionResult Index()
        {
            var model = GetReportsData();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            ViewBag.InitialData = (serializer.Serialize(model));
            return View(model);
        }

        [HttpGet]
        public JsonResult GetReports()
        {
            ReportSummary model = GetReportsData();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        private ReportSummary GetReportsData()
        {
            var model = new ReportSummary();
            model.CategoryReports = new List<CategoryReport>();
            model.UserReports = new List<UserReport>();
            for (var i = 0; i < 10; i++)
            {
                model.CategoryReports.Add(new CategoryReport()
                {
                    Id = 1,
                    LastUpdatedOn = DateTime.Now.ToString(),
                    Name = "Pool Side Area",
                    ProcessedImages = 11233,
                    TotalImages = 131321
                });
                model.UserReports.Add(new UserReport()
                {
                    Id = 1,
                    LastUpdatedOn = DateTime.Now.ToString(),
                    Name = "Pool Side Area",
                    ProcessedImages = 11233,
                    TotalImages = 131321
                });
            }
            return model;
        }
    }
}