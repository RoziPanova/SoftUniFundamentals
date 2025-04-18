using System;
using System.Collections.Generic;

namespace CharstoString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>();
            for (int i = 0; i < 3; i++)
            {
                list.Add(char.Parse(Console.ReadLine()));
            }
            Console.WriteLine( String.Join("",list) );
        }
    }
}
