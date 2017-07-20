using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_01_Task_Add.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}