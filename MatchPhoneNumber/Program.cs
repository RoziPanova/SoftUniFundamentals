using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex= @"(?:\+[359]+ 2 \d{3} \d{4})(?:\b)|(?:\+[359]+-2-\d{3}-\d{4})(?:\b)";
            string input=Console.ReadLine();
            MatchCollection match=Regex.Matches(input,regex);
            var phones=match.Cast<Match>().Select(x=>x.Value.Trim()).ToList();
            Console.WriteLine(string.Join(", ",phones));
        }
    }
}

