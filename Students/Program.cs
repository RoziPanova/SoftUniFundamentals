using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Students
    {
        public string Name { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "end")
                {
                    string town = Console.ReadLine();
                    for (int i = 0; i < students.Count; i++)
                    {
                        if (students[i].Town == town)
                        {
                            Console.WriteLine($"{students[i].Name} {students[i].LName} is {students[i].Age} years old.");
                        }
                    }
                    break;
                }
                Students current = new Students();
                current.Name = input[0];
                current.LName = input[1];
                current.Age = int.Parse(input[2]);
                current.Town = input[3];
                students.Add(current);
            }
        }
    }
}
