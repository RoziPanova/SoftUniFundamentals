using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> print = new List<int>();
            int last = list.Count - 1;
            for (int i = 0; i <= last; i++)
            {
                if (i == last)
                {
                    print.Add(list[i]);
                }
                else
                {
                    print.Add(list[i] + list[last]);
                    last--;
                }
            }
            Console.WriteLine(string.Join(" ", print));
        }
    }
}
