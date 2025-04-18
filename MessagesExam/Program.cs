using System;
using System.Collections.Generic;
using System.Linq;

namespace MessagesExam
{
    class Manager
    {
        public string Username { get; set; }
        public int Messages { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            List<Manager> list = new List<Manager>();
            while (true)
            {
                string[] input = Console.ReadLine().Split('=');
                if (input[0] == "Statistics")
                {
                    break;
                }
                if (input[0] == "Add")
                {
                    Manager manager = list.FirstOrDefault(x => x.Username == input[1]);
                    if (manager == null)
                    {
                        list.Add(new Manager
                        {
                            Username = input[1],
                            Messages = int.Parse(input[2]) + int.Parse(input[3])
                        });
                    }
                    else
                    {
                        continue;
                    }
                }
                if (input[0] == "Message")
                {
                    Manager sender = list.FirstOrDefault(x => x.Username == input[1]);
                    Manager receiver = list.FirstOrDefault(x => x.Username == input[2]);
                    if (sender != null && receiver != null)
                    {
                        sender.Messages += 1;
                        receiver.Messages += 1;
                        if (sender.Messages >= capacity)
                        {
                            list.Remove(sender);
                            Console.WriteLine($"{sender.Username} reached the capacity!");
                        }
                        if (receiver.Messages >= capacity)
                        {
                            list.Remove(receiver);
                            Console.WriteLine($"{receiver.Username} reached the capacity!");
                        }
                    }
                }
                if (input[0] == "Empty")
                {
                    if (input[1]=="All")
                    {
                        list.Clear();
                    }
                    else
                    {
                        Manager manager = list.FirstOrDefault(x => x.Username == input[1]);
                        if (manager!=null)
                        {
                            list.Remove(manager);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            Console.WriteLine($"Users count: {list.Count}");
            if (list.Count > 0)
            {
                foreach(var item in list)
                { Console.WriteLine($"{item.Username} - {item.Messages}"); }
            }
        }
    }
}

