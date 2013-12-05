using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SupermarketPricing
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float? DiscountedPrice { get; set; }
    }
}
