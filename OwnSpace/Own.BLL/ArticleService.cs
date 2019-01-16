using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.BLL
{
    public Article AddArticle(ArticleInfo Article)
    {
        Article Article = _ArticleRepository.GetArticleInfo(Article);

        return Article;
    }
}
