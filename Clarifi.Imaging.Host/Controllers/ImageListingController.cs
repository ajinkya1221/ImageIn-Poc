using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Clarifi.Imaging.Host.Models;

namespace Clarifi.Imaging.Host.Controllers
{
    public class ImageListingController : Controller
    {
        public ActionResult Home()
        {

            return View();
        }

        [HttpGet]
        public JsonResult GetReports()
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
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetDetails()
        {
            var model = new ImageDetailsByCategory();
            model.Images = new List<Image>();
            for (var i = 0; i < 10; i++)
            {
                model.Images.Add(new Image()
                {
                    Id = 1,
                    ReportedOn = DateTime.Now.ToString(),
                    ReportedBy = "CLTS",
                    Url = "http://d3mj096p5q0e20.cloudfront.net/fi/HCM/6/056126A.jpg",
                    Category = "Pool Side Area",
                    Status = Status.unflagged
                });
            }
            model.TotalImages = 12131233;
            model.ProcessedImages = 134322;
            model.UnCategorized = 321;
            model.FlaggedImages = 32;
            model.AssignedImages = 456;
            model.ReviewdImages = 123;

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetImagesByCategory()
        {
            var model = new List<Image>();
            for (var i = 0; i < 10; i++)
            {
                model.Add(new Image()
                {
                    Id = 1,
                    ReportedOn = DateTime.Now.ToString(),
                    ReportedBy = "CLTS",
                    Url = "http://d3mj096p5q0e20.cloudfront.net/fi/HCM/6/056126A.jpg",
                    Category = "Pool Side Area",
                    Status = Status.unflagged
                });
            }
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}