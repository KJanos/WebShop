using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Product
    {

        public string Name { get; set; }

        public string Size { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}