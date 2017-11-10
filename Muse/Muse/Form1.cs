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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            InitilizeSongDB(controller);
            foreach(Song s in controller.songList)
            {
                Console.WriteLine(s.getName() + "|" + s.getArtist() + "|" + s.getSongLength() + "|" + s.getSongYear());
            }
        }

        private void InitilizeSongDB(Controller controller)
        {
            string[] TextDB = System.IO.File.ReadAllLines("../../song_sample.txt");
            for (int i = 0; i < TextDB.Length; i += 4)
            {
                Song s = new Song(controller.songList.Count, TextDB[i], TextDB[i + 1], TextDB[i + 2], TextDB[i + 3]);
                controller.songList.Add(s);

            }
        }


    }
}
