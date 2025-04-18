using System;
using System.Collections.Generic;
using System.Linq;

namespace ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>();
            for (int i = 0; i < 3; i++)
            {
                char n = char.Parse(Console.ReadLine());
                list.Add(n);
            }
            list.Reverse();
            Console.WriteLine(String.Join(' ',list));
            
        }
    }
}
