using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Own.MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult VerifyLogin(Login login)
        {
            if (login.Name =="1" && login.PassWord =="1")
            {
                 var res = new { Status = "success", MsgData = "/Home" };
                return Json(res);
            }

            return Json(new { Status = "false", MsgData = "用户名或密码不正确。" });
        }
    }

    public class Login
    {
        public string Name { get; set; }

        public string PassWord { get; set; }
    }
}