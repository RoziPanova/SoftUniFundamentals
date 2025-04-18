using System;

namespace MathOperations
{
    internal class Program
    {
        static int MathOperations(int num1, int num2, string action)
        {
            if (action == "+")
            {
                return num1 + num2;
            }
            else if (action == "-")
            {
                return num1 - num2;
            }
            else if (action == "*")
            {
                return num1 * num2;
            }
            else { return num1 / num2; }
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(MathOperations(num1, num2, action));
        }
    }
}
