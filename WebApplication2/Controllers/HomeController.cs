using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Company()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Company(CompanyName input)
        {
            //if (!string.IsNullOrEmpty(input.Name))
            //{
            //    ModelState.AddModelError("Name", "This field is required");
            //}
            if (ModelState.IsValid)
            {

                return View("Index");
            }
            else
            {
                return View(input);
            }
            //return View();
        }

        public JsonResult IsExistsEmail(string EmailAddress)
        {
            if (EmailAddress.Contains("info"))
                return Json(true, JsonRequestBehavior.AllowGet);
            else
                return Json(false, JsonRequestBehavior.AllowGet);
        }
    }
}