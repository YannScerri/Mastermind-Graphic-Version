﻿using System;
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
    public partial class Rules : Form
    {
        Menu mainMenu;
        public Rules(Menu menu)
        {
            InitializeComponent();
            mainMenu = menu;
        }
        /// <summary>
        /// bouton retour au menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            //cacher les règles et revenir au menu
            this.Hide();
            mainMenu.Show();
        }
    }
}
         
            

