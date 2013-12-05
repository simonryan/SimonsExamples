using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using CastleWindsor_demo.Domain;

namespace CastleWindsor_demo.Services
{
    public class EmployeeService :IEmployeeService
    {
        private string _username;

        public EmployeeService(string username)
        {
            _username = username;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return new Collection<Employee>
                       {
                           new Employee
                               {
                                   Id = 1,
                                   DateOfBirth = DateTime.Now.AddYears(-30),
                                   Department = Department.Manager,
                                   Forename = "Graham",
                                   Surname = "Hall",
                                   Number = "1111A"
                               },
                               new Employee
                               {
                                   Id = 2,
                                   DateOfBirth = DateTime.Now.AddYears(-16),
                                   Department = Department.Checkout,
                                   Forename = "Susan",
                                   Surname = "Boyle",
                                   Number = "111C1"
                               },
                               new Employee
                               {
                                   Id = 3,
                                   DateOfBirth = DateTime.Now.AddYears(-15),
                                   Department = Department.Checkout,
                                   Forename = "Tom",
                                   Surname = "Hardy",
                                   Number = "111C2"
                               },
                               new Employee
                               {
                                   Id = 4,
                                   DateOfBirth = DateTime.Now.AddYears(-16),
                                   Department = Department.Checkout,
                                   Forename = "Greg",
                                   Surname = "Baker",
                                   Number = "111C3"
                               },
                               new Employee
                               {
                                   Id = 5,
                                   DateOfBirth = DateTime.Now.AddYears(-17),
                                   Department = Department.Checkout,
                                   Forename = "Kate",
                                   Surname = "Young",
                                   Number = "111C4"
                               },
                               new Employee
                               {
                                   Id = 6,
                                   DateOfBirth = DateTime.Now.AddYears(-22),
                                   Department = Department.ShelfFiller,
                                   Forename = "Nigel",
                                   Surname = "Smith",
                                   Number = "111S1"
                               },
                               new Employee
                               {
                                   Id = 7,
                                   DateOfBirth = DateTime.Now.AddYears(-19),
                                   Department = Department.ShelfFiller,
                                   Forename = "Celia",
                                   Surname = "Russell",
                                   Number = "111S2"
                               }
                       };
        }
    }
}