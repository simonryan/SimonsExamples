using System;
using System.Linq;
using System.Web.Mvc;
using CastleWindsor_DI.Services;
using CastleWindsor_DI;

namespace CastleWindsor_DI.Controllers.Employee
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        private IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public ActionResult Index()
        {
            var employees = _employeeService.GetEmployees();

            if (!employees.Any())
            {
                throw new Exception();
            }

            return View(employees);
        }

    }
}
