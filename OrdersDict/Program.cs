/*
Beer 2,40 350
Water 1,25 200
IceTea 5,20 100
Beer 1,20 200
IceTea 0,50 120
buy
 */
using System;
using System.Collections.Generic;

namespace OrdersDict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<double>>products= new Dictionary<string,List<double>>();
            while(true)
            {
                string[]input=Console.ReadLine().Split(' ');
                
                string product = input[0];
                if (product=="buy")
                {
                    foreach (var item in products)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value[0]* item.Value[1]:f2}");
                    }
                    break;
                }
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);
                if (products.ContainsKey(product)==false)
                {
                    products.Add(product,new List<double>() { price, quantity });
                }
                else
                {
                    products[product][0]=price;
                    products[product][1] += quantity;
                }
            }
        }
    }
}
