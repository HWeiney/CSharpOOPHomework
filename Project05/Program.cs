using System;
using Project01;
namespace Project05
{
    class PlainRect: Rectangle
    {
        public double startX { set; get; }
        public double startY { set; get; }
        public PlainRect() : base(0, 0)
        {
            startX = 0;
            startY = 0;
        }
        public PlainRect(int length,int width, double startX, double startY) 
        {
            this.startX = startX;
            this.startY = startY;
            base.length = length;
            base.width = width;
        }
        public bool isInside(double x, double y)
        {
            if (x > startX && x < startX + length) 
            {
                if (y < startY && y > startY - width) 
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PlainRect plainRect = new PlainRect(20, 10, 10, 10);
            plainRect.Area();
            plainRect.Circumference();
            Console.WriteLine("该点在矩形内为{0}",plainRect.isInside(25.5, 13));
        }
    }
}
