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
    public class StudentRepository : IStudentRepository
    {
        public string GetStudentName(int id)
        {
            string selectSql = "select Name from student where id = @id ";

            //使用dapper链接数据库，在数据库中根据学生id查询学生name
            return SqlHelper.Query<string>(selectSql, new { id }).FirstOrDefault();
        }

        public int GetStudentAge(int id)
        {
            if (id == 1)
            {
                return 21;

            }
            else if (id == 2)
            {
                return 23;
            }
            else
            {
                return 18;
            }
        }

        public DateTime GetBirthDay(string name)
        {
            if (name == "zhang")
            {
                return new DateTime(2001, 01, 09);
            }
            else
            {
                return DateTime.Now;
            }
        }

        public Student GetStudentInfo(int id)
        {
            //实例化一个学生对象
            Student stu = new Student();

            if (id == 1)
            {
                //给学生对象里面的属性赋值
                stu.Name = "张三";
                stu.Age = 25;
                stu.BirthDay = new DateTime(1993, 01, 01);
            }
            else
            {
                //给学生对象里面的属性赋值
                stu.Name = "JAMES";
                stu.Age = 20;
                stu.BirthDay = new DateTime(1998, 01, 01);
            }

            return stu;
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
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
                                  insert into UserInfo( UserName,
                                                        UserEmail,
                                                        UserSex,
                                                        UserStatus,
                                                        UserGrade,
                                                        UserDesc )
                                                values( @UserName,
                                                        @UserEmail,
                                                        @UserSex,
                                                        @UserStatus,
                                                        @UserGrade,
                                                        @UserDesc )
                                ";

            var ret = SqlHelper.Execute(insertSql,user);

            return ret;
        }

        //删除用户
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
    }
}
