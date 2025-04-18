using System;
using System.Collections.Generic;

namespace PrintNumbersinReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> list = new List<int>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            list.Reverse();
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
