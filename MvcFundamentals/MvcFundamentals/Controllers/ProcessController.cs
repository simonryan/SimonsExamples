using System.Linq;
using MvcFundamentals.Infrastructure;
using System.Web.Mvc;
using System.Diagnostics;

namespace MvcFundamentals.Controllers
{
    public class ProcessController : Controller
    {
        //
        // GET: /Process/

        public ActionResult Index()
        {
            return View();
        }

        //[Authorize] // cannot be anonymous - must be logged in
        [Log]
        public ActionResult List()
        {
            var processList = Process.GetProcesses().Select(p => p);

            ViewData.Model = processList.ToList();
            return View();
        }

        public ActionResult Details(int id)
        {
            var processDetail = Process.GetProcesses().Where(p => p.Id == id).ToList().Single();

            return View(processDetail);
        }

    }
}
