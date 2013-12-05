using System.Web.Mvc;

namespace Mvc2Fundamentals.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
