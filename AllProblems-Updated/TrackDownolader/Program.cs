using System;
using System.Collections.Generic;

namespace TrackDownolader
{
    class Program
    {
        static void Main()
        {
            string[] bannedSongs = Console.ReadLine()?.Split(' ');
            string song = Console.ReadLine();
            List<string> playlist = new List<string>();

            while (song != "end")
            {
                bool isContained = false;
                for (int i = 0; i < bannedSongs.Length; i++)
                {
                    if (song.Contains(bannedSongs[i]))
                    {
                        isContained = true;
                    }
                }
                if (!isContained)
                {
                    playlist.Add(song);
                }
                song = Console.ReadLine();
            }
            playlist.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, playlist));
        }
    }
}
