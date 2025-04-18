/*
Lewis 123456 20
James 78911 15
Robert 523444 11
Jennifer 345244 13
Mary 52424678 22
Patricia 567343 54
End
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderbyAge
{
    internal class Program
    {
        class People
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }
            public People(string name,string id,int age) { 
                this.Name = name;
                this.Id = id;
                this.Age = age;
            }
        }
        static void Main(string[] args)
        {
           List<People> list = new List<People>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (input[0] == "End")
                {
                    break;
                }
                bool ContaintsID = list.Any(x => x.Id == input[1]);
                if (ContaintsID==false)
                {
                    People people = new People(input[0], input[1], int.Parse(input[2]));
                    list.Add(people);
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].Id == input[1])
                        {
                            list[i].Name = input[0];
                            list[i].Age = int.Parse(input[2]);
                        }
                    }
                }
            }
            list=list.OrderBy(x=>x.Age).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{list[i].Name} with ID: {list[i].Id} is {list[i].Age} years old.");
            }
        }
    }
}
