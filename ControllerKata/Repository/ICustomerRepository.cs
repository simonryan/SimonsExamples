using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerKata.Domain;

namespace ControllerKata.Repository
{
    public interface ICustomerRepository
    {
        IList<Customer> GetAll();
    }
}
