using System;

namespace Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();
            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ');
                if (commands[0] == "Abracadabra")
                {
                    break;
                }
                if (commands[0] == "Abjuration")
                {
                    spell = spell.ToUpper();
                    Console.WriteLine(spell);
                }
                else if (commands[0] == "Necromancy")
                {
                    spell = spell.ToLower();
                    Console.WriteLine(spell);
                }
                else if (commands[0] == "Illusion")
                {
                    int index = int.Parse(commands[1]);
                    if (index < 0 || index > spell.Length - 1)
                    {
                        Console.WriteLine("The spell was too weak.");
                        continue;
                    }
                    string newLetter = commands[2];
                    spell=spell.Remove(index,1);
                    spell=spell.Insert(index,newLetter);
                    Console.WriteLine("Done!");
                }
                else if (commands[0] == "Divination")
                {
                    string firstSub = commands[1];
                    string secondSub = commands[2];
                    if (spell.Contains(firstSub))
                    {
                        while (spell.Contains(firstSub))
                        {
                            spell = spell.Replace(firstSub, secondSub);
                        }
                        Console.WriteLine(spell);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commands[0] == "Alteration")
                {
                    string substr = commands[1];
                    if (spell.Contains(substr))
                    {
                        spell=spell.Remove(spell.IndexOf(substr),substr.Length);
                        Console.WriteLine(spell);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
            }
        }
    }
}