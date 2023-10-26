using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP.WEB.Controllers
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
        public ActionResult Details()
        {
            ViewBag.Message = "Details";

            return View(); 
        }
        public ActionResult Posts()
        {
            ViewBag.Message = "Posts";

            return View(); 
        }
        public ActionResult Categories()
        {
            ViewBag.Message = "Categories";

            return View(); 
        }

        public ActionResult Users()
        {
            ViewBag.Message = "Users";

            return View();
        }

        public ActionResult Profile2()
        {
            ViewBag.Message = "Profile";

            return View();
        }
        public ActionResult Settings()
        {
            ViewBag.Message = "Settings";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Login";

            return View();
        }
    }
}