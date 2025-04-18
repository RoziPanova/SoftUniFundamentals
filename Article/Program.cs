using System;
using System.Collections.Generic;

namespace Article
{
    internal class Program
    {
        class Artical
        {
            public Artical(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
            static void Main(string[] args)
            {
                List<Artical> articals = new List<Artical>();
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split(", ");
                    Artical artical = new Artical(input[0], input[1], input[2]);
                    articals.Add(artical);
                }
                for (int i = 0; i < articals.Count; i++)
                {
                    Console.WriteLine(articals[i].ToString());
                }
            }
        }
    }
}

