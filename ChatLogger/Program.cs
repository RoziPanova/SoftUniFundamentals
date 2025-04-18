using System;
using System.Collections.Generic;

namespace ChatLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "end")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]) ;
                    }
                    break;
                }
                if (input[0] == "Chat")
                {
                    list.Add(input[1]);
                }
                if (input[0] =="Delete")
                {
                    if (list.Contains(input[1]))
                    {
                        list.Remove(input[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
                if (input[0] == "Edit")
                {
                    int index = 0;
                    if (list.Contains(input[1]))
                    {
                        index = list.IndexOf(input[1]);
                        list.Remove(input[1]);
                        list.Insert(index, input[2]);
                    }
                    else
                    {
                        continue;
                    }
                }
                if (input[0] == "Pin")
                {
                    if (list.Contains(input[1]))
                    {
                        list.Remove(input[1]);
                        list.Add(input[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
                if (input[0] == "Spam")
                {
                    for (int i = 1; i <= input.Length-1; i++)
                    {
                        list.Add(input[i]);
                    }
                }
            }
        }
    }
}
