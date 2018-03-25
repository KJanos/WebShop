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
                new Product{Name = "Jeans", Price = 680},
                new Product{Name = "Shirt", Price = 300},
                new Product{Name = "Top", Price = 450}
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