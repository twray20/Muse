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
            InitializeSongDB();
            InitializeRatings();
            controller.getNewSong(0);
        }

        private void InitializeSongDB()
        {
            string[] TextDB = System.IO.File.ReadAllLines("../../song_sample.txt");
            for (int i = 0; i < TextDB.Length; i += 4)
            {
                Song s = new Song(controller.songList.Count, TextDB[i], TextDB[i + 1], TextDB[i + 2], TextDB[i + 3]);
                controller.songList.Add(s);
            }

            controller.songList[0].addDescriptor(controller.genreList[5]);
            controller.songList[1].addDescriptor(controller.genreList[5]);
            controller.songList[2].addDescriptor(controller.genreList[5]);
            controller.songList[3].addDescriptor(controller.genreList[5]);
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
            controller.changeRating(0, 0, 4);
            controller.changeRating(0, 1, 4);
            controller.changeRating(0, 2, 5);
            controller.changeRating(0, 3, 5);
            controller.changeRating(1, 2, 1);
            controller.changeRating(2, 2, 2);
            controller.changeRating(3, 2, 3);
            controller.changeRating(4, 2, 4);
            controller.changeRating(0, 3, 1);
        }
    }
}
