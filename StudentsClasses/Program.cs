/*
4
Lakia Eason 3,90
Prince Messing 5,49
Akiko Segers 4,85
Rocco Erben 6,00
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsClasses
{
    internal class Program
    {
        class Students
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public double Grade { get; set; }
            public override string ToString()
            {
                return $"{FName} {LName}: {Grade:f2}";
            }

        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            List<Students> list = new List<Students>();
            for (int i = 0; i < n; i++)
            {
                string[]input=Console.ReadLine().Split(' ');
                Students s = new Students();
                s.FName = input[0];
                s.LName = input[1];
                s.Grade = double.Parse(input[2]);
                list.Add(s);
            }
            var sorted=list.OrderByDescending(x=>x.Grade).ToList();
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine(sorted[i].ToString());
            }
        }
    }
}
