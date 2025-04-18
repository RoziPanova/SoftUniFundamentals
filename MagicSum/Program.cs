using System;
using System.Linq;

namespace MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]array=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum=int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int k = i+1; k < array.Length; k++)
                {
                    if (array[i] + array[k] == sum)
                    {
                        Console.WriteLine(array[i] + " " + array[k]);
                    }
                }
                
            }
        }
    }
}
