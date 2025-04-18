using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('|').Reverse().ToList();
           List<int>numbers=new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                numbers.AddRange(list[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
