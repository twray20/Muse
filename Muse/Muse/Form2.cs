﻿using System;
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
    public partial class Form2 : Form
    {

        private Controller controller;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Controller c)
        {
            controller = c;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();

            ProfileLabel.Text = controller.userList[controller.userList.Count - 1].getUserName();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            DateLabel.Text = DateTime.Now.ToLongDateString();

            RandomSongLabel.Text = "Light My Fire - The Doors";

            List<SongRating> loadedRatingList = controller.ratingList;
            int ratingsCount = 0;
            foreach (SongRating s in loadedRatingList){
                if (s.getUserID() == controller.userList.Count - 1){
                    ratingsCount += 1;
                }
            }
            SongsRatedLabel.Text = "Songs Rated: " + ratingsCount;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void RandomSongLabel_TextChanged(object sender, EventArgs e)
        {
            if (RandomSongLabel.Right > this.Width)
            {
                RandomSongLabel.Left = this.Width - RandomSongLabel.Width;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RateSongsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3(controller);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void SomethingLikedButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4(controller, 0);
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void SomethingNewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4(controller, 1);
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
