using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"^%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            double total = 0;

            while (true)
            {
                string input = Console.ReadLine();


                if (input == "end of shift")
                {
                    Console.WriteLine($"Total income: {total:f2}");
                    break;
                }
                if (Regex.IsMatch(input, regex))
                {
                    var match = Regex.Match(input, regex);
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    double count = double.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    Console.WriteLine($"{name}: {product} - {count * price:f2}");
                    total += count * price;
                }
            }
        }
    }
}
/*
%InvalidName%<Croissant>|2|10,3$
%Peter%<Gum>1,3$
%Maria%<Cola>|1|2,4
%Valid%<Valid>valid|10|valid20$
end of shift
 */