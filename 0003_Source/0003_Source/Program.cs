using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003_Source
{
    class Program
    {
        static void Main(string[] args)
        {

            ////if... else
            ////int i = 1;
            //int i = -1;
            //if (i > 0)
            //{
            //    Console.WriteLine("i大于0");
            //}
            //else
            //{
            //    Console.WriteLine("i不大于0");
            //}
            ////switch ... case ...
            //switch (i)
            //{
            //    case 0:
            //        Console.WriteLine("当前i为0");
            //        break;
            //    case 1:
            //        Console.WriteLine("当前i为1");
            //        break;
            //    case -1:
            //        Console.WriteLine("当前i为-1");
            //        break;
            //    default:
            //        break;
            //}
            //for
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i.ToString());
            }
            string[] strInfo = new string[] { "你好", "这里是", "http://yahui.wang" };
            foreach (string item in strInfo)
            {
                Console.WriteLine(item);
            }
            int value = 0;
            while (value < 2)
            {
                Console.WriteLine("我执行了一次");
                value++;
            }
            do
            {
                Console.WriteLine("我执行了一次");
                value++;
            } while (false);

            goto lable;
            Console.WriteLine("世界");
        lable:
            Console.WriteLine("你好");

            Console.WriteLine("请按回车键结束本程序");
            Console.ReadLine();
        }
    }
}
