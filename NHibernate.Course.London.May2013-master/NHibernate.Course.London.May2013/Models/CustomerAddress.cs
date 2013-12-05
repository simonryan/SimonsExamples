using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernate.Course.London.May2013.Models
{
    public class CustomerAddress
    {
        public int CustomerId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}