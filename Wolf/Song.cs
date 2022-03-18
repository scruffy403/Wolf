﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolf
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        public int getSongCount()
        {
            // this allows the objects to acces the static attribute songCount
            return songCount;
        }
    }
}
