using System;

namespace _0002_Source
{
    /// <summary>
    /// 抽象出来对象 人
    /// </summary>
    public class Person
    {
        /// <summary>
        /// 这个人的年龄 int 
        /// </summary>
        public int age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 变量代码演示
            */
            int num1 = 2;
            Console.WriteLine(num1);//此时输出2
            num1 = 12;
            Console.WriteLine(num1);//此时输出12
            string author = "Yahue";
            Console.WriteLine(author);//此时输出Yahue
            author = "Yahui.Wang";
            Console.WriteLine(author);//此时输出Yahui.Wang
            /**
             * 常量代码演示
             * */
            const int num2 = 2;
            Console.WriteLine(num2);//此时输出2
            //num2 = 12;//无法编译通过 错误：赋值号左边必须是变量、属性或索引器
            Console.WriteLine(num2);//此时输出2

            /*
             * 值类型
             * */
            int i = 10;//开辟一个地方 存储i为10
            int j = i;//在开辟一个地方存储j为10
            /*
             * 引用类型
             * **/
            Person yahui = new Person();
            yahui.age = 20;
            //不是真正的创建对象wang 
            //而是 yahui 和wang 使用同一个引用
            // yahui的值变了 相应的 wang的值也变了
            Person wang = yahui;
            yahui.age = 30;
            Console.WriteLine(wang.age);//输出的是30
        }
    }
}
