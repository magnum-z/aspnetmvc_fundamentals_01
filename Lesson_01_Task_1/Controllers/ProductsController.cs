using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lesson_01_Task_1.Models;

namespace Lesson_01_Task_1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "prod1",
                Price = 1.10m,
                Description = "Product 1"
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "prod2",
                Price = 2.29m,
                Description = "Product 2"
            });

            products.Add(new Product()
            {
                Id = 3,
                Name = "prod3",
                Price = 7.53m,
                Description = "Product 3"
            });

            return View(products);
        }
    }
}