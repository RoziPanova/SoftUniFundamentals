﻿using System;

namespace SumofChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum+= letter;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
