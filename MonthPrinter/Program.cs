using System;

namespace MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months =new string[]{ "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int number = int.Parse(Console.ReadLine());
            if (number<1||number>12)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(months[number-1]);
            }
        }
    }
}
