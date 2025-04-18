using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Box : Item
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double Price4Box { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> list = new List<Box>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "end")
                {
                    var sorted=list.OrderByDescending(x => x.Price4Box).ToList();
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine($"{sorted[i].SerialNumber}");
                        Console.WriteLine($"-- {sorted[i].Name} - ${sorted[i].Price:f2}: {sorted[i].ItemQuantity}");
                        Console.WriteLine($"-- ${sorted[i].Price4Box:f2}");
                    }
                    break;
                }
                Box box = new Box();
                box.Name = input[1];
                box.Price = double.Parse(input[3]);
                box.ItemQuantity = int.Parse(input[2]);
                box.SerialNumber = input[0];
                box.Price4Box=box.Price*box.ItemQuantity;
                list.Add(box);
            }
        }
    }
}
