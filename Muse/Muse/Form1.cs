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

            Controller c = new Controller();
            User u = new User(0, UsernameBox.Text);
            c.userList.Add(u);

            this.Hide();
            var form2 = new Form2(c);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
