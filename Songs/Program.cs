using System;
using System.Collections.Generic;

namespace Songs
{
    internal class Program
    {
        class Songs
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Songs> songList = new List<Songs>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('_');
                Songs song = new Songs();
                song.TypeList = input[0];
                song.Name = input[1];
                song.Time = input[2];
                songList.Add(song);
            }
            string listType = Console.ReadLine();
            if (listType == "all")
            {
                for (int i = 0; i < songList.Count; i++)
                {
                    Console.WriteLine(songList[i].Name);
                }
            }
            else
            {
                for (int i = 0; i < songList.Count; i++)
                {
                    if (songList[i].TypeList == listType)
                    {
                        Console.WriteLine(songList[i].Name);
                    }
                }
            }
        }
    }
}
