using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0004_Source
{
    class Program
    {
        /// <summary>
        /// 计算相加的和
        /// </summary>
        /// <param name="num1">数字1</param>
        /// <param name="num2">数字2</param>
        /// <returns></returns>
        static int sum(int num1, int num2)
        {
            Console.WriteLine(string.Format("{0}+{1}", num1, num2));
            return num1 + num2;
        }
        /// <summary>
        /// 计算阶乘
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static long jiecheng(int num)
        {
            if (num == 0)
                return 1;
            else
                return num * jiecheng(num - 1);
        }
        /// <summary>
        /// 声明委托
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        delegate int Calculate(int num1, int num2);
        static void Main(string[] args)
        {
            Console.WriteLine(sum(1, 1));
            Console.WriteLine(jiecheng(10));
            Calculate cc = new Calculate(sum);
            //直接调用
            Console.WriteLine(cc(1, 1));
            //同上 直接调用
            Console.WriteLine(cc.Invoke(1, 1));
            //异步调用，计算完成会自动调用回调方法
            var result = cc.BeginInvoke(1, 1, new AsyncCallback(FunCallback), "一些回调方法需要的数据");

            Console.WriteLine("请按回车键结束程序！");
            Console.ReadLine();
        }
        /// <summary>
        /// 回调方法
        /// </summary>
        /// <param name="ar"></param>
        static void FunCallback(IAsyncResult ar)
        {
            Console.WriteLine("异步：" + ar.AsyncState);
        }
    }
}
