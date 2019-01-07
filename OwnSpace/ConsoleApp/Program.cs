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
            //双斜杠是注释  代码不执行
            //先写个hello world
            //Console.WriteLine("Hello C#");

            //我先给你写个简单的东西  你对照着课程练习下

            Console.Title = "匹配模式";

            //string是字符串的意思
            string heros = "寒冰，德玛，光辉";

            Console.WriteLine($"请选择英雄：{heros}");

            string hero = Console.ReadLine().ToString();

            if (hero == "寒冰")
            {
                Console.WriteLine("你选择了ADC");
            }
            else if (hero == "德玛")
            {
                Console.WriteLine("你选择了战士");
            }
            else if (hero == "光辉")
            {
                Console.WriteLine("你选择了AP");
            }
            else
            {
                Console.WriteLine("英雄不存在");
            }

            Console.WriteLine("按任意键退出");
            Console.ReadKey();
        }
    }
}
