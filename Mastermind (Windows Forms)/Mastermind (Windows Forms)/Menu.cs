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


        /// <summary>
        /// Bouton quitter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {   
            //Pour quitter l'application
            Application.Exit();
        }
        /// <summary>
        /// Bouton règles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRules_Click(object sender, EventArgs e)
        {   //cacher le menu et faire apparaître les règles
            this.Hide();
            rules.Show();
        }
        /// <summary>
        /// Bouton jouer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
          private void btnPlay_Click(object sender, EventArgs e)
        {
            Game gameScreen = new Game(this);
            //cacher le menu et afficher les règles
            gameScreen.Show();
            this.Hide();
        }
    }
}  

            


        
