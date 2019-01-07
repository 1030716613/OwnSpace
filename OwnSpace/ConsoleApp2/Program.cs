using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {//在这边上右键一下 可以进入调试模式，按f10 就是代码一行一行的走 

            //现在这样是 写死的  也可以写个方法 传进去值计算

            Console.WriteLine($"请输入第一个数：");

            //这是一个string类型的
            string stra = Console.ReadLine();

            //把string 转为int
            int a = Convert.ToInt32(stra);

            Console.WriteLine($"请输入第二个数：");

            //这是一个string类型的
            string strb = Console.ReadLine();

            //把string 转为int
            int b = Convert.ToInt32(strb);

            //调用addmethod方法  按f11进入到这个方法
            int result = AddMethod(a,b);

            Console.WriteLine($"运算：{a}+{b}={result}");


            Console.ReadKey();
        }

        //这里写一个加法方法 当然你可以实现很多种算法
        //这个方法需要两个int 型的入参，返回值也是个int
        public static int AddMethod(int a,int b)
        {
            return a + b;
        }

    }
}
