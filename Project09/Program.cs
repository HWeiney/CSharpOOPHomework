using System;
/*按要求编写一个控制台应用程序:
（1）定义接口A，里面包含方法double area()。
（2）定义接口B，里面包含抽象方法void setColor(Stringc)。
（3）定义接口C，该接口继承了接口A和B，自有方法void volume()。
（4）定义圆柱体类Cylinder实现接口C，该类中包含三个成员变量：底圆半径radius、圆柱体的高height、颜色color。
（5）创建主类来测试类Cylinder。*/
namespace Project09
{
    interface InterfaceA
    {
        public double area();
    }
    interface InterfaceB
    {
        public void setColor(String c);
    }
    interface InterfaceC : InterfaceA,InterfaceB
    {
        public void volume();
    }
    class Cylinder : InterfaceC
    {
        public double radius { set; get; }
        public double height { set; get; }
        public String color { set; get; }
        public double area()
        {
            return 3.14 * radius * radius;
        }

        public void setColor(String c)
        {
            this.color = c;
        }

        public void volume()
        {
            Console.WriteLine("圆柱体的体积: {0}",area() * height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder();
            cylinder.radius = 2;
            cylinder.height = 4;
            Console.WriteLine("圆柱体的底面积: {0}", cylinder.area());
            Console.Write("输入圆柱体的颜色: ");
            String c = Console.ReadLine();
            cylinder.setColor(c);
            Console.WriteLine("圆柱体的颜色: {0}", cylinder.color);
            cylinder.volume();
        }
    }
}
