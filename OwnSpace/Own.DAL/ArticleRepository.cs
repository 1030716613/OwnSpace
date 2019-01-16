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
            INSERT INTO Article(  NewsName,
                                  NewsAuthor,
                                  Abstract,
                                  NewsStatus,
                                  NewsImg,
                                  NewsLook ,
            					  NewsTop,
            					  NewsTime,
            					  Content,
            					  NewsUrl
            					  )
                        VALUES  ( @NewsName,
                                  @NewsAuthor,
                                  @Abstract,
                                  @NewsStatus,
                                  @NewsImg,
                                  @NewsLook ,
            					  @NewsTop,
            					  @NewsTime,
            					  @Content,
            					  @NewsUrl
            					   ) ";

            var ret = SqlHelper.Execute(insertSql, article);

            return ret;
        }

        public List<Article> GetArticleList()
        {
            string selectSql = "SELECT * FROM Article ";

            //使用dapper链接数据库，在数据库中查找所有user
            return SqlHelper.Query<Article>(selectSql);
        }

        /// <summary>
        /// 删除文章
        /// </summary>
        public int DeleteArticle(int id)
        {
            string insertSql = @"DELETE FROM Article WHERE Id = @id ";

            var ret = SqlHelper.Execute(insertSql, new { id });
            return ret;
        }

        /// <summary>
        /// 批量删除文章
        /// </summary>
        public int BatchDeleteArticles(List<int> ids)
        {
            string insertSql = @"DELETE FROM Article WHERE Id in @ids ";

            var ret = SqlHelper.Execute(insertSql, new { ids });
            return ret;
        }

        public int UpdateArticle(Article article)
        {
            string updateSql = @"
            UPDATE  Article  SET  NewsName = @NewsName,
                                  NewsAuthor = @NewsAuthor,
                                  Abstract = @Abstract,
                                  NewsStatus = @NewsStatus,
                                  NewsImg = @NewsImg,
                                  NewsLook = @NewsLook ,
            					  NewsTop = @NewsTop,
            					  NewsTime = @NewsTime,
            					  Content = @Content,
            					  NewsUrl = @NewsUrl
                           WHERE  Id = @Id ";

            var ret = SqlHelper.Execute(updateSql, article);

            return ret;
        }
    }
}
