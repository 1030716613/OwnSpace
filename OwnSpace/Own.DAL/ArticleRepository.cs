using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.DAL
{
        public int AddArticle(ArticleInfo user)
        {
            string insertSql = @"
                                  insert into ArticleInfo( ArticleName,
                                                           ArticleAuthor,
                                                           ArticleState,
                                                           ArticleJurisdiction,
                                                           Articletop
                                                         )
                                                values( @ArticleName,
                                                        @ArticleAuthor,
                                                        @ArticleState,
                                                        @ArticleJurisdiction,
                                                        @Articletop
                                                      )
                                ";

            var ret = SqlHelper.Execute(insertSql, Article);

            return ret;
        }
}
