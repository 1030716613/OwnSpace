using Own.Common;
using Own.Interface.Repositories;
using Own.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.DAL
{
    public class ArticleRepository : IArticleRepository
    {
        public int AddArticle(Article article)
        {
            string insertSql = @"
            insert into Article(  NewsName,
                                  NewsAuthor,
                                  Abstract,
                                  NewsStatus,
                                  NewsImg,
                                  NewsLook ,
            					  NewTop,
            					  NewsTime,
            					  Content,
            					  NewsUrl
            					  )
                        values  ( @NewsName,
                                  @NewsAuthor,
                                  @Abstract,
                                  @NewsStatus,
                                  @NewsImg,
                                  @NewsLook ,
            					  @NewTop,
            					  @NewsTime,
            					  @Content,
            					  @NewsUrl
            					   ) ";

            var ret = SqlHelper.Execute(insertSql, article);

            return ret;
        }

        public List<Article> GetArticleList()
        {
            string selectSql = "select * from Article ";

            //使用dapper链接数据库，在数据库中查找所有user
            return SqlHelper.Query<Article>(selectSql);
        }
    }


}
