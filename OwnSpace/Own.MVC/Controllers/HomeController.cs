using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Own.Models;
using Student = Own.MVC.Models.Student;

namespace Own.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }


        public JsonResult GetStudent()
        {
            Student student = new Student();

            student.Age = 20;
            student.Name = "张三";

            return Json(student,JsonRequestBehavior.AllowGet);
        }

      
    }
}