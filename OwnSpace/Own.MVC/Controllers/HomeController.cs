using Own.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        /// <summary>
        /// 获取学生列表
        /// </summary>
        [HttpGet]
        public JsonResult GetStudent()
        {
            Student student = new Student();
            student.Age = 30;
            student.Name = "张三";

            return Json(student, JsonRequestBehavior.AllowGet);
        }
    }
}