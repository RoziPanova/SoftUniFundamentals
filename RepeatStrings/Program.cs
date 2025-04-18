using System;

namespace RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]array=Console.ReadLine().Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = 0; k < array[i].Length; k++)
                {
                    Console.Write(array[i]);
                }
            }
        }
    }
}
