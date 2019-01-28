//using System;// using是引用命名空间  引用system 里面的方法
using Own.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshapetest
{
    class Program
    {
        static void Main(string[] arqs)
        {
            #region 2019-01-19

            #region 2019-01-18
            //Console.WriteLine("输入第一个数：");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("输入第二个数");
            //var str2 = Console.ReadLine();

            //int a1=0;
            //int c;
            //bool istrue = int.TryParse(str1, out c);

            //if (istrue)
            //{
            //    a1 = c;
            //}

            ////int a2;
            ////if (istrue)
            ////{
            ////    a2 = int.Parse(str1);
            ////}

            ////int a1 = int.Parse(str1);
            //int a2 = int.Parse(str2);
            //Console.WriteLine(a1 + a2);
            #endregion

            #region if else 的练习

            //string name;

            //string a = "女";

            //string b = "男";

            //Console.WriteLine("输入姓名：");

            //name = Console.ReadLine();

            //if (name=="zhang")
            //{
            //    Console.WriteLine($"性别为{a}");

            //}
            //else if (name == "wang")
            //{
            //    Console.WriteLine($"性别为{b}");
            //}
            //else
            //{
            //    Console.WriteLine("查无此人");
            //}
            #endregion

            #region switch 的练习 break 跳出所有循环，continue 结束当前的这一次循环 继续循环下一个循环条件

            //string name = null;

            //var weekday = DateTime.Now.DayOfWeek.ToString();

            //switch (weekday)
            //{
            //    case "Saturday":
            //        name = "星期六";
            //        break;

            //    default:
            //        break;
            //}

            //Console.WriteLine(name);


            //for (int i = 0; i < 10; i++)
            //{
            //    if (i==2)
            //    {
            //        break;
            //    }
            //    Console.WriteLine($"循环{i}");
            //}

            #endregion

            #region a>b?a:b


            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //var istrue = a>b?a:b;
            //Console.WriteLine($"{istrue}");

            #endregion

            #region 斐波那契数列

            //int N = 10;
            //int[] a = new int[N];
            //a[0] = 1;
            //a[1] = 1;
            //for (int i = 2; i < N; i++)
            //{
            //    a[i] = a[i - 1] + a[i - 2];
            //}
            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            //递归
            //int number = Foo(20);


            #endregion

            #region 生成随机数
            //const int N = 50;
            //int[] a = new int[N];
            //Random b = new Random();
            //for (int i = 0; i < N; i++)
            //{
            //    a[i] = b.Next() % 10;
            //}
            //foreach (int x in a)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion

            #region 冒泡排序

            //int[] array = new int[] { 3, 5, 4, 2, 1, 9 };
            //int temp;
            //for (int i = 0; i < array.Length-1; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] > array[j])
            //        {
            //            temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //        }
            //    }
            //}
            //foreach (int item in array)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region List
            ////大括号 对象初始化器
            //var nums = new List<int>() { 2,5,9,4,6,5,2,78,45};
            //nums.Add(12);
            ////linq排序
            //var numss  =  nums.OrderByDescending(t=>t);
            //foreach (int item in numss)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 递归查询文件数目
            //    Console.WriteLine("正在统计中");

            //    var count = FileOrDirCount("D:/2.DevelopTool");

            //    Console.WriteLine(count);

            //    Console.Read();
            //}

            //static long FileOrDirCount(string path)
            //{
            //    long count = 0;

            //    try
            //    {
            //        var files = Directory.GetFiles(path);
            //        count += files.Length;
            //        //取文件夹
            //        var dirs = Directory.GetDirectories(path);
            //        foreach (var dir in dirs)

            //        {

            //            count += FileOrDirCount(dir);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        //throw;
            //    }
            //    return count;
            #endregion

            #endregion

            //double x = 100.5;
            //double y = 0.02;
            //var result = Interest(x, y);
            //Console.WriteLine(result);


      
            Console.Read();
        }







        


        /// <summary>
        /// 递归求斐波那契数列
        /// </summary>
        //public static int Foo(int num)
        //{
        //    if (num <= 0)
        //    {
        //        return 0;
        //    }

        //    else if (num == 1 || num == 2)
        //    {
        //        return 1;
        //    }

        //    return Foo(num - 1) + Foo(num - 2);
        //}
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age{ get; set; }


    }

}
