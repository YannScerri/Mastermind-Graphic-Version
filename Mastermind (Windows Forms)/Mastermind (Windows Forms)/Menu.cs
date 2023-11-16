using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind__Windows_Forms_
{
    public partial class Menu : Form
    {
        Rules rules;
        public Menu()
        {
            InitializeComponent();
            rules = new Rules(this);
        }

        private void lblmenu_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {   
            //Pour quitter l'application
            Application.Exit();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            this.Hide();

            rules.Show();
            

        }
    }
}
