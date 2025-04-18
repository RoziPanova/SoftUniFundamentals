using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>list=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                string[]input=Console.ReadLine().Split().ToArray();
                if (input[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", list));
                    break;
                }
                else if (input[0]=="Delete")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == int.Parse(input[1]))
                        {
                            list.Remove(int.Parse(input[1]));
                        }
                    }
                }
                else if (input[0]=="Insert")
                {
                    list.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
            }
        }
    }
}
