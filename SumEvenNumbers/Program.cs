﻿using System;
using System.Linq;

namespace SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
