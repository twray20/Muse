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

            ProfileLabel.Text = controller.userList[0].getUserName();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            DateLabel.Text = DateTime.Now.ToLongDateString();

            RandomSongLabel.Text = "Light My Fire - The Doors";
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

            Controller c = new Controller();

            this.Hide();
            var form3 = new Form3(c);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
