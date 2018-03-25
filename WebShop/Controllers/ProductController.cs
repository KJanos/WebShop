using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;
using WebShop.Services;

namespace WebShop.Controllers
{
    public class ProductController : Controller
    {

        private ProductServices productServices;

        public ProductController()
        {
            productServices = new ProductServices();
        }

        // GET: Product/Index
        public ActionResult Index()
        {
            var items = productServices.GetAll();
            return View(items);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                productServices.AddProduct(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}