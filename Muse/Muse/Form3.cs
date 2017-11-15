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
    public partial class Form3 : Form
    {

        List<string> songs = new List<string>();

        private Controller controller;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Controller c)
        {
            controller = c;
            InitializeComponent();

            songs.Add("One");
            songs.Add("Two");
            songs.Add("Three");

            songList.DataSource = songs;
        }
    }
}
