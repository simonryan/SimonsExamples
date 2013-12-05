using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CastleWindsor_demo.Domain;

namespace CastleWindsor_demo.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
    }
}
