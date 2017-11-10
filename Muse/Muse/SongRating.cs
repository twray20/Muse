using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse
{
    public class SongRating
    {
        private int userID;
        private int songID;
        private int rating;

        public SongRating(int uID, int sID, int r)
        {
            this.userID = uID;
            this.songID = sID;
            this.rating = r;
        }

        public int getUserID()
        {
            return userID;
        }

        public int getSongID()
        {
            return songID;
        }

        public int getRating()
        {
            return rating;
        }

        public void updateRating(int newRating)
        {
            this.rating = newRating;
        }
    }
}
