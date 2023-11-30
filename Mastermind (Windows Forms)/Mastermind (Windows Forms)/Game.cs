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
    {   List <Button> btnList = new List <Button> ();
        int currentButton = 0;

        public Game()
        {
            InitializeComponent();   
        }

        private void availableColor1_Click(object sender, EventArgs e)
        {   
            //ajoute l'option pour tous les boutons de couleurs
            Button colorButton = (Button)sender;

            // Ajoutez les boutons à la liste
            for (int i = 1; i <= 40; i++)
            {
                // Créez le nom du bouton en fonction du schéma de nommage
                string nomBouton = $"playbtn{i}";

                // Récupérez le bouton par son nom en utilisant la réflexion
                Button bouton = Controls.Find(nomBouton, true).FirstOrDefault() as Button;

                // Ajoutez le bouton à la liste
                if (bouton != null)
                {
                    btnList.Add(bouton);
                }
            }

            if (currentButton < 40)
            {
                //adapter la couleur
                btnList[currentButton].BackColor = colorButton.BackColor;
            }
            else
            {
                MessageBox.Show("Stop");
            }
            //passage au bouton suivant
            currentButton++;
            
        }

        private void btnReturn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
