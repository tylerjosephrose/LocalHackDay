using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            ViewBag.Message = "Application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // <Seth Dippold> 03-Dec-2016
        // Adding FAQ controller page
        public ActionResult FAQ()
        {
            ViewBag.Message = "FAQ Page";

            return View();
        }
    }
}