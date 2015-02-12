//这里使用using应用命名空间
//作用相当于c语言的include
using System;
//这里声明我们自己定义的命名空间
namespace HelloWorld
{
    //我们声明一个类 名字定义为Program
    class Program
    {
        /*
         * 这里是Main方法可以看成是程序的开始运行的地方，也是程序的入口点
        通过调用main来运行程序
         * */
        static void Main(string[] args)
        {
            //调用Console的WriteLine方法 参数为Hello World
            Console.WriteLine("Hello World");
        }
    }
}
