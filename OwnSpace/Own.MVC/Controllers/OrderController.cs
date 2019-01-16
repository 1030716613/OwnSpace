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
        
        /// <summary>
        /// 获取用户列表
        /// </summary>
        public JsonResult GetUserList(int page, int limit, string userName = null)
        {
            var request = new PageRequestEntity<TestLayui>
            {
                CurrentPage = page,
                PageSize = limit
            };

            List<UserInfo> userList = _studentService.GetUserList();

            if (userName != null)
            {
                userList = userList.Where(t => t.UserName.Contains(userName)).ToList();
            }

            var result = request.WithPagedItems(userList);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        [HttpPost]
        public JsonResult AddUser(UserInfo user)
        {
            if (user.Id == 0)
            {
                var result = _studentService.AddUser(user);
                return Json(result);
            }
            else
            {
                var result = _studentService.UpdateUser(user);
                return Json(result);
            }
        }

        /// <summary>
        /// 删除用户根据id
        /// </summary>
        [HttpGet]
        public JsonResult DeleteUser(int id)
        {
            int result = _studentService.DeleteUser(id);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 批量删除用户
        /// </summary>
        [HttpPost]
        public JsonResult BatchDeleteUsers(List<int> ids)
        {
            int result = _studentService.BatchDeleteUsers(ids);

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}