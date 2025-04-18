using System;
using System.Linq;

namespace PalindromeIntegers
{
    internal class Program
    {
        static void Palondrome(string number)
        {
            if (number.First() == number.Last())
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string number = Console.ReadLine();
                if (number == "END")
                { break; }
                else
                {
                    Palondrome(number);
                }
            }
        }
    }
}
