using System.Web.Mvc;
using CastleWindsor_demo.Services;

namespace CastleWindsor_demo.Controllers
{
    public class EmployeesController : Controller
    {
        private IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public ActionResult Index()
        {
            var model = _employeeService.GetEmployees();

            return View(model);
        }

    }
}
