using Own.MVC.Filters;
using System.Web.Mvc;

namespace Own.MVC.Controllers
{
    public class HomeController : Controller
    {
        [RoleAuthorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}