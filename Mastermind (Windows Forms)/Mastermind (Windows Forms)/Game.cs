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
        Menu mainMenu;
        //liste, variable et tableau pour la génération aléatoire
        Button[,] btnGrid = new Button[ROWS,COLUMNS];
        const int COLUMNS = 4;
        const int ROWS = 10;
        List <Button> btnList = new List <Button> ();
        int currentButton = 0;
        Button[] selectedColors = new Button[4];
        public Game(Menu menu)
        {   
            InitializeComponent();
            CombinationCreator();
            mainMenu = menu;
        }

        
        private void availableColor1_Click(object sender, EventArgs e)
        {   
            //ajoute l'option pour tous les boutons de couleurs
            Button colorButton = (Button)sender;

            // Ajoutez les boutons à la liste
            for (int i = 1; i <= 40; i++)
            {
                // Créer le nom du bouton en fonction du schéma de nommage
                string nomBouton = $"playbtn{i}";

                // Récupérer le bouton par son nom
                Button bouton = Controls.Find(nomBouton, true).FirstOrDefault() as Button;

                // Ajouter le bouton à la liste
                if (bouton != null)
                {
                    btnList.Add(bouton);
                }
            }

            if (currentButton < 4)
            {
                //adapter la couleur
                btnList[currentButton].BackColor = colorButton.BackColor;
            }
            else
            {
                MessageBox.Show("Veuillez valider votre réponse");
            }
            //passage au bouton suivant
            currentButton++;
            
        }

        private void btnReturn2_Click(object sender, EventArgs e)
        {   
            //pour quitter l'application
            Application.Exit();
        }
        /// <summary>
        /// méthode qui créer une combinaison de couleurs aléatoires
        /// </summary>
        private void CombinationCreator()
        {   //liste de couleurs disponibles pour la génération aléatoire
            List <Color> availableColors = new List <Color>
            {
                Color.Green,
                Color.Yellow,
                Color.White,
                Color.Red,
                Color.Blue,
                Color.Magenta,
                Color.Cyan,
            
            };
            
            Random random = new Random();
            for(int i = 0; i < 4; i++)
            {
                Color randomColor = availableColors[random.Next(availableColors.Count)];
                Button btnCombination = new Button();
                btnCombination.BackColor = randomColor;
                btnCombination.Enabled = false;
                btnCombination.FlatStyle = FlatStyle.Flat;
                btnCombination.Size = new Size (50,50);
                pnlCombination.Controls.Add(btnCombination);

                selectedColors[i] = btnCombination;
            }
        }
        /// <summary>
        /// bouton afficher/cacher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHide_Click(object sender, EventArgs e)
        {   //switch la position entre visible et invisible
            pnlCombination.Visible = !pnlCombination.Visible;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Effacer les boutons existants dans pnlCombination
            pnlCombination.Controls.Clear();

            // Générer une nouvelle combinaison
            CombinationCreator();
        }
        /// <summary>
        /// Bouton menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn2_Click_1(object sender, EventArgs e)
        {   
            //cacher le jeu et revenîr au menu
            this.Hide();
            mainMenu.Show();
        }

        private void Game_Load(object sender, EventArgs e)
        {   //la combinaison secrète est par défaut cachée
            pnlCombination.Visible = false;
        }

        private void validateBtn_Click(object sender, EventArgs e)
        {
            // vérifier que le joueur a rempli 4 cases
            if (currentButton < 4)
            {
                MessageBox.Show("Veuillez sélectionner quatre couleurs avant de valider.");
                return; 
            }

            // appel de méthode et comparaison
            bool isCorrect = CheckPlayerCombination();

            // feedback
            if (isCorrect)
            {
                MessageBox.Show("Bravo le veau ! Vous avez deviné la combinaison secrète.");
                
            }
            else
            {
                MessageBox.Show("Minute papillon, la combinaison n'est pas correcte. Essayez à nouveau.");
                
            }

            // reset
             btnReset_Click(sender, e);
        }

        private bool CheckPlayerCombination()
        {
            // comparaison avec le code secret
            for (int i = 0; i < 4; i++)
            {
                if (selectedColors[i].BackColor != btnList[i].BackColor)
                {
                    return false; // si incorrect
                }
            }

            return true; //si correct
        }
    }
       
}

