using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerKata.Repository;

namespace ControllerKata.Controllers
{
    public class MyController : Controller
    {
        //
        // GET: /Welcome/

        private readonly ICustomerRepository _repo;
        public MyController(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public MyController()
        {
            
        }

        public ActionResult Index()
        {
            ViewData["message"] = "Welcome";
            return View();
        }

        public ActionResult GetCustomers()
        {
            var customers = _repo.GetAll();
            return View(customers);
        }


        public RedirectToRouteResult GetHelp(string topic)
        {
            return RedirectToAction("Index", "HelpController", new {HelpTopic = topic});
        }
    }
}
