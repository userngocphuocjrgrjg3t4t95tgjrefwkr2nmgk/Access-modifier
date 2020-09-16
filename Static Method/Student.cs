using System;

namespace Static_Method
{
    public class Student
    {
        private int rollno;
        private string name;
        private static string college ="BBDIT";

        public Student(int r, string n){
            rollno= r;
            name =n;
        }
        public static void Change()
        {
            college="CodeGym";
        }

        public void Display(){
            Console.WriteLine(rollno + " " + name + " " + college);
        }
    }
}