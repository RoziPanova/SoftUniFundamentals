using System;

namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tank = 0;
            for (int i = 0; i < n; i++)
            {
                int fill = int.Parse(Console.ReadLine());
                if (tank+fill>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tank += fill;
                }
            }
            Console.WriteLine(tank);
        }
    }
}
