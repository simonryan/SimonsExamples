using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WCF_firstService
{
    // this attribute allows us to run a singleton of the service in memory and have the collection in memory 
    // - for purpose of demo
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EmployeeService : IEmployeeService
    {
        List<Employee> _employees = new List<Employee>
                                        {
                                            new Employee{Id = new Guid(), Surname = "Ryan", Forename = "Simon", DateOfBirth = new DateTime(1972, 11, 21), Department  = Department.Manager, Number = "2352"},
                                            new Employee{Id = new Guid(), Surname = "Smith", Forename = "Jane", DateOfBirth = new DateTime(1976, 1, 11), Department  = Department.Checkout, Number = "2353"},
                                            new Employee{Id = new Guid(), Surname = "Davis", Forename = "Harry", DateOfBirth = new DateTime(1981, 6, 15), Department  = Department.ShelfFiller, Number = "2353"}
                                        };

        public IList<Employee> GetAll()
        {
            return _employees;
        }

        public Employee GetEmployeeById(Guid id)
        {
            return _employees.Find(e => e.Id.Equals(id));
        }

        public void AddEmployee(Employee employee)
        {
            employee.Id = new Guid();
            _employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            _employees.Remove(_employees.Find(e => e.Id.Equals(employee.Id)));
        }
    }
}
