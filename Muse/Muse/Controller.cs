using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse
{
    public class Controller
    {
        public List<User> userList;
        public List<Song> songList;
        public List<SongRating> ratingList;

        public Controller()
        {
            userList = new List<User>();
            songList = new List<Song>();
            ratingList = new List<SongRating>();
        }

        //Retrieves the song object for a song with id songID
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

        //Lets a user (userID) input a rating (rating) for a song (songID)
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

        //Retrieves list of songs a specific user (userID) has rated and their ratings
        public List<SongRating> getUsersRatings(int userID)
        {
            List<SongRating> usersRatings = new List<SongRating>();
            foreach (SongRating r in ratingList)
            {
                if (r.getUserID() == userID)
                {
                    usersRatings.Add(r);
                }
            }
            return usersRatings;
        }

    }
}

