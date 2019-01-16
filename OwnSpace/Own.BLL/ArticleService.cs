using Own.Interface.Repositories;
using Own.Interface.Services;
using Own.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.BLL
{
    public class ArticleService : IArticleService
    {
        //1.声明接口变量
        private readonly IArticleRepository _articleRepository;

        //2.这里是构造函数注入repository接口
        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public int AddArticle(Article article)
        {
            //2.使用注入过的_articleRepository 调用里面的方法
            int ret = _articleRepository.AddArticle(article);

            return ret;
        }

        public int DeleteArticle(int id)
        {
            throw new NotImplementedException();
        }

        public List<Article> GetArticleList()
        {
            List<Article> articles = _articleRepository.GetArticleList();

            return articles;
        }
    }
}
