using System;
using System.Runtime.InteropServices.ComTypes;//c#语言的互操作服务

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();//定义一个随机数
            int num = r.Next(0, 99);//将随机数的值赋给变量num
            Console.WriteLine("猜数字游戏开始");//默认显示在页面上

            for (; ; )
            {
                Console.WriteLine("输入你猜测的数字（0-100）");
                int i = int.Parse(Console.ReadLine());
                if (i == num)//判断输入的值是上面生成的随机数
                {
                    Console.WriteLine("恭喜你，猜对了！！！");
                    break;
                }
                else if (i > num)
                {
                    Console.WriteLine("太大了，再小一点");
                }
                else if (i < num)
                {
                    Console.WriteLine("太小了，再大一点");
                }
            }
            Console.ReadLine();
        }
    }
}