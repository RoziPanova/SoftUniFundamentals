using System;

namespace SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = i;
                string flag = "False";
                while (num != 0)
                {
                    sum += num % 10;
                    num =num/ 10;
                }
                if (sum==5||sum==7||sum==11)
                {
                    flag = "True";
                }
                Console.WriteLine($"{i} -> {flag}");
                sum = 0;
            }
        }
    }
}
