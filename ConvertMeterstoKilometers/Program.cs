using System;

namespace ConvertMeterstoKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number*1.0/1000:f2}");
        }
    }
}
