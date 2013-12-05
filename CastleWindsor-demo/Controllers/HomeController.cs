using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CastleWindsor_demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return RedirectToAction("Index", "Employees");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
