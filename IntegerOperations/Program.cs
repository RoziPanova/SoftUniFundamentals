using System;

namespace IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            int final = ((first + second) / third) * fourth;
            Console.WriteLine(final);
        }
    }
}
