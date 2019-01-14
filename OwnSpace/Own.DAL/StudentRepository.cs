﻿using Own.Interface.Repositories;
using Own.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.DAL
{
    /// <summary>
    /// 数据访问层
    /// </summary>
    public class StudentRepository : IStudentRepository
    {

        public string GetStudentName(int id)
        {
            if (id == 1)
            {
                return "张三";

            }
            else if (id == 2)
            {
                return "JAMES";
            }
            else
            {
                return "学生不存在";
            }
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
    }
}
