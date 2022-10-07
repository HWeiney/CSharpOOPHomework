using System;
/**
 * 定义一个员工类,自己分析出几个成员，然后给出成员变量，构造方法，
 * getXxx()/setXxx()方法，以及一个显示所有成员信息的方法，在程序main函数中进行测试。
 */
namespace Project02
{
    class Staff
    {
        private String name;
        private String sex;
        private int age;
        public Staff() { }
        public Staff(String name,String sex,int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
        public String staff_name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }
        public String staff_sex
        {
            set
            {
                this.sex = value;
            }
            get
            {
                return this.sex;
            }
        }
        public int staff_age
        {
            set
            {
                this.age = value;
            }
            get
            {
                return this.age;
            }
        }
        public void setStaffname(String name)
        {
            this.name = name;
        }
        public String getStaffname()
        {
            return name;
        }
        public void setStaffsex(String sex)
        {
            this.sex = sex;
        }
        public String getStaffsex()
        {
            return sex;
        }
        public void setStaffage(int age)
        {
            this.age = age;
        }
        public int getStaffage()
        {
            return age;
        }
        public void show()
        {
            Console.WriteLine("员工姓名：{0}\n员工性别：{1}\n员工年龄：{2}", this.name, this.sex, this.age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff("韩伟","男",21);
            staff.show();
            Console.WriteLine("更改员工姓名：");
            staff.staff_name = Console.ReadLine();
            staff.show();
        }
    }
}
