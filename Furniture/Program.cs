using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @">>(?<Furniture>[A-Za-z]+)<<(?<Price>\d+(.\d+)?)!(?<Count>\d+)";
            List<string> furniture = new List<string>();
            double total = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Purchase")
                {
                    break;
                }
                var matches = Regex.Matches(input, regex);
                foreach (Match match in matches)
                {
                    furniture.Add(match.Groups["Furniture"].Value);
                    total += double.Parse(match.Groups["Price"].Value) * double.Parse(match.Groups["Count"].Value);
                }
            }

            Console.WriteLine("Bought furniture:");
            for (int i = 0; i < furniture.Count; i++)
            {
                Console.WriteLine(furniture[i]);
            }

            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}


