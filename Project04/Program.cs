using System;

namespace Project04
{
    class Circle
    {
        private const double PI = 3.14;
        private int radius;
        public Circle() { this.radius = 1; }
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public void setRadius(int radius)
        {
            this.radius = radius;
        }
        public int getRadius()
        {
            return radius;
        }
        public void showArea()
        {
            Console.WriteLine("The circle's area is: {0}",PI * radius * radius);
        }
        public void showCircumference()
        {
            Console.WriteLine("The circle's circumference is: {0}", 2 * PI * radius);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Circle circle2 = new Circle(2);
            circle1.showArea();
            circle1.showCircumference();

            circle2.showArea();
            circle2.showCircumference();
        }
    }
}
