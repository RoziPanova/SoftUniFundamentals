using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int daysInAMonth = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                Console.WriteLine($"The price for the coffee is: ${Math.Round(((daysInAMonth * capsuleCount) * capsulePrice),2).ToString("0.00")}");
                total += (daysInAMonth * capsuleCount) * capsulePrice;
            }
            Console.WriteLine($"Total: ${Math.Round(total,2).ToString("0.00")}");
        }
    }
}
