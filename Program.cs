﻿using System;

namespace first
{
    class method
    {
        public double SUM(double a, double b)
        {
            return a + b;
        }

        public int SUM(int a, int b, int c)
        {
            return a + b + c;
        }
        public int SUM(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            method calculator = new method();

            double N1 = calculator.SUM(2.5, 3.5);
            int N2 = calculator.SUM(3, 3, 3);
            int N3 = calculator.SUM(4, 4, 4, 4);

            Console.WriteLine("результат суммы двух чисел: " + N1);
            Console.WriteLine("результат суммы трех чисел: " + N2);
            Console.WriteLine("результат суммы четырех чисел: " + N3);

        }
    }


} 
