using System;
using System.Collections.Generic;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
                sum += list[i];
            }
            Console.WriteLine(String.Join(" ",list));
            Console.WriteLine(sum);
        }
    }
}
