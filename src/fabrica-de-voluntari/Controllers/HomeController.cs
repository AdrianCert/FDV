using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fabrica_de_voluntari.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            bool IsGfest = true;
            if (IsGfest)
            {
                return RedirectToAction("Index","Home", new { area = "Gfest" });
            }
            return View();
        }

        public ActionResult About()
        {
            bool IsGfest = true;
            if (IsGfest)
            {
                return RedirectToAction("Index", "Home", new { area = "Gfest" });
            }
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            bool IsGfest = true;
            if (IsGfest)
            {
                return RedirectToAction("Index", "Home", new { area = "Gfest" });
            }
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}