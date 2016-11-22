using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        [Route("Customer/Details/{id}")]
        public ActionResult Details(int? id)
        {
            if(id == 1)
            {
                ViewBag.Name = "John Smith";
            }
            else
            {
                ViewBag.Name = "Mary Williams";
            }
            return View();
        }
    }
}