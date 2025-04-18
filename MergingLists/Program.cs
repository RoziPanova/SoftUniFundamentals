using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> combined = new List<int>();
            if (list1.Count < list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    combined.Add(list1[i]);
                    combined.Add(list2[i]);
                }
                for (int i = list1.Count; i < list2.Count; i++)
                {
                    combined.Add(list2[i]);
                }
            }
            else
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    combined.Add(list1[i]);
                    combined.Add(list2[i]);
                }
                for (int i = list2.Count; i < list1.Count; i++)
                {
                    combined.Add(list1[i]);
                }
            }
            Console.WriteLine(string.Join(" ", combined));
        }
    }
}
