using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Employee
    {
        public Employee(decimal salary, string name)
        {
            Name = name;
            Salary = salary;
        }
        
        public string Name { get; set; }
        public decimal Salary { get; set; }
        
        public virtual void PayEmployee()
        {
            TransferWages();
        }

        public abstract decimal CalculateTax();

        private void TransferWages()
        {
            if (Salary > 0)
            {
                var monthlyWages = Salary/12;
                Console.WriteLine("Employee {0} has been paid {1}", Name, monthlyWages);
            }
        }

    }

    public class Manager :  Employee
    {
        public Manager(decimal salary, string name) : base(salary, name)
        {
        }

        public override decimal CalculateTax()
        {
            throw new NotImplementedException();
        }
    }
}
