using System;
using System.ComponentModel.Design;
using System.Linq;

namespace StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().ToList();
            int explosion = 0;
            for (int i = 0; i < line.Count; i++)
            {
                if (explosion > 0 && line[i] != '>')
                {
                    line.RemoveAt(i);
                    explosion--;
                    i--;
                }
                else if (line[i] == '>')
                {
                    explosion += int.Parse(char.ConvertFromUtf32(line[i+1]));
                }
            }
            Console.WriteLine(string.Join("", line));
        }
    }
}
