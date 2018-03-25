using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop.Models;

namespace WebShop.Services
{
    public class ProductServices
    {
        private static List<Product> products;

        public ProductServices()
        {
            if (products == null)
            products = new List<Product>
            {
                new Product{Name = "Asus VivoBook 1578", Price = 11680, Description = "CPU: Intel Core i3-7200, RAM: 6gb, Video: GT940MX"},
                new Product{Name = "HP Pavilion G6-2076sr", Price = 7800, Description = "CPU: Intel Core i5-3210M, RAM: 6gb, Video: 7670M"},
                new Product{Name = "ACER", Price = 4500, Description= "CPU: Intel Core N7100, RAM: 4gb, Video: Intel HD"}
            };
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public void AddProduct(Product model)
        {
            products.Add(model);
        }

        public void DeleteByName(string name)
        {
            products.Remove(products.FirstOrDefault(p => p.Name.Equals(name)));
        }
    }
}