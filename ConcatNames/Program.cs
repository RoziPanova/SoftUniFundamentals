using System;

namespace ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string last = Console.ReadLine();
            string devider = Console.ReadLine();
            Console.WriteLine($"{name}{devider}{last}");
        }
    }
}
