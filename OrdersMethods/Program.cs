using System;

namespace OrdersMethods
{
    internal class Program
    {
        static void Order(string order,int count)
        {
            if (order=="coffee")
            {
                Console.WriteLine($"{1.50*count:f2}");
            }
            else if (order=="water")
            {
                Console.WriteLine($"{1.00*count:f2}");
            }
            else if (order == "coke")
            {
                Console.WriteLine($"{1.40 * count:f2}");
            }
            else if (order == "snacks")
            {
                Console.WriteLine($"{2.00 * count:f2}");
            }
        }
        static void Main(string[] args)
        {
            string order=Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Order(order,count);
        }
    }
}
