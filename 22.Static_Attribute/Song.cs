using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Attribute
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;

        public static int songCount = 0;

        public Song(string atitle, string aArtist, int aduration)
        {
            this.title = atitle;
            this.artist = aArtist;
            this.duration = aduration;
            songCount++;
        }
    }
}
