using System;

namespace Calculations
{
    internal class Program
    {
        static void Calc(string operation,int a,int b)
        {
            if (operation== "add")
            {
                Console.WriteLine(a+b);
            }
            else if (operation== "subtract")
            {
                Console.WriteLine(a-b);
            }
            else if (operation== "multiply")
            {
                Console.WriteLine(a*b);
            }
            else
            {
                Console.WriteLine(a/b);
            }
        }
        static void Main(string[] args)
        {
            string operation=Console.ReadLine();
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            Calc(operation, a, b);
        }
    }
}
