using System;

namespace RepeatString
{
    internal class Program
    {
        static string Print(string word,int n)
        {
            string line = "";
            for (int i = 0; i < n; i++)
            {
                line += word;
            }
            return line;
        }
        static void Main(string[] args)
        {
            string word=Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Print(word,n));
        }
    }
}
