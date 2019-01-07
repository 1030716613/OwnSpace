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
        {
            //就可以在这里写代码了  你先用一个控制台就行了


            Console.Title = "排位模式";
            string heros = "法师 刺客 坦克 辅助";
            Console.WriteLine($"英雄种类选择：{heros}");
            string hero = Console.ReadLine().ToString();
            if (hero == "法师")
            {
                Console.WriteLine("你选择了远程技能型英雄");
            }
            else if (hero == "刺客")
            {
                Console.WriteLine("你选择了突进型英雄");
            }
            else if (hero == "坦克")
            {
                Console.WriteLine("你选择了近战英雄");
            }
            else if (hero=="辅助")
            {
                Console.WriteLine("你选择了保护型英雄");
            }
            else
            {
                Console.WriteLine("英雄类型不存在");
            }
            Console.WriteLine("按任意键退出");
            Console.ReadKey();
        }
    }
}
