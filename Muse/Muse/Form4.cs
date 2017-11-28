using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muse
{
    public partial class Form4 : Form
    {

        private Controller controller;
        private int choice;

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(Controller c, int which)
        {
            controller = c;
            choice = which;

            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (SongRating r in controller.ratingList)
            {
                if (r.getUserID() == controller.userList.Count - 1)
                {
                    Console.WriteLine(controller.songList[r.getSongID()].getName() + " - " + r.getRating());
                }
            }
            if (choice == 0)
            {
                Song likedSong = controller.getRecommendation(controller.userList.Count - 1);
                label1.Text = likedSong.getName() + " - " + likedSong.getArtist();
                label2.Text = "Here's something you might like!";
            }
            else if (choice == 1)
            {
                Song newSong = controller.getNewSong(controller.userList.Count - 1);
                label1.Text = newSong.getName() + " - " + newSong.getArtist();
                label2.Text = "Here's something new!";
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2(controller);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
