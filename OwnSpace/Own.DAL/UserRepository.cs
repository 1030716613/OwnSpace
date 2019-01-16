using Own.Common;
using Own.Interface.Repositories;
using Own.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Own.DAL
{
    /// <summary>
    /// 数据访问层
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        public List<UserInfo> GetUserList()
        {
            string selectSql = "select * from UserInfo ";

            //使用dapper链接数据库，在数据库中查找所有user
            return SqlHelper.Query<UserInfo>(selectSql);
        }

        /// <summary>
        /// 新增用户
        /// </summary>am>
        /// <returns></returns>
        public int AddUser(UserInfo user)
        {
            string insertSql = @"
            INSERT INTO UserInfo( UserName,
                                  UserEmail,
                                  UserSex,
                                  UserStatus,
                                  UserGrade,
                                  UserDesc 
                                 )
                          VALUES( @UserName,
                                  @UserEmail,
                                  @UserSex,
                                  @UserStatus,
                                  @UserGrade,
                                  @UserDesc 
                                 )";

            var ret = SqlHelper.Execute(insertSql,user);

            return ret;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        public int DeleteUser(int id)
        {
            string insertSql = @"delete from userinfo where id = @id ";

            var ret = SqlHelper.Execute(insertSql, new { id});
            return ret;
        }

        public int UpdateUser(UserInfo user)
        {
            string insertSql = @"
             UPDATE UserInfo SET UserName = @UserName , 
                                 UserEmail = @UserEmail ,
                                 UserSex = @UserSex ,
                                 UserStatus = @UserStatus ,
                                 UserGrade = @UserGrade ,
                                 UserDesc = @UserDesc 
                           WHERE Id = @Id ";

            var ret = SqlHelper.Execute(insertSql, user);
            return ret;
        }

        public int BatchDeleteUsers(List<int> ids)
        {
            string insertSql = @"delete from userinfo where id in @ids ";

            var ret = SqlHelper.Execute(insertSql, new { ids });
            return ret;
        }
    }
}
