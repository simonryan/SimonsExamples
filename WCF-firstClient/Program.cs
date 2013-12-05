using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCF_firstClient.EmployeeService;

namespace WCF_firstClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please a key to add an employee");
            Console.ReadKey();
            var employeeService = new EmployeeServiceClient("firstService_wsHttpBinding");
            var employee = new Employee
                               {
                                   Surname = "Ryan",
                                   Forename = "Simon",
                                   DateOfBirth = new DateTime(1972, 11, 21),
                                   Department = Department.Manager
                               };
            employeeService.AddEmployee(employee);

            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }
    }
}
