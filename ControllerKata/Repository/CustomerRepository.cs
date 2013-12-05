using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ControllerKata.Domain;

namespace ControllerKata.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public IList<Customer> GetAll()
        {
            var customers = new List<Customer>();
            
            for (var i = 0; i < 10; i++)
            {
                customers.Add(
                    new Customer
                        {
                            Id = i, 
                            Name = "Customer" + i,
                            Email = "email" + i + "@domain" + i + ".com",
                            PhoneNumber = PhoneNumber()
                        });
            }
            return customers;
        }

        private string PhoneNumber()
        {
            return string.Empty;
        }
    }
}