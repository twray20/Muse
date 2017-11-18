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
    public partial class Form3 : Form
    {

        List<string> songs = new List<string>();

        private Controller controller;

        private bool changedProgramatically = false;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Controller c)
        {
            controller = c;
            InitializeComponent();
            
            foreach (Song s in controller.songList)
            {
                songs.Add(s.getName() + " - " + s.getArtist());
            }
            songRatingList.DataSource = songs;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !changedProgramatically)
            {
                Console.WriteLine("...");
                controller.changeRating(controller.userList.Count - 1, songRatingList.SelectedIndex, 1);
                Console.WriteLine(controller.ratingList[songRatingList.SelectedIndex].getRating());
            }
            else
            {
                changedProgramatically = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked && !changedProgramatically)
            {
                controller.changeRating(controller.userList.Count - 1, songRatingList.SelectedIndex, 2);
                Console.WriteLine(controller.ratingList[songRatingList.SelectedIndex].getRating());
            }
            else
            {
                changedProgramatically = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked && !changedProgramatically)
            {
                controller.changeRating(controller.userList.Count - 1, songRatingList.SelectedIndex, 3);
                Console.WriteLine(controller.ratingList[songRatingList.SelectedIndex].getRating());
            }
            else
            {
                changedProgramatically = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked && !changedProgramatically)
            {
                controller.changeRating(controller.userList.Count - 1, songRatingList.SelectedIndex, 4);
                Console.WriteLine(controller.ratingList[songRatingList.SelectedIndex].getRating());
            }
            else
            {
                changedProgramatically = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked && !changedProgramatically)
            {
                controller.changeRating(controller.userList.Count - 1, songRatingList.SelectedIndex, 5);
                Console.WriteLine(controller.ratingList[songRatingList.SelectedIndex].getRating());
            }
            else
            {
                changedProgramatically = false;
            }
        }

        private void songRatingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controller.ratingList[songRatingList.SelectedIndex].getRating() == 0)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
            }
            else
            {
                switch (controller.ratingList[songRatingList.SelectedIndex].getRating())
                {
                    case 1:
                        changedProgramatically = true;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        break;

                    case 2:
                        changedProgramatically = true;
                        radioButton1.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        break;

                    case 3:
                        changedProgramatically = true;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        break;

                    case 4:
                        changedProgramatically = true;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton5.Checked = false;
                        break;

                    case 5:
                        changedProgramatically = true;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        break;
                }
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
