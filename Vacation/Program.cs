using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double total = 0;
            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else
                {
                    price = 10.46;
                }
            }
            if (type == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else
                {
                    price = 16;
                }
            }
            if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else
                {
                    price = 22.50;
                }
            }
            total = price * peopleCount;
            if (peopleCount >= 30 && type == "Students")
            {
                total -= total * 0.15;
            }
            if (peopleCount >= 100 && type == "Business")
            {
                total -= price * 10;
            }
            if (peopleCount >= 10 && peopleCount <= 20 && type == "Regular")
            {
                total -= total * 0.05;
            }
            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
