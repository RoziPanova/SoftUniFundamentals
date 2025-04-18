using System;
using System.Collections.Generic;

namespace CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string companyName = input[0];
                if (companyName=="End")
                {
                    foreach (var item in company)
                    {
                        Console.WriteLine($"{item.Key}");
                        for (int i = 0; i < item.Value.Count; i++)
                        {
                            Console.WriteLine($"-- {item.Value[i]}");
                        }
                    }
                    break;
                }
                string ID = input[1];
                if (company.ContainsKey(companyName) == false)
                {
                    company.Add(companyName, new List<string>() { ID });
                }
                else
                {
                    if (company[companyName].Contains(ID))
                    { continue; }
                    else
                    {
                        company[companyName].Add(ID);
                    }

                }
            }
        }
    }
}

