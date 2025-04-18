using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool flag = false;
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "end")
                {
                    if (flag == true)
                    {
                        Console.WriteLine(string.Join(" ", list));
                    }
                    break;
                }
                else if (input[0] == "Add")
                {
                    list.Add(int.Parse(input[1]));
                    flag = true;
                }
                else if (input[0] == "Remove")
                {
                    list.Remove(int.Parse(input[1]));
                    flag = true;
                }
                else if (input[0] == "RemoveAt")
                {
                    list.RemoveAt(int.Parse(input[1]));
                    flag = true;
                }
                else if (input[0] == "Insert")
                {
                    list.Insert(int.Parse(input[2]), int.Parse(input[1]));
                    flag = true;
                }
                else if (input[0] == "Contains")
                {
                    if (list.Contains(int.Parse(input[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (input[0] == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", list.Where(x => x % 2 == 0)));
                }
                else if (input[0] == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", list.Where(x => x % 2 != 0)));
                }
                else if (input[0] == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        sum += list[i];
                    }
                    Console.WriteLine(sum);
                }
                else if (input[0] == "Filter")
                {
                    if (input[1] == "<")
                    {
                        Console.WriteLine(string.Join(" ", list.Where(x => x < int.Parse(input[2]))));
                    }
                    else if (input[1] == ">")
                    {
                        Console.WriteLine(string.Join(" ", list.Where(x => x > int.Parse(input[2]))));
                    }
                    if (input[1] == "<=")
                    {
                        Console.WriteLine(string.Join(" ", list.Where(x => x <= int.Parse(input[2]))));
                    }
                    if (input[1] == ">=")
                    {
                        Console.WriteLine(string.Join(" ", list.Where(x => x >= int.Parse(input[2]))));
                    }
                }
            }
        }
    }
}
