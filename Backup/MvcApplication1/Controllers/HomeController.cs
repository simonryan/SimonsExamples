using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }



        public ActionResult Help()
        {
            var helpDoc = new HelpDoc
                               {
                                   Text = "This is a test help doc"
                               };
            return View(helpDoc);
        }
    }

    public class HelpDoc
    {
        public string Text { get; set; }
    }
}
