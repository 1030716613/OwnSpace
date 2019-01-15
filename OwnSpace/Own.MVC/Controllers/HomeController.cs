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

        /// <summary>
        /// Layui获取测试数据
        /// </summary>
        public JsonResult GetTestData(int page, int limit)
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
    }
}