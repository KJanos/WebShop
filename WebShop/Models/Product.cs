using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Product
    {
        
        [Required]
        public string Name { get; set; }

        public string Size { get; set; }

        [Required]
        public double Price { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }
    }
}