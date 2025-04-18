using System;

namespace PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double halfN = n * 0.50;
            int count = 0;
            while (true)
            {
                if (n < m)
                {
                    Console.WriteLine(n);
                    Console.WriteLine(count);
                    break;
                }
                n -= m;
                if (n == halfN&&y>0)
                {
                    n = n / y;
                }
                count++;
            }
        }
    }
}
