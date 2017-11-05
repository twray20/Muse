using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse
{
    class Global
    {
        public Song[] songList;

        public Song getSong(int songID)
        {
            foreach(Song song in songList)
            {
                if (songID == song.getID())
                {
                    return song;
                }
            }
            return new Song();
        }

        public void changeRating(int songID, int rating)
        {
            Song song = getSong(songID);
            int newNum, newAvg;
            newNum = song.getNumRatings();
            newAvg = song.getAvgRating();
            newAvg = ((newAvg * newNum) + rating) / (newNum + 1);
            song.setAvgRating(newAvg);
            song.setNumRatings(newNum + 1);
        }
    }
}
