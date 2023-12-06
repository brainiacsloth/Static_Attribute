using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Attribute
{
    internal class Song
    {
        public string Title { get; }
        public string Artists { get; }
        public int Duration { get; }

        private static int songCount = 0;

        public Song(string title, string artists, int duration)
        {
            Title = title;
            Artists = artists;
            Duration = duration;
            songCount++;
        }
    }
}
