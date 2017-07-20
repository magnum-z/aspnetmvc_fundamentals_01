using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_01_Task_Add.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}