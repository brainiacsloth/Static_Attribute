using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            DisplaySongInfo(holiday);
            DisplaySongInfo(kashmir);

            Console.ReadLine();
        }

        static void DisplaySongInfo(Song song)
        {
            Console.WriteLine($"Title: {song.Title}\nArtists: {song.Artists}\nDuration: {song.Duration} seconds\n");
        }
    }
}