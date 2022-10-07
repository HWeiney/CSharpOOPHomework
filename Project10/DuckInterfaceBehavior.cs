using System;
using System.Collections.Generic;
using System.Text;

namespace Project10
{
    interface IQuackBehavior
    {
        public void quack();
    }
    interface ISwimBehavior
    {
        public void swim();
    }
    public class canQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("会嘎嘎的叫");
        }
    }
    public class canSwim : ISwimBehavior
    {
        public void swim()
        {
            Console.WriteLine("会哗哗的游");
        }
    }
}
