﻿using System;

namespace dotnet_QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
           double x1 = 0.0;
            double x2 = 0.0;
            Console.Write("Giai phuong trinh bac hai trong C#: \n");
            Console.Write("---------------------------------------------------");
            
            Console.Write("Nhap gia tri cua a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nNhap gia tri cua b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nNhap gia tri cua c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            QuadraticEquation qe = new QuadraticEquation(a, b, c);
            double delta = qe.GetDiscriminant(a, b, c);
            a = qe.GetA();
            b = qe.GetB();
            c = qe.GetC();
            if (delta == 0)
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("The equation has one root = {0}\n", x1);
            }
            else if (delta > 0)
            {
                x1 = qe.GetRoot1(a, b, delta);
                x2 = qe.GetRoot2(a, b, delta);

                Console.Write("The equation has two roots {0} and {1}\n", x1, x2);
            }
            else
            {
                Console.Write("The equation has no roots");
            }
            Console.ReadKey();
        }
    }
}
