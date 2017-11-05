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
        private int numRatings;         //How many people have rated the song
        private int avgRating;          //Average total rating of the song

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

        public int getNumRatings()
        {
            return numRatings;
        }

        public int getAvgRating()
        {
            return avgRating;
        }

        public void setAvgRating(int newAvg)
        {
            this.avgRating = newAvg;
        }

        public void setNumRatings(int newNum)
        {
            this.numRatings = newNum;
        }



    }
}
