using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int>wagons=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int max=int.Parse(Console.ReadLine());
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0]=="end")
                {
                    Console.WriteLine(string.Join(" ",wagons));
                    break;
                }
                else if (input[0]=="Add")
                {
                    wagons.Add(int.Parse(input[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(input[0])<=max)
                        {
                            wagons[i] += int.Parse(input[0]);
                            break;
                        }
                    }
                }
            }
        }
    }
}
