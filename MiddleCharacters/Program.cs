using System;

namespace MiddleCharacters
{
    internal class Program
    {
        static void Middle(char[] array)
        {
            if (array.Length%2==0)
            {
                Console.WriteLine(array[array.Length / 2 - 1] + "" + array[array.Length/2]);
            }
            else
            {
                Console.WriteLine(array[array.Length/2]);
            }
        }
        static void Main(string[] args)
        {
            char[] array=Console.ReadLine().ToCharArray();
            Middle(array);
        }
    }
}
