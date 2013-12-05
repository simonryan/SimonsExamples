using System.Collections.Generic;
using CastleWindsor_DI.Domain;

namespace CastleWindsor_DI.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
    }
}