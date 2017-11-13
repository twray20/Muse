using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Muse
{
    public partial class Form1 : Form
    {
        private Controller controller;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller = new Controller();
            InitializeUsers();
            InitializeGenres();
            InitilizeSongDB();
            foreach(Song s in controller.songList)
            {
                Console.WriteLine(s.getName() + "|" + s.getArtist() + "|" + s.getSongLength() + "|" + s.getSongYear());
            }
        }

        private void InitilizeSongDB()
        {
            string[] TextDB = System.IO.File.ReadAllLines("../../song_sample.txt");
            for (int i = 0; i < TextDB.Length; i += 4)
            {
                Song s = new Song(controller.songList.Count, TextDB[i], TextDB[i + 1], TextDB[i + 2], TextDB[i + 3]);
                controller.songList.Add(s);

            }
        }

        //Create some user accounts and initialize them for use in project
        private void InitializeUsers()
        {
            User newUser = new User(controller.userList.Count, "Admin");
            controller.userList.Add(newUser);
            newUser = new User(controller.userList.Count, "Thomas");
            controller.userList.Add(newUser);
            newUser = new User(controller.userList.Count, "Willis");
            controller.userList.Add(newUser);
            newUser = new User(controller.userList.Count, "Hunter");
            controller.userList.Add(newUser);
            newUser = new User(controller.userList.Count, "Andre");
            controller.userList.Add(newUser);
        }

        //Create list of genres and initialize them for use in project
        private void InitializeGenres()
        {           
            controller.genreList.Add(new Keyword("Jazz"));
            controller.genreList.Add(new Keyword("Progressive Rock"));
            controller.genreList.Add(new Keyword("New wave"));
            controller.genreList.Add(new Keyword("Pop"));
            controller.genreList.Add(new Keyword("Electronic"));
            controller.genreList.Add(new Keyword("Hip hop"));
        }

        //Creates some song ratings for each user and initialize them for use in project
        private void InitializeRatings()
        {
            controller.changeRating(0, 0, 3);
            controller.changeRating(0, 3, 4);
            controller.changeRating(0, 5, 1);
            controller.changeRating(0, 6, 5);
            controller.changeRating(0, 9, 2);
            controller.changeRating(0, 11, 3);
            controller.changeRating(0, 16, 4);
            controller.changeRating(0, 18, 1);
            controller.changeRating(0, 21, 3);
            controller.changeRating(0, 23, 4);

            controller.changeRating(1, 1, 4);
            controller.changeRating(1, 2, 3);
            controller.changeRating(1, 4, 3);
            controller.changeRating(1, 7, 4);
            controller.changeRating(1, 8, 2);
            controller.changeRating(1, 10, 5);
            controller.changeRating(1, 13, 1);
            controller.changeRating(1, 15, 1);
            controller.changeRating(1, 17, 2);
            controller.changeRating(1, 19, 5);
            controller.changeRating(1, 22, 4);
            controller.changeRating(1, 23, 3);
            
            controller.changeRating(2, 1, 4);
            controller.changeRating(2, 2, 1);
            controller.changeRating(2, 4, 4);
            controller.changeRating(2, 5, 2);
            controller.changeRating(2, 8, 3);
            controller.changeRating(2, 10, 4);
            controller.changeRating(2, 11, 4);
            controller.changeRating(2, 13, 4);
            controller.changeRating(2, 14, 5);
            controller.changeRating(2, 16, 4);
            controller.changeRating(2, 17, 1);
            controller.changeRating(2, 20, 1);
            controller.changeRating(2, 22, 1);
            
            controller.changeRating(3, 2, 4);
            controller.changeRating(3, 3, 2);
            controller.changeRating(3, 4, 4);
            controller.changeRating(3, 7, 4);
            controller.changeRating(3, 10, 3);
            controller.changeRating(3, 11, 5);
            controller.changeRating(3, 12, 4);
            controller.changeRating(3, 15, 3);
            controller.changeRating(3, 16, 4);
            controller.changeRating(3, 19, 5);
            controller.changeRating(3, 22, 5);
            controller.changeRating(3, 23, 2);
            
            controller.changeRating(4, 1, 1);
            controller.changeRating(4, 2, 1);
            controller.changeRating(4, 4, 1);
            controller.changeRating(4, 5, 4);
            controller.changeRating(4, 9, 4);
            controller.changeRating(4, 10, 1);
            controller.changeRating(4, 12, 4);
            controller.changeRating(4, 14, 1);
            controller.changeRating(4, 17, 4);
            controller.changeRating(4, 18, 1);
            controller.changeRating(4, 21, 4);
            controller.changeRating(4, 22, 1);
            

        }
    }
}
