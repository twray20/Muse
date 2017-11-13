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
            descriptors = new List<SongDescriptor>();
        }

        public Song(int songID, String songName, String artist, String songLength, String songYear)
        {
            this.songID = songID;
            this.songName = songName;
            this.artist = artist;
            this.songLength = songLength;
            this.songYear = songYear;
            descriptors = new List<SongDescriptor>();
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

        public void addDescriptor(Genre k)
        {
            foreach (SongDescriptor d in descriptors)
            {
                if (d.getGenre().getGenreName() == k.getGenreName())
                {
                    d.approveSong();
                }
            }
            SongDescriptor newDescriptor = new SongDescriptor(this.songID, k);
            descriptors.Add(newDescriptor);
        }

    }
}
