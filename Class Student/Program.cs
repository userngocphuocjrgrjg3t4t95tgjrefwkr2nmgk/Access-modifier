using System;

namespace Class_Student
{
    class Program
    {
        static void Main(string[] args)
        {
           Student stu1 = new Student(1,"Ngoc Phuoc","Hue",22);
           Student stu2 = new Student();
           stu2.SetId(2);
           stu2.SetName("Hoang");
           stu2.SetAddress("Ha Noi");
           stu2.SetAge(20);
            Console.WriteLine(stu1.ToString());
            Console.WriteLine(stu2.ToString());
           Console.Read();

        }
    }
}
