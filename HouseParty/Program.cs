using System;
using System.Collections.Generic;

namespace HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[2] == "going!")
                {
                    if (guests.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(input[0]);
                    }
                }
                else
                {
                    if (guests.Contains(input[0]) == false)
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                    else
                    {
                        guests.Remove(input[0]);
                    }
                }
            }

            Console.WriteLine(string.Join("\n", guests));
        }
    }
}
