using System;
using System.Collections.Generic;
using System.Linq;

namespace ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var list = Console.ReadLine().ToList();
            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i] == list[i+1])
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join("",list));
        }
    }
}
