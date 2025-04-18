using System;

namespace RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }

                if (sum == 5 || sum == 7|| sum == 11)
                {
                    Console.WriteLine("{0} -> {1}", i,"True");
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", i, "False");
                }
                sum = 0;
            }
        }
    }
}
