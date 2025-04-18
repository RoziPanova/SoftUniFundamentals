using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>list=Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "Finish")
                {
                    Console.WriteLine(string.Join(" ", list));
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
                else if (input[0] == "Replace")
                {
                    int index = list.IndexOf(int.Parse(input[1]));
                    list.RemoveAt(index);
                    list.Insert(index, int.Parse(input[2]));
                }
                else if (input[0]=="Collapse")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] < int.Parse(input[1]))
                        {
                            list.Remove(list[i]);
                            i--;
                        }
                    }
                }
            }
        }
    }
}
