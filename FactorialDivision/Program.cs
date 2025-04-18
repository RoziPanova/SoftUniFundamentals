using System;
using System.Xml.Serialization;

namespace FactorialDivision
{
    internal class Program
    {
        static double Factorial(double num)
        {
            double facNum = 1;
            for (int i = 1; i <= num; i++)
            {
                facNum *= i;
            }
            return facNum;
        }

        static void Main(string[] args)
        {
            double num1=double.Parse(Console.ReadLine());
            double num2=double.Parse(Console.ReadLine());
            double facNum1 = Factorial(num1);
            double facNum2 = Factorial(num2);
            double output = facNum1 / facNum2;
            Console.WriteLine($"{output:f2}");
        }
    }
}
