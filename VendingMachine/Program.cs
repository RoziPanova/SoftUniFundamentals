using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double accumulatedCoins = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Start")
                {

                    while (true)
                    {
                        string item = Console.ReadLine();
                        if (item == "Nuts")
                        {
                            if (accumulatedCoins < 2.0)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            else
                            {
                                accumulatedCoins -= 2.0;
                                Console.WriteLine("Purchased nuts");
                            }
                        }
                        else if (item == "Water")
                        {
                            if (accumulatedCoins < 0.7)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            else
                            {
                                accumulatedCoins -= 0.7;
                                Console.WriteLine("Purchased water");
                            }
                        }
                        else if (item == "Crisps")
                        {
                            if (accumulatedCoins < 1.5)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            else
                            {
                                accumulatedCoins -= 1.5;
                                Console.WriteLine("Purchased crisps");
                            }
                        }
                        else if (item == "Soda")
                        {
                            if (accumulatedCoins < 0.8)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            else
                            {
                                accumulatedCoins -= 0.8;
                                Console.WriteLine("Purchased soda");
                            }
                        }
                        else if (item == "Coke")
                        {
                            if (accumulatedCoins < 1.0)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            else
                            {
                                accumulatedCoins -= 1.0;
                                Console.WriteLine("Purchased coke");
                            }
                        }
                        else if (item == "End")
                        {
                            Console.WriteLine($"Change: {accumulatedCoins:f2}");
                            input = "End";
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid product");
                        }

                    }
                }
                if (input != "0.1" && input != "0.2" && input != "0.5" && input != "1" && input != "2" && input != "Start" && input != "End")
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                else if (input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2")
                {
                    accumulatedCoins += double.Parse(input);
                }
                if (input=="End")
                {
                    break;
                }
            }
        }
    }
}
