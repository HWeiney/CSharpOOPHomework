using System;
/*按要求编写一个控制台应用程序:
（1）编写接口InterfaceA，接口中含有方法void printCapitalLetter()。
（2）编写接口InterfaceB，接口中含有方法void printLowercaseLetter()。
（3）编写非抽象类Print，该类实现了接口InterfaceA和InterfaceB。
要求printCapitalLetter()方法实现输出大写英文字母表的功能，
printLowercaseLetter()方法实现输出小写英文字母表的功能。
（4）编写测试程序，在main方法中创建Print的对象并赋值给InterfaceA的变量a
由变量a调用printCapitalLetter方法，然后再创建Print的对象并将该对象赋值给InterfaceB的变量b
由变量b调用printLowercaseLetter方法
*/
namespace Project08
{
    interface InterfaceA
    {
        public void printCapitalLetter();
    }
    interface InterfaceB
    {
        public void printLowercaseLetter();
    }
    class Print : InterfaceA,InterfaceB
    {
        public void printCapitalLetter()
        {
            char begin = 'A';
            for(int i=0;i<26;i++)
            {
                Console.Write("{0} ",(char)(begin + i));
            }
            Console.WriteLine();
        }
        public void printLowercaseLetter()
        {
            char begin = 'a';
            for (int i = 0; i < 26; i++)
            {
                Console.Write("{0} ", (char)(begin + i));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Print a = new Print();
            Console.WriteLine("大写字母表方法：");
            a.printCapitalLetter();
            Print b = new Print();
            Console.WriteLine("小写字母表方法：");
            b.printLowercaseLetter();
        }
    }
}
