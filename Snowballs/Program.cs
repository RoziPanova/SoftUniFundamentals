﻿using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger max = 0;
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;
            
            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger value = BigInteger.Pow(snow / time, quality);
                if (value>=max)
                {
                    max = value;
                    maxSnow = snow;
                    maxTime = time;
                    maxQuality = quality;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {max} ({maxQuality})");
        }
    }
}
