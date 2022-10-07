using System;
//完成课堂要求的DuckBehaviorWithInterface项目编写，提交克隆地址。
namespace Project10
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck1 = new MailardDuck();
            Duck duck2 = new RedheadDuck();
            Duck duck3 = new RobberDuck();

            duck1.whatDuck();
            duck1.performQuack();
            duck1.performSwim();
            Console.WriteLine("-------");
            duck2.whatDuck();
            duck2.performQuack();
            duck2.performSwim();
            Console.WriteLine("-------");
            duck3.whatDuck();
            duck3.performQuack();
            duck3.performSwim();
        }
    }
}
