﻿using System;

namespace Static_Method
{
    class Program
    {
        static void Main(string[] args)
        {
           Student.Change();

            Student s1 = new Student(111, "Ngoc Phuoc");
            Student s2 = new Student(222, "Khanh");
            Student s3 = new Student(333, "Nam");
            //calling display method
            s1.Display();
            s2.Display();
            s3.Display();
        }
    }
}
