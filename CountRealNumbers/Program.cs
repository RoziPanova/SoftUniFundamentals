using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            SortedDictionary<double,int> counts=new SortedDictionary<double,int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (counts.ContainsKey(list[i]))
                {
                    counts[list[i]]++;
                }
                else
                {
                    counts.Add(list[i], 1);
                }
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
