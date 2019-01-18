//using System;// using是引用命名空间  引用system 里面的方法
using Own.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshapetest
{
    class Program
    {
        static void Main()
        {
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


            Utils.TencentSmsMethod();

            Console.Read();
        }
    }
}
