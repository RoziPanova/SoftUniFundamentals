﻿using System;
using System.Linq;

namespace EvenandOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenSum += array[i];
                }
                else
                {
                    oddSum += array[i];
                }
            }
            Console.WriteLine(evenSum-oddSum);
        }
    }
}
