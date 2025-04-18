using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double total = 0;
            int count = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    total += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    total += mousePrice;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    total += keyboardPrice;
                    count++;
                }
                if (count == 2)
                {
                    total += displayPrice;
                    count = 0;
                }
            }
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
