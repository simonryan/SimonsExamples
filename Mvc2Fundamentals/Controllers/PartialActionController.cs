using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc2Fundamentals.Controllers
{
    public class PartialActionController : Controller
    {
        //
        // GET: /PartialAction/

        public ActionResult Index()
        {
            var model = new
                {
                    Text = "** Data **"
                };
            return View(model);
        }

    }
}
