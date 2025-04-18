using System;
using System.Text.RegularExpressions;

namespace NameMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string check = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            MatchCollection matchCollection = Regex.Matches(input, check);
            foreach (Match match in matchCollection)
            { Console.Write(match.Value + " "); }
            Console.WriteLine();
        }
    }
}
