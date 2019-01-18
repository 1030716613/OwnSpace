using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace Own.MVC.Filters
{
    public class RoleAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //base.OnAuthorization(filterContext);
            var isAuth = false;
            if (!filterContext.RequestContext.HttpContext.Request.IsAuthenticated)
            {
                isAuth = false;
            }

            if (filterContext.RequestContext.HttpContext.User.Identity != null)
            {
                var actionDescriptor = filterContext.ActionDescriptor;
                var controllerDescriptor = actionDescriptor.ControllerDescriptor;
                string controller = controllerDescriptor.ControllerName; //得到controller
                string action = actionDescriptor.ActionName; //得到Action
                string result = controller + "/" + action;
                int[] num = {10001, 10002, 10003}; //该用户权限列表的页面编号数据，假数据，实际项目中从后台得出
                string[] xnum = new string[num.Length]; //用来存放该用户拥有权限对应的controller/action数据集合
                for (int i = 0; i < num.Length; i++)
                {
                    //将num集合中对应的controller/action存在string[]集合xnum中}
                    xnum[i] = ConfigurationManager.AppSettings[num[i].ToString()] ??""; 
                }

                //判断用户拥有的权限对应的controller/action数据集合中是否包含此页面的controller/action
                if (xnum.Contains(result))
                {
                    isAuth = true;
                }

                //用户拥有的权限对应的controller/action数据集合中不包含此页面的controller/action，将页面跳转
                if (!isAuth)
                {
                    //filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "account", action = "login", returnUrl = filterContext.HttpContext.Request.Url, returnMessage = "您无权查看." }));

                    filterContext.Result = new RedirectResult("/page/404.html");
                }

            }
        }
    }
}