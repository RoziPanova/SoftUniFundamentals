using System;

namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int total = 0;
            int count = 0;
            while (true)
            {                
                if (startingYield<100)
                {
                    Console.WriteLine(count);
                    if (total-26<0)
                    {
                        Console.WriteLine("0");
                    }
                    else
                    {
                        Console.WriteLine(total-26);
                    }
                    break;
                }
                total += startingYield;
                total -= 26;
                startingYield -= 10;
                count++;
            }
        }
    }
}
