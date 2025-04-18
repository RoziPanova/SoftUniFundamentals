using System;

namespace MathPower
{
    internal class Program
    {
        static double Power(double num, int power)
        {
            return Math.Pow(num, power);
        }
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(num,power));
        }
    }
}
