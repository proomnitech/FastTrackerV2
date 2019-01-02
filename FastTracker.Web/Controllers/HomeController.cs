using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastTracker.Web.Controllers
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
            ViewBag.Message = "Application contact page.";

            return View();
        }

        public ActionResult Dropdown()
        {
            ViewBag.Message = "Application dropdown page.";

            return View();
        }

        public ActionResult SubMenu1()
        {
            ViewBag.Message = "Application submenu 1 page.";

            return View();
        }

        public ActionResult SubMenu2()
        {
            ViewBag.Message = "Application submenu 2 page.";

            return View();
        }

        public ActionResult SubMenu3()
        {
            ViewBag.Message = "Application submenu 3 page.";

            return View();
        }
    }
}