using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse
{
    public class Song
    {
        private int songID;     //Unique song ID to identify the song and retrieve information about it
        private String songName;
        private String artist;
        private String songLength;
        private String songYear;
        private List<SongDescriptor> descriptors;

        public Song()
        {
            songID = -1;
        }

        public Song(int sID, String songName, String artist, String songLength, String songYear)
        {
           // this.songID = sID;
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

        public String getSongLength()
        {
            return songLength;
        }

        public String getSongYear()
        {
            return songYear;
        }

        public List<SongDescriptor> getDescriptors()
        {
            return descriptors;
        }

    }
}
