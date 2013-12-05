using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace LinqExamples
{
    public static class EmployeesRepository
    {
        public static IList<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee {Id=1,Surname="Smith", Firstname="Mark", Department="HR"},
                new Employee {Id=2, Surname="Jones", Firstname="Clark", Department="Accounts"},
                new Employee {Id=3, Surname="Ryan", Firstname="Simon", Department="HR"},
                new Employee {Id=4, Surname="Cox", Firstname="Graham", Department="IT"},
                new Employee {Id=5, Surname="Grant", Firstname="Paul",Department="HR"},
                new Employee {Id=6, Surname="West", Firstname="Shaun", Department="IT"},
                new Employee {Id=7, Surname="Brook", Firstname="Bryan", Department="IT"},
                new Employee {Id=8, Surname="Kelly", Firstname="Grace", Department="HR"},
                new Employee {Id=9, Surname="Jones", Firstname="Jane", Department="Accounts"},
                new Employee {Id=10, Surname="Abdul", Firstname="Paula", Department="Accounts"}
            };
        }

        public static ICollection<Pension> GetPensions()
        {
            return new Collection<Pension>
                       {
                           new Pension {AccountNo = "QWE123", EmployeeId = 2},
                           new Pension {AccountNo = "HED333", EmployeeId = 3},
                           new Pension {AccountNo = "XER555", EmployeeId = 7},
                           new Pension {AccountNo = "GGH733", EmployeeId = 9},
                       };
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Department { get; set; }
    }

    public class Pension
    {
        public string AccountNo { get; set; }
        public int EmployeeId { get; set; }
    }

    public class Exam
    {
        public int ExamId { get; set; }
        public string Name { get; set; }
    }

    public class Result
    {
        public int ExamId { get; set; }

    }

    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
    }
}
