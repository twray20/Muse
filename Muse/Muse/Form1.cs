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
    public partial class Form1 : Form
    {
        private Controller controller;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller = new Controller();
            InitializeUsers();
            InitializeGenres();
            foreach(Keyword k in controller.genreList)
            {
                Console.WriteLine(k.getKeyName());
            }
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
            controller.genreList.Add(new Keyword("Jazz"));
            controller.genreList.Add(new Keyword("Progressive Rock"));
            controller.genreList.Add(new Keyword("New wave"));
            controller.genreList.Add(new Keyword("Pop"));
            controller.genreList.Add(new Keyword("Electronic"));
            controller.genreList.Add(new Keyword("Hip hop"));
        }

        //Creates some song ratings for each user and initialize them for use in project
        private void InitializeRatings()
        {

        }
    }
}
