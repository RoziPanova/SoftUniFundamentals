using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regexName = @"(?<Contenters>[A-Za-z]+)";
            string regexDistance = @"(?<Distance>\d+)";
            var names = Console.ReadLine().Split(", ");
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < names.Length; i++)
            {
                dic.Add(names[i], 0);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race")
                {
                    break;
                }
                var matchesName = Regex.Matches(input, regexName);
                var matchesDistance = Regex.Matches(input, regexDistance);
                string name = "";
                string distance = "";
                foreach (Match match in matchesName)
                {
                    name += match.Groups["Contenters"].Value.ToString();
                }
                foreach (Match match in matchesDistance)
                {
                    distance += match.Groups["Distance"].Value.ToString();
                }
                if (dic.ContainsKey(name))
                {
                    int total = 0;
                    for (int i = 0; i < distance.Length; i++)
                    {
                        total += int.Parse(distance[i].ToString());
                    }
                    dic[name] += total;
                }
            }
            List<string> list = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                int max = 0;
                string name = "";
                foreach (var item in names)
                {
                    if (dic.ContainsKey(item))
                    {
                        if (dic[item] > max)
                        {
                            max = dic[item];
                            name = item;
                        }
                    }
                }
                dic.Remove(name);
                list.Add(name);
            }
            if (list.Count == 3)
            {
                Console.WriteLine($"1st place: {list[0]}");
                Console.WriteLine($"2nd place: {list[1]}");
                Console.WriteLine($"3rd place: {list[2]}");
            }
            if (list.Count == 2)
            {
                Console.WriteLine($"1st place: {list[0]}");
                Console.WriteLine($"2nd place: {list[1]}");
                Console.WriteLine($"3rd place: ");
            }
            if (list.Count == 1)
            {
                Console.WriteLine($"1st place: {list[0]}");
                Console.WriteLine($"2nd place: ");
                Console.WriteLine($"3rd place: ");
            }
        }
    }
}

