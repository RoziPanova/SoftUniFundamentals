using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,List<double>>students=new Dictionary<string,List<double>>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade=double.Parse(Console.ReadLine());
                if (students.ContainsKey(name)==false)
                {
                    students.Add(name, new List<double>() { grade });
                }
                else
                {
                    students[name].Add(grade);
                }
            }
            foreach (var item in students)
            {
                if (item.Value.Average()<4.5)
                {
                    students.Remove(item.Key);
                    continue;
                }
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}

