using System;
using System.Collections.Generic;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" : ");
                string course = input[0];
                if (course=="end")
                {
                    foreach (var item in courses)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value.Count}");
                        for (int i = 0; i < item.Value.Count; i++)
                        {
                            Console.WriteLine($"-- {item.Value[i]}");
                        }
                    }
                    break;
                }
                string name = input[1];
                if (courses.ContainsKey(course) == false)
                {
                    courses.Add(course, new List<string>() { name });
                }
                else
                {
                    courses[course].Add(name);
                }
            }
        }
    }
}
