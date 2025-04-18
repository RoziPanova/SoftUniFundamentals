using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            while (true)
            {
                string[] commands = Console.ReadLine().Split(":|:");
                if (commands[0] == "Reveal")
                {
                    Console.WriteLine($"You have a new text message: {message}");
                    break;
                }
                else if (commands[0] == "InsertSpace")
                {
                    message = message.Insert(int.Parse(commands[1]), " ");
                    Console.WriteLine(message);
                }
                else if (commands[0] == "Reverse")
                {
                    if (message.Contains(commands[1]))
                    {
                        message = message.Replace(commands[1], "");
                        var reversed = commands[1].Reverse().ToList();
                        message = message.Insert(message.Length, string.Join("", reversed));
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commands[0] == "ChangeAll")
                {
                    while (message.Contains(commands[1]))
                    {
                        message = message.Replace(commands[1], commands[2]);
                        
                    }
                    Console.WriteLine(message);
                }
            }
        }
    }
}
