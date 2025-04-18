using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> parking = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string command = "";
                string user = "";
                string plate = "";
                if (input.Length == 3)
                {
                    command = input[0];
                    user = input[1];
                    plate = input[2];
                }
                else
                {
                    command = input[0];
                    user = input[1];
                }

                if (command == "register")
                {
                    if (parking.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[user]}");
                    }
                    else
                    {
                        parking.Add(user, plate);
                        Console.WriteLine($"{user} registered {plate} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (parking.ContainsKey(user) == false)
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{user} unregistered successfully");
                        parking.Remove(user);
                    }
                }
            }
            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}

