using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "end")
                {
                    Console.WriteLine(string.Join(" ",list));
                    break;
                }
                else if (input[0] == "Add")
                {
                    list.Add(int.Parse(input[1]));
                }
                else if (input[0] == "Remove")
                {
                    list.Remove(int.Parse(input[1]));
                }
                else if (input[0] == "RemoveAt")
                {
                    list.RemoveAt(int.Parse(input[1]));
                }
                else if (input[0]=="Insert")
                {
                    list.Insert(int.Parse(input[2]),int.Parse(input[1]));
                }
            }
        }
    }
}
