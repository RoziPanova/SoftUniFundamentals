using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = "";
            for (int i = user.Length - 1; i >= 0; i--)
            {
                pass = pass + user[i];
            }
            int count = 0;
            while (true)
            {
                string login = Console.ReadLine();
                if (login == pass)
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
                else
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine($"User {user} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }
        }
    }
}
