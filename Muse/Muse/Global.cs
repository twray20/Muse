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
        public SongRating[] ratingList;

        public Song getSong(int songID)
        {
            foreach (Song song in songList)
            {
                if (songID == song.getID())
                {
                    return song;
                }
            }
            return new Song();
        }

        public void changeRating(int userID, int songID, int rating)
        {

            foreach (SongRating r in ratingList)
            {
                if (userID == r.getUserID() && songID==r.getSongID())
                {
                    r.updateRating(rating);
                    return;
                }
            }

            SongRating newRating = new SongRating(userID, songID, rating);
        }

    }
}

