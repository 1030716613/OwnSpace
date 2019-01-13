using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Own.MVC.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Email()
        {
            return View("Index");
        }
    }
}