using Own.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.Interface.Repositories
{
    public interface IArticleRepository
    {
        int AddArticle(Article article);
        List<Article> GetArticleList();
    }
}
