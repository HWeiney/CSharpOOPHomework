using System;
using Project06;
/*按要求编写一个控制台应用程序:
1）定义一个抽象类Animal，其中包括属性name，相关构造方法，抽象方法enjoy()表示动物高兴时动作。
2）定义Cat类继承于Animal类，其中包括属性eyesColor，相关构造方法，同时具体化父类中的抽象方法。
3）定义Dog类继承于Animal类，其中包括属性furColor，相关构造方法，同时具体化父类中的抽象方法。
4）定义Lady类，其中包括属性name,以及Animal类型的属性pet表示女士所养的宠物，定义构造方法，生成女士对象时初始化姓名和她所养的宠物。定义一个方法：myPetEnjoy表示此女士的宠物在高兴时的动作。
5）定义测试类。
创建一个张女士，养了一只猫，让这只猫笑一笑
创建一个王女士，养了一只狗，让这只狗叫一叫*/
namespace Project07
{
    class Lady
    {
        public String ladyName { set; get; }
        public Animal pet { set; get; }
        public Lady(String ladyName, Animal pet)
        {
            this.ladyName = ladyName;
            this.pet = pet;
        }
        public void myPetEnjoy()
        {
            Console.WriteLine("我是{0}", ladyName);
            pet.enjoy();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lady lady1 = new Lady("张女士", (new Store()).getInstance("Cat"));
            lady1.myPetEnjoy();
            Lady lady2 = new Lady("王女士", (new Store()).getInstance("Dog"));
            lady2.myPetEnjoy();
        }
    }
}
