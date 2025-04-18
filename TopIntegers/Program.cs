using System;
using System.Linq;

namespace TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int k = i+1; k < array.Length; k++)
                {
                    if (array[i] > array[k])
                    {
                        count++;
                    }
                }
                if (count == array.Length - (i + 1))
                {
                    Console.Write(array[i]+" ");
                }
            }
        }
    }
}
