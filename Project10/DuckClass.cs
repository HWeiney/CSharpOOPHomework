using System;
using System.Collections.Generic;
using System.Text;

namespace Project10
{
    abstract class Duck
    {
        public String name { set; get; }
        public IQuackBehavior quackBehavior { set; get; }
        public ISwimBehavior swimBehavior { set; get; }
        public void performQuack()
        {
            quackBehavior.quack();
        }
        public void performSwim()
        {
            swimBehavior.swim();
        }
        public void whatDuck()
        {
            Console.WriteLine("这是一只{0}", name);
        }
    }
    class MailardDuck : Duck
    {
        public MailardDuck()
        {
            name = "MailardDuck";
            quackBehavior = new canQuack();
            swimBehavior = new canSwim();
        }
    }
    class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            name = "RedheadDuck";
            quackBehavior = new canQuack();
            swimBehavior = new canSwim();
        }
    }
    class RobberDuck : Duck
    {
        public RobberDuck()
        {
            name = "RobberDuck";
            quackBehavior = new canQuack();
            swimBehavior = new canSwim();
        }
    }
}
