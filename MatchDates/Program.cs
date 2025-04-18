using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<Day>\d{2})([-./])(?<Month>[A-Z]{1}[a-z]{2})\1(?<Year>\d{4})\b";
            string input=Console.ReadLine();
            var dates = Regex.Matches(input, regex);
            foreach ( Match date in dates )
            {
                var day = date.Groups["Day"].Value;
                var month = date.Groups["Month"].Value;
                var year = date.Groups["Year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
