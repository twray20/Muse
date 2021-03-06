﻿using System;
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
        public List<Genre> genreList;

        public Controller()
        {
            userList = new List<User>();
            songList = new List<Song>();
            ratingList = new List<SongRating>();
            genreList = new List<Genre>();
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
                if (userID == r.getUserID() && songID == r.getSongID())
                {
                    r.updateRating(rating);
                    return;
                }
            }
            SongRating newRating = new SongRating(userID, songID, rating);
            ratingList.Add(newRating);
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

        public int getAvgSongRating(int songID)
        {
            int count = 0;
            int sum = 0;
            foreach (SongRating r in ratingList)
            {
                if (r.getSongID() == songID)
                {
                    sum += r.getRating();
                    count++;
                }
            }
            return sum / count;
        }

        public Song getSongWithName(String name)
        {
            foreach (Song s in songList)
            {
                if (s.getName() == name)
                    return s;
            }
            return null;
        }

        //Retrieves list of songs that have been defined as having genre (genre)
        public List<Song> getSongsWithGenre(String genre)
        {
            List<Song> songsWithGenre = new List<Song>();

            foreach (Song s in songList)
            {
                List<SongDescriptor> descriptors = s.getDescriptors();
                foreach (SongDescriptor d in descriptors)
                {
                    if (d.getGenre().getGenreName() == genre)
                    {
                        //if (d.getApprovals() > x) where x is number of approvals before song is considered to belong to a genre
                        songsWithGenre.Add(s);
                    }
                }
            }

            return songsWithGenre;
        }

        //Gets a song from a genre the user has not rated before
        public Song getNewSong(int userID)
        {
            //Finds list of genres that user (userID) has listened to
            List<Genre> listenedTo = new List<Genre>();
            foreach (SongRating s in ratingList)
            {
                if (s.getUserID() == userID)
                {
                    List<SongDescriptor> desc = songList[s.getSongID()].getDescriptors();
                    foreach (SongDescriptor d in desc)
                    {
                        if (!listenedTo.Contains(d.getGenre()))
                        {
                            listenedTo.Add(d.getGenre());
                        }
                    }
                }
            }

            //Finds list of songs that do not have any genres that user (userID) has listened to
            List<Song> newSongs = new List<Song>();
            Boolean contained = false;
            foreach (Song s in songList)
            {
                foreach (SongDescriptor d in s.getDescriptors())
                {
                    foreach (Genre k in listenedTo)
                    {
                        if (d.getGenre() == k)
                            contained = true;

                    }
                }
                if (!contained)
                {
                    newSongs.Add(s);
                }
                contained = false;
            }

            //Return a random song from the songs found
            Random random = new Random();
            int randomNumber = random.Next(0, newSongs.Count);

            Console.WriteLine("Here's something new: " + newSongs[randomNumber].getName() + " by " + newSongs[randomNumber].getArtist());

            return newSongs[randomNumber];
        }

        public Song getRecommendation(int userID)
        {
            Song recommendation = new Song();

            List<double> avgGenreRatings = new List<double>();
            foreach (Genre g in genreList)
            {
                avgGenreRatings.Add(getAverageGenreRating(userID, g.getGenreName()));
            }
            //OUTPUTS AVERAGE GENRE RATING FOR EACH GENRE
            //int i = 0;
            //foreach(double d in avgGenreRatings)
            //{                
            //    Console.WriteLine("Genre: " + genreList[i].getGenreName() + "|" + "Rating: " + d);
            //    i++;
            //}

            List<double> errorMargins = new List<double>();

            foreach (User u in userList)
            {
                if (u.getID() == userID)
                {
                    errorMargins.Add(double.MaxValue);
                    continue;
                }

                double sum = 0;
                bool firstAdd = false;

                for (int i = 0; i < avgGenreRatings.Count; i++)
                {
                    double compareValue = getAverageGenreRating(u.getID(), genreList[i].getGenreName());
                    if (avgGenreRatings[i] == 0 || compareValue == 0)
                    {
                        continue;
                    }
                    firstAdd = true;
                    sum += Math.Abs(avgGenreRatings[i] - compareValue);
                }
                if (firstAdd)
                {
                    errorMargins.Add(sum);
                }
                else
                {
                    errorMargins.Add(double.MaxValue);
                }
            }

            List<int> songsHeard = new List<int>();
            for (int i = 0; i < ratingList.Count; i++)
            {
                if (ratingList[i].getUserID() == userID)
                {
                    songsHeard.Add(i);
                }
            }

            while (true)
            {

                int similarUserID = -1;
                for (int i = 0; i < errorMargins.Count; i++)
                {
                    if (errorMargins[i] == errorMargins.Min())
                    {
                        similarUserID = i;
                        break;
                    }
                }

                if (similarUserID == -1)
                {
                    return new Song();
                }

                int maxRating = 0;
                foreach (SongRating rating in ratingList)
                {
                    if (rating.getUserID() == similarUserID)
                    {
                        if (rating.getRating() > maxRating)
                        {
                            maxRating = rating.getRating();
                        }
                    }
                }

                List<int> possibleRecommendations = new List<int>();
                foreach (SongRating rating in ratingList)
                {
                    if (rating.getUserID() == similarUserID)
                    {
                        if (rating.getRating() == maxRating && !songsHeard.Contains(rating.getSongID()))
                        {
                            possibleRecommendations.Add(rating.getSongID());
                        }
                    }
                }
                if (possibleRecommendations.Count > 0)
                {
                    Random r = new Random();
                    int selection = r.Next(0, possibleRecommendations.Count);
                    return songList[possibleRecommendations[selection]];
                }
                else
                {
                    errorMargins[similarUserID] = double.MaxValue;
                }
            }
        }


        public double getAverageGenreRating(int userID, String g)
        {
            double count = 0;
            double sum = 0;
            foreach (SongRating r in ratingList)
            {
                String songGenre = songList[r.getSongID()].getDescriptors()[0].getGenre().getGenreName();
                if (r.getUserID() == userID && songGenre == g)
                {
                    sum += r.getRating();
                    count++;
                }
            }
            if (count > 0)
            {
                return sum / count;
            }
            else return 0;
        }
    }
}

