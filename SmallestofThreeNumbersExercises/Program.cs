using System;
using System.Collections.Generic;

namespace SmallestofThreeNumbersExercises
{
    internal class Program
    {
        static void Smallest(List<int> num)
        {
            int min = int.MaxValue;
            for (int i = 0; i < num.Count; i++)
            {
                if (min > num[i])
                {
                    min = num[i];
                }
            }
            Console.WriteLine(min);
        }

        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                num.Add(int.Parse(Console.ReadLine()));
            }
            Smallest(num);
        }
    }
}
