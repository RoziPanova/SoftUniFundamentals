using System;

namespace EnglishNameoftheLastDigit
{
    class Program
    {
        static void Spelling(string last)
        {
            last = last[last.Length - 1].ToString();
             if (last == "1")
            {
                Console.WriteLine("one");
            }
            else if (last=="2")
            {
                Console.WriteLine("two");
            }
            else if (last=="3")
            {
                Console.WriteLine("three");
            }
            else if (last == "4")
            {
                Console.WriteLine("four");
            }
            else if (last == "5")
            {
                Console.WriteLine("five");
            }
            else if (last == "6")
            {
                Console.WriteLine("six");
            }
            else if (last == "7")
            {
                Console.WriteLine("seven");
            }
            else if (last == "8")
            {
                Console.WriteLine("eight");
            }
            else if (last == "9")
            {
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Spelling(number);
        }
    }
}
