using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExamples
{
    public static class Grouping
    {
        public static void GroupByExample()
        {
            var groupedByDepartment = from e in EmployeesRepository.GetAllEmployees()
                                      group e by e.Department;
            DisplayGroupedEmployees(groupedByDepartment);
        }

        public static void GroupByUsingInto()
        {
            var groupedByDepartment = from e in EmployeesRepository.GetAllEmployees()
                                      group e by e.Department into groups
                                      orderby groups.Key
                                      where groups.Key == "Accounts" || groups.Key == "HR"
                                      select groups;
            DisplayGroupedEmployees(groupedByDepartment);
        }

        private static void DisplayGroupedEmployees(IEnumerable<IGrouping<string, Employee>> groupedEmployees)
        {
            foreach (var department in groupedEmployees)
            {
                Console.WriteLine(department.Key);
                foreach (var employee in department)
                {
                    Console.WriteLine(string.Format("{0} {1}", employee.Firstname, employee.Surname));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
