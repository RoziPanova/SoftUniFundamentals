using System;

namespace SignofIntegerNumber
{
    internal class Program
    {

        static void Signs(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Signs(number);
        }

    }
}
