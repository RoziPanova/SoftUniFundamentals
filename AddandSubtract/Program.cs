﻿using System;

namespace AddandSubtract
{
    internal class Program
    {
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Substract(int num1, int num2, int num3)
        {
            return (Add(num1, num2) - num3);
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Substract(num1, num2, num3));
        }
    }
}
