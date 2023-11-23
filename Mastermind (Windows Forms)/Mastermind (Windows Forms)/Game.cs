using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind__Windows_Forms_
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void availableColor1_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
