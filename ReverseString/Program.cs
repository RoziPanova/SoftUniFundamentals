using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reversed = "";
            for (int i = word.Length-1; i >= 0; i--)
            {
                reversed = reversed + word[i];
            }
            Console.WriteLine(reversed);
        }
    }
}
