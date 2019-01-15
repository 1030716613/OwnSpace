using Own.BLL;
using Own.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Own.Models;

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

        /// <summary>
        /// 获取用户列表
        /// </summary>
        public JsonResult GetUserList(int page, int limit)
        {
            var request = new PageRequestEntity<TestLayui>
            {
                CurrentPage = page,
                PageSize = limit
            };

            var testLayuis = new List<Users>();

            for (var i = 1; i < 100; i++)
            {
                var data = new Users()
                {
                    Id = i,
                    UserName = $"张三{i}",
                    UserEmail = "1037134100@qq.com",
                    UserSex = "男",
                    UserStatus = 1,
                    UserGrade = 0,
                    UserEndTime = DateTime.Now,
                    UserDesc = "程序员"
                };
                testLayuis.Add(data);
            }
            var result = request.WithPagedItems(testLayuis);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        [HttpPost]
        public JsonResult AddUser(Users user)
        {
            var x = "23";
            return Json(x);
        }
    }
}