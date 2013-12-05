using System.Web.Mvc;

namespace CastleWindsor_DI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Employee");
        }

    }
}
