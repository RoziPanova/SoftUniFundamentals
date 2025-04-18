using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceofEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int count = 0;
            int max = 0;
            int starter = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                    if (count>max)
                    {
                        starter = i - count;
                        max = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int i = starter+1; i <= starter+max+1; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}
