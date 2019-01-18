//using System;// using是引用命名空间  引用system 里面的方法
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

            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();

            int a1 = int.Parse(str1);
            int a2 = int.Parse(str2);
4

            Console.WriteLine(a1+a2);


            Console.Read();
        }
    }
}
