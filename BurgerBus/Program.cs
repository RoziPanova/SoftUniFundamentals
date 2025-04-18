using System;

namespace BurgerBus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalEarnings = 0;
            for (int i = 1; i <= n; i++)
            {
                string city = Console.ReadLine();
                double income = double.Parse(Console.ReadLine());
                double expenses = double.Parse(Console.ReadLine());

                if (i % 3 == 0 && i % 5 != 0)
                {
                    expenses += expenses * 0.50;
                }
                if (i % 5 == 0)
                {
                    income -= income * 0.10;
                }

                Console.WriteLine($"In {city} Burger Bus earned {income - expenses:f2} leva.");

                totalEarnings += income - expenses;
            }
            Console.WriteLine($"Burger Bus total profit: {totalEarnings:f2} leva.");
        }
    }
}
