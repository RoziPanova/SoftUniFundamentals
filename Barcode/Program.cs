using System;
using System.Text.RegularExpressions;

namespace Barcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"^@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";
            int count=int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string barcode = Console.ReadLine();

                if (Regex.IsMatch(barcode, regex))
                {
                    string group = "";
                    for (int k = 0; k < barcode.Length; k++)
                    {
                        if (char.IsDigit(barcode[k]))
                        {
                            group += barcode[k].ToString();
                        }
                    }
                    if (group!="")
                    {
                        Console.WriteLine($"Product group: {group}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
