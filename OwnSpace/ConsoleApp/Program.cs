using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"请输入数值a：");

            string stra = Console.ReadLine();

            int a = Convert.ToInt32(stra);

            Console.WriteLine($"请输入数值b:");

            string strb = Console.ReadLine();

            int b = Convert.ToInt32(strb);

            int result = AddMethod(a, b);

            Console.WriteLine($"运算结果：{a}+{b}={result}");


            Console.ReadKey();
        }

        public static int AddMethod(int a, int b)
        {
            return a + b;
        }
    }
}
