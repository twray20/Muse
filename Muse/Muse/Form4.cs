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

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(Controller c)
        {
            controller = c;
            InitializeComponent();
        }
    }
}
