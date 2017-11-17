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

        }
    }
}
