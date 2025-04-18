using System;
using System.Text.RegularExpressions;

namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string regex = @"^(\W+|\w+)>(?<nums>\d+)\|(?<lower>[a-z]+)\|(?<upper>[A-Z]+)\|(?<symbols>\W[^<>]+|\w[^<>]+)<\1$";
            for (int i = 0; i < n; i++)
            {
                string password= Console.ReadLine();
                if (Regex.IsMatch(password,regex))
                {
                    Match match=Regex.Match(password,regex);
                    string nums = match.Groups["nums"].Value.ToString();
                    string lower= match.Groups["lower"].Value.ToString();
                    string upper = match.Groups["upper"].Value.ToString();
                    string symbols = match.Groups["symbols"].Value.ToString();
                    Console.WriteLine($"Password: {nums+lower+upper+symbols}");
                }
                else { Console.WriteLine("Try another password!"); }
            }
        }
    }
}
/*
5
aa>111|mqu|BAU|mqu<aa
()>111!aaa!AAA!^&*<()
o>088|abc|AAA|***<o
asd>asd|asd|ASD|asd<asd
*>088|zzzz|ZzZ|123<*
 */
