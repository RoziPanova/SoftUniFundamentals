/*
gold
155
silver
10
copper
17
gold
15
stop
 */
using System;
using System.Collections.Generic;
using System.Numerics;

namespace AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, BigInteger> dic = new Dictionary<string, BigInteger>();
            while (true)
            {
                string material = Console.ReadLine();
                if (material == "stop")
                {
                    foreach (var item in dic)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    break;
                }
                BigInteger quantity = BigInteger.Parse(Console.ReadLine());
                if (dic.ContainsKey(material) == false)
                {
                    dic.Add(material, quantity);
                }
                else
                {
                    dic[material] += quantity;
                }
            }
        }
    }
}
