using System;
/*
 * 定义一个长方形类,定义求周长和面积的方法，在程序main函数中进行测试。
 */
namespace Project01
{
    public class Rectangle
    {
        public int length { get; set; }
        public int width { get; set; }
        public Rectangle() { length = 10; width = 10; }
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public void Area()
        {
            Console.WriteLine("长方形面积：{0}", length * width);
        }
        public void Circumference()
        {
            Console.WriteLine("长方形周长：{0}", (length + width) * 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(2, 6);
            rec.Area();
            rec.Circumference();
        }
    }
}
