using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse
{
    class Song
    {
        private int songID;     //Unique song ID to identify the song and retrieve information about it
        private String songName;
        private String artist;
        private int songLength;
        private int songYear;
        //private Descriptor[] descriptors;

        public Song()
        {
            songID = -1;
        }

        public Song(int sID, String songName, String artist, int songLength, int songYear)
        {
            this.songID = sID;
            this.songName = songName;
            this.artist = artist;
            this.songLength = songLength;
            this.songYear = songYear;
        }

        public int getID()
        {
            return songID;
        }

        public String getName()
        {
            return songName;
        }

        public String getArtist()
        {
            return artist;
        }

        public int getSongLength()
        {
            return songLength;
        }

        public int getSongYear()
        {
            return songYear;
        }

        //public Descriptor[] getDescriptors()
        //{
        //    return descriptors;
        //}

    }
}
