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
    public partial class MuseLogin : Form
    {

        private Controller controller;

        public MuseLogin()
        {
            InitializeComponent();
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            User u = new User(0, UsernameBox.Text);
            controller.userList.Add(u);

            this.Hide();
            var form2 = new Form2(controller);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller = new Controller();
            InitializeUsers();
            InitializeGenres();
            InitializeSongDB();
            InitializeRatings();
        }

        private void InitializeSongDB()
        {
            string[] TextDB = System.IO.File.ReadAllLines("../../song_sample.txt");
            for (int i = 0; i < TextDB.Length; i += 4)
            {
                int id = controller.songList.Count;
                Song s = new Song(id, TextDB[i], TextDB[i + 1], TextDB[i + 2], TextDB[i + 3]);
                controller.songList.Add(s);
            }

            controller.songList[0].addDescriptor(controller.genreList[5]);
            controller.songList[1].addDescriptor(controller.genreList[5]);
            controller.songList[2].addDescriptor(controller.genreList[5]);
            controller.songList[3].addDescriptor(controller.genreList[5]);
            controller.songList[4].addDescriptor(controller.genreList[2]);
            controller.songList[5].addDescriptor(controller.genreList[2]);
            controller.songList[6].addDescriptor(controller.genreList[2]);
            controller.songList[7].addDescriptor(controller.genreList[2]);
            controller.songList[8].addDescriptor(controller.genreList[0]);
            controller.songList[9].addDescriptor(controller.genreList[0]);
            controller.songList[10].addDescriptor(controller.genreList[0]);
            controller.songList[11].addDescriptor(controller.genreList[0]);
            controller.songList[12].addDescriptor(controller.genreList[4]);
            controller.songList[13].addDescriptor(controller.genreList[4]);
            controller.songList[14].addDescriptor(controller.genreList[4]);
            controller.songList[15].addDescriptor(controller.genreList[4]);
            controller.songList[16].addDescriptor(controller.genreList[1]);
            controller.songList[17].addDescriptor(controller.genreList[1]);
            controller.songList[18].addDescriptor(controller.genreList[1]);
            controller.songList[19].addDescriptor(controller.genreList[1]);
            controller.songList[20].addDescriptor(controller.genreList[3]);
            controller.songList[21].addDescriptor(controller.genreList[3]);
            controller.songList[22].addDescriptor(controller.genreList[3]);
            controller.songList[23].addDescriptor(controller.genreList[3]);

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
            controller.genreList.Add(new Genre("Jazz"));
            controller.genreList.Add(new Genre("Progressive Rock"));
            controller.genreList.Add(new Genre("New wave"));
            controller.genreList.Add(new Genre("Pop"));
            controller.genreList.Add(new Genre("Electronic"));
            controller.genreList.Add(new Genre("Hip hop"));
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
