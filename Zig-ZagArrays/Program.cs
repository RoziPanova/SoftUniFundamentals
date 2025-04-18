using System;
using System.Linq;

namespace Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] arr3 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    arr1[i] = arr3[1];
                    arr2[i] = arr3[0];
                }
                else
                {
                    arr1[i] = arr3[0];
                    arr2[i] = arr3[1];
                }
            }
            Console.WriteLine(String.Join(" ",arr2));
            Console.WriteLine(String.Join(" ", arr1));
        }
    }
}
