using Own.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.Interface.Services
{
    public interface IArticleService
    {
        int AddArticle(Article article);
        List<Article> GetArticleList();
        int DeleteArticle(int id);
        int BatchDeleteArticles(List<int> ids);
    }
}
