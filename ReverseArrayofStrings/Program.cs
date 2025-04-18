using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseArrayofStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<string> list = Console.ReadLine().Split(" ").ToList();
            list.Reverse();
            Console.Write(String.Join(" ",list));
        }
    }
}
