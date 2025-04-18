using System;
using System.Linq;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int first = 0;
            for (int i = 0; i < n; i++)
            {
                first = array[0];
                for (int j = 0; j < array.Length-1; j++)
                {   
                    array[j] =array[j+1];
                }
                array[array.Length - 1] = first;
            }
            Console.WriteLine(String.Join(" ",array));
        }
    }
}
