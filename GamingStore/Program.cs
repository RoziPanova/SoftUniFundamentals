using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double total = 0;
            while (true)
            {
                string game = Console.ReadLine();
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                if (game == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${total:f2}. Remaining: ${balance:f2}");
                    break;
                }
                if (game != "OutFall 4" && game != "CS: OG" && game != "Zplinter Zell" && game != "Honored 2" && game != "RoverWatch" && game != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                }
                else if (game == "OutFall 4")
                {
                    if (balance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought OutFall 4");
                        balance -= 39.99;
                        total += 39.99;
                    }
                }
                else if (game == "CS: OG")
                {
                    if (balance < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought CS: OG");
                        balance -= 15.99;
                        total += 15.99;
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    if (balance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                        balance -= 19.99;
                        total += 19.99;
                    }
                }
                else if (game == "Honored 2")
                {
                    if (balance < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought Honored 2");
                        balance -= 59.99;
                        total += 59.99;
                    }
                }
                else if (game == "RoverWatch")
                {
                    if (balance < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought RoverWatch");
                        balance -= 29.99;
                        total += 29.99;
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (balance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        balance -= 39.99;
                        total += 39.99;
                    }
                }
            }
        }
    }
}
