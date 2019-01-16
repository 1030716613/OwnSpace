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
    public class UserController : Controller
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        
        /// <summary>
        /// 获取用户列表
        /// </summary>
        public JsonResult GetUserList(int page, int limit, string userName = null)
        {
            var request = new PageRequestEntity<string>
            {
                CurrentPage = page,
                PageSize = limit
            };

            List<UserInfo> userList = _userService.GetUserList();

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
                var result = _userService.AddUser(user);
                return Json(result);
            }
            else
            {
                var result = _userService.UpdateUser(user);
                return Json(result);
            }
        }

        /// <summary>
        /// 删除用户根据id
        /// </summary>
        [HttpGet]
        public JsonResult DeleteUser(int id)
        {
            int result = _userService.DeleteUser(id);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 批量删除用户
        /// </summary>
        [HttpPost]
        public JsonResult BatchDeleteUsers(List<int> ids)
        {
            int result = _userService.BatchDeleteUsers(ids);

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}