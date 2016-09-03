using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_matching.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Matching x with y to save you time";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get in touch";

            return View();
        }
    }
}