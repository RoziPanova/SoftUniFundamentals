﻿using System;

namespace PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1=int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            { 
                Console.Write(char.ConvertFromUtf32(i)+" ");
            }
        }
    }
}
