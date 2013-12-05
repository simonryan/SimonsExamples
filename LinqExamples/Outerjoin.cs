using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExamples
{
    public static class Outerjoin
    {
        public static void OuterJoinEmployeesWithPensions()
        {
            var employees = EmployeesRepository.GetAllEmployees();
            var pensions = EmployeesRepository.GetPensions();

            var result = from e in employees
                         join p in pensions on e.Id equals p.EmployeeId
                             into ep
                         from p2 in ep.DefaultIfEmpty()
                         select new
                                    {
                                        e.Id,
                                        Name = string.Format("{0} {1}", e.Firstname, e.Surname),
                                        e.Department,
                                        Pension = p2.AccountNo ?? string.Empty
                                    };

            foreach (var employee in result)
            {
                Console.WriteLine(string.Format("Id:{0} Name:{1} Department:{2}, Pension:{2}",employee.Id,employee.Name, employee.Department));
            }
            Console.ReadKey();
        }
    }
}
