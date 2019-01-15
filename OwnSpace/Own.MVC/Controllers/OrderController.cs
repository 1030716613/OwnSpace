using Own.BLL;
using Own.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Own.MVC.Controllers
{
    public class OrderController : Controller
    {

        private readonly IStudentService _studentService;

        public OrderController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: Order
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult TencentMail()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetName(int id)
        {
            var name = _studentService.GetStudentName(id);

            return Json(name, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAge(int id)
        {
            var age = _studentService.GetStudentAge(id);

            return Json(age, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 获取生日
        /// </summary>
        public JsonResult GetBirthDay(string name)
        {
            DateTime dt = _studentService.GetBirthDay(name);

            return Json(dt, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据学生Id获取学生信息
        /// </summary>
        [HttpGet]
        public JsonResult GetStudentInfo(int id)
        {
            var student = _studentService.GetStudentInfo(id);

            return Json(student, JsonRequestBehavior.AllowGet);
        }
    }
}