using System;
/**
 * 定义一个类MyMath,提供基本的加减乘除功能，然后进行测试。
 */
namespace Project03
{
    class MyMath
    {
        private float a,b;
        public MyMath() { }
        public void setA(float a)
        {
            this.a = a;
        }
        public float getA()
        {
            return a;
        }
        public void setB(float b)
        {
            this.b = b;
        }
        public float getB()
        {
            return b;
        }
        public float AaddB()//求和
        {
            return a + b;
        }
        public float AsubtractB()//求差
        {
            return a - b;
        }
        public float AmultiplyB()//求积
        {
            return a * b;
        }
        public float AdivideB()//求商
        {
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyMath myMath = new MyMath();
            Console.WriteLine("请输入要运算的两个数A和B:");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            myMath.setA(a);
            myMath.setB(b);
            Console.WriteLine("求和：{0} + {1} = {2}", a, b,myMath.AaddB());
            Console.WriteLine("求差：{0} - {1} = {2}", a, b, myMath.AsubtractB());
            Console.WriteLine("求积：{0} * {1} = {2}", a, b, myMath.AmultiplyB());
            Console.WriteLine("求商：{0} / {1} = {2}", a, b, myMath.AdivideB());
        }
    }
}
