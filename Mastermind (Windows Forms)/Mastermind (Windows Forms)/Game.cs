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
        //liste, variable et tableau
        int currentColumn = 0;
        int currentRow = 0;
        Label [,] lblGrid;
        Label[,] hintGrid;
        Button[] selectedColors;
        const int COLUMNS = 4;
        const int ROWS = 10;
        //List <Button> btnList = new List <Button> ();
        int clickCpt = 0;

        Color[] availableColors = new Color[]
        {
                Color.Green,
                Color.Yellow,
                Color.White,
                Color.Red,
                Color.Blue,
                Color.Magenta,
                Color.Cyan,
        };



        public Game(Menu menu)
        {   
            InitializeComponent();

            selectedColors = new Button[7];
            hintGrid = new Label[ROWS, COLUMNS];

            CombinationCreator();
            LabelCreator();
            HintCreator();
            mainMenu = menu;

            validateBtn.Enabled = false;
        }
        //méthode pour la grille de jeu
        private void LabelCreator()
        {
            int width = 20;
            int height = 20;

            lblGrid = new Label[ROWS, COLUMNS];

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    Label playLbl = new Label();

                    playLbl.BackColor = Color.Gray;
                    playLbl.Size = new Size (width, height);
                    playLbl.Location = new Point(j * 20 * 2, i * 20 * 2);
                    playerPnl.Controls.Add(playLbl);

                    lblGrid[i, j] = playLbl;
                }
            }

            
        }

        private void HintCreator()
        {
            int width = 10;
            int height = 10;

            hintGrid = new Label[ROWS, COLUMNS];

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    Label hintLbl = new Label
                    {
                        BackColor = Color.Gray,
                        Size = new Size(width, height),
                        Location = new Point(j * width * 2, i * height * 4)
                    };
                    hintPnl.Controls.Add(hintLbl);

                    hintGrid[i, j] = hintLbl;
                }
            }
         }

        //méthode pour que les couleurs soient cliquables
        private void availableColor1_Click(object sender, EventArgs e)
        {   
            //ajoute l'option pour tous les boutons de couleurs

            if (currentColumn < COLUMNS)
            {
                Button colorButton = (Button)sender;          
                //adapter la couleur
                lblGrid[currentRow, currentColumn].BackColor = colorButton.BackColor;

                currentColumn++;

                validateBtn.Enabled = (currentColumn == COLUMNS);
            }
            else
            {
                MessageBox.Show("Veuillez valider votre réponse");
            }
            //passage au bouton suivant

            
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
            //List <Color> availableColors = new List <Color>
            //{
            //    Color.Green,
            //    Color.Yellow,
            //    Color.White,
            //    Color.Red,
            //    Color.Blue,
            //    Color.Magenta,
            //    Color.Cyan,

            //};



            Random random = new Random();
            for(int i = 0; i < COLUMNS; i++)
            {
                Color randomColor = availableColors[random.Next(availableColors.Length)];
                Button btnCombination = new Button
                {
                    BackColor = randomColor,
                    Enabled = false,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(50, 50)
                };
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
            CheckCode();
            currentColumn = 0;

            validateBtn.Enabled = false;

            // Vérifier que le joueur a rempli 4 cases
            //if (currentColumn < COLUMNS)
            //{
            //    MessageBox.Show("Veuillez sélectionner quatre couleurs avant de valider.");
            //    return;
            //}


            //// Appel de méthode et comparaison
            //bool isCorrect = CheckPlayerCombination();

            //// Feedback
            //if (isCorrect)
            //{
            //    MessageBox.Show("Bravo le veau ! Vous avez deviné la combinaison secrète.");
            //}
            //else
            //{
            //    MessageBox.Show("La combinaison n'est pas correcte. Essayez à nouveau.");
            //}

            //// Réinitialisation
            //currentColumn = 0;
            //currentRow++;
            //if (currentRow == ROWS)
            //{
            //    MessageBox.Show("Vous avez atteint le nombre maximal d'essais. La combinaison secrète était : " + GetSecretCombination());
            //    ResetGame();
            //}
        }

        private void CheckCode()
        {
            int rightColor = 0;
            int misplacedColor = 0;
            int[] countColors = new int[availableColors.Length];
            int[] spotColors = new int[availableColors.Length];

            for (int i = 0; i < COLUMNS; i++)
            {
                countColors[Array.IndexOf(availableColors, selectedColors[i].BackColor)]++;
            }

            for (int i = 0; i < COLUMNS; i++) 
            {
                spotColors[Array.IndexOf(availableColors, lblGrid[currentRow, i].BackColor)]++;
            }

            for(int i = 0; i < COLUMNS; i++)
            {
                if (lblGrid[currentRow, i].BackColor == selectedColors[i].BackColor)
                {
                    rightColor++;
                }
            }

            clickCpt++;

            if(rightColor == COLUMNS)
            {
                MessageBox.Show("Bravo le veau t'as gagné");
            }

            else if(clickCpt == 10)
            {
                MessageBox.Show($"Vous avez atteint le nombre maximal d'essais. La combinaison secrète était : {GetSecretCombination()}");
                ResetGame();
            }

            else
            {
                for(int i =0; i < COLUMNS; i++)
                {
                    misplacedColor += Math.Min(countColors[i], spotColors[i]);
                }
                misplacedColor -= rightColor;

                for(int i = 0; i < COLUMNS; i++)
                {
                    if (i < rightColor)
                    {
                        hintGrid[currentRow, i].BackColor = Color.White;
                    }

                    else if(i >= rightColor && i < rightColor + misplacedColor)
                    {
                        hintGrid[currentRow, i].BackColor = Color.Black;
                    }
                    else
                    {
                        hintGrid[currentRow, i].BackColor = Color.Gray;
                    }

                }

                currentRow++;
            }
        }   

        private void ResetGame()
        {
            // Réinitialiser la grille et la combinaison du joueur
            currentRow = 0;
            currentColumn = 0;

            foreach (Label lbl in lblGrid)
            {
                lbl.BackColor = Color.Gray;
            }

            // Générer une nouvelle combinaison secrète
            CombinationCreator();
        }

        private bool CheckPlayerCombination()
        {
            // Comparaison avec le code secret
            for (int i = 0; i < COLUMNS; i++)
            {
                if (selectedColors[i].BackColor != lblGrid[currentRow, i].BackColor)
                {
                    return false; // Si incorrect
                }
            }

            return true; // Si correct
        }

        private string GetSecretCombination()
        {
            // Récupérer la combinaison secrète
            StringBuilder secretCombination = new StringBuilder();

            for (int i = 0; i < COLUMNS; i++)
            {
                secretCombination.Append(GetColorName(selectedColors[i].BackColor) + " ");
            }

            return secretCombination.ToString();
        }

        private string GetColorName(Color color)
        {
            // Convertir la couleur en nom (personnalisez cela en fonction de vos besoins)
            if (color == Color.Green) return "Vert";
            if (color == Color.Yellow) return "Jaune";
            if (color == Color.White) return "Blanc";
            if (color == Color.Red) return "Rouge";
            if (color == Color.Blue) return "Bleu";
            if (color == Color.Magenta) return "Magenta";
            if (color == Color.Cyan) return "Cyan";

            // au cas ou je rajoute des couleurs en plus
            return "Inconnu";
        }

    }
}

       

