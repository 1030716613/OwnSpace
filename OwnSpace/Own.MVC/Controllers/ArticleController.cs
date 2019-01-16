using Own.Interface.Services;
using Own.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Own.MVC.Controllers
{
    /// <summary>
    /// 文章列表控制器
    /// </summary>
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        // GET: Article
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 增加文章
        /// </summary>
        [HttpPost]
        public JsonResult AddArticle(Article article)
        {
            article.NewsAuthor = "守长";
            if (article.Id == 0)
            {
                var result = _articleService.AddArticle(article);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                //var result = _articleService.UpdateArticle(article);
                //return Json(result);
                return null;
            }
        }

        /// <summary>
        /// 获取文章列表
        /// </summary>
        [HttpGet]
        public JsonResult GetArticleList(int page, int limit, string articleName = null)
        {
            var request = new PageRequestEntity<string>
            {
                CurrentPage = page,
                PageSize = limit
            };

            List<Article> articleList = _articleService.GetArticleList();

            if (articleName != null)
            {
                articleList = articleList.Where(t => t.NewsName.Contains(articleName)).ToList();
            }

            var result = request.WithPagedItems(articleList);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 删除文章根据id
        /// </summary>
        [HttpGet]
        public JsonResult DeleteArticle(int id)
        {
            int result = _articleService.DeleteArticle(id);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 批量删除文章
        /// </summary>
        [HttpPost]
        public JsonResult BatchDeleteArticles(List<int> ids)
        {
            int result = _articleService.BatchDeleteArticles(ids);

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}