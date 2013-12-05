using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericComparer
{
    class EmployeeExample : IComparable
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
        public string PrimaryId
        {
            get { return Id; }
            set { Id = value; }
        }
    }
}
