using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Articles
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

            public void Edit(string newContent)
            {
                Content = newContent;
            }
            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }
            public void Rename(string newTitle)
            {
                Title = newTitle;
            }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Artical artical = new Artical(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(':');
                if (commands[0] == "Edit")
                {
                    artical.Edit(commands[1].Trim());
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    artical.ChangeAuthor(commands[1].Trim());
                }
                else if (commands[0] == "Rename")
                {
                    artical.Rename(commands[1].Trim());
                }
            }
            Console.WriteLine(artical.ToString());
        }
    }
}
