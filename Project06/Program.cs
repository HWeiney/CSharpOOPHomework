using System;
/*按要求编写一个控制台应用程序:
定义一个动物类，里面有一个方法voice(),
定义一个类Cat,实现voice方法;
然后增加一种新的动物类型：Pig(猪)，实现voice()方法。
定义一个Dog类，实现voice方法
定义一个Store（宠物店）类的getInstance方法，该方法的返回值为动物类：
如果传入的参数是字符串dog，则返回一个Dog对象；
如果传入pig，则返回一个Pig对象；否则，返回一个Cat对象。*/

namespace Project06
{
    public abstract class Animal
    {
        public string name { set; get; }
        public abstract void voice();
        public abstract void enjoy();
    }
    public class Cat : Animal
    {
        private String eye_color { set; get; }
        public Cat(String name) { base.name = name; }
        public Cat(string name,String eye_color)
        {
            base.name = name;
            this.eye_color = eye_color;
        }
        public override void voice()
        {
            Console.WriteLine("喵");
        }
        public override void enjoy()
        {
            Console.WriteLine("我的{0}高兴时喵了一声", base.name);
        }
    }
    public class Pig : Animal
    {
        private String fur_color { set; get; }
        public Pig(String name) { base.name = name; }
        public Pig(string name, String fur_color)
        {
            base.name = name;
            this.fur_color = fur_color;
        }
        public override void voice()
        {
            Console.WriteLine("哼");
        }
        public override void enjoy()
        {
            Console.WriteLine("我的{0}高兴时哼了一声", base.name);
        }
    }
    public class Dog : Animal
    {
        private String fur_color { set; get; }
        public Dog(String name) { base.name = name; }
        public Dog(string name, String fur_color)
        {
            base.name = name;
            this.fur_color = fur_color;
        }
        public override void voice()
        {
            Console.WriteLine("汪");
        }
        public override void enjoy()
        {
            Console.WriteLine("我的{0}高兴时汪了一声",base.name);
        }
    }
    public class Store
    {
        public Animal getInstance(string name)
        {
            if(name == "Dog")
            {
                return new Dog(name);
            }
            if(name == "Cat")
            {
                return new Cat(name);
            }
            if (name == "Pig")
            {
                return new Pig(name);
            }
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入宠物名字（Cat、Pig、Dog）");
            string name = Console.ReadLine();
            Store store = new Store();
            Animal pet = store.getInstance(name);
            if(pet != null)
            {
                pet.voice();
            }
            else
            {
                Console.WriteLine("没有该宠物名字（Cat、Pig、Dog）");
            }
        }
    }
}
