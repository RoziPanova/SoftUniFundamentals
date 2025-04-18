using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    Console.WriteLine(string.Join(" ", list));
                    break;
                }
                else if (input[0] == "Add")
                {
                    list.Add(int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
                {
                    if (int.Parse(input[2]) < 0 || int.Parse(input[2]) > list.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.Insert(int.Parse(input[2]), int.Parse(input[1]));
                    }
                }
                else if (input[0] == "Remove")
                {
                    if (int.Parse(input[1]) < 0 || int.Parse(input[1]) > list.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                        list.RemoveAt(int.Parse(input[1]));
                }
                else if (input[1] == "left")
                {
                    for (int i = 0; i < int.Parse(input[2]); i++)
                    {
                        list.Add(list[i]);
                    }
                    for (int i = 0; i < int.Parse(input[2]); i++)
                    {
                        list.Remove(list[0]);
                    }
                }
                else if (input[1] == "right")
                {
                    list.Reverse();
                    for (int i = 0; i < int.Parse(input[2]); i++)
                    {
                        list.Add(list[i]);
                    }
                    for (int i = 0; i < int.Parse(input[2]); i++)
                    {
                        list.Remove(list[0]);
                    }
                    list.Reverse();
                }
            }
        }
    }
}
