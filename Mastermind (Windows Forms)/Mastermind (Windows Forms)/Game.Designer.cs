namespace Mastermind__Windows_Forms_
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.availableColor1 = new System.Windows.Forms.Button();
            this.availableColor2 = new System.Windows.Forms.Button();
            this.availableColor3 = new System.Windows.Forms.Button();
            this.availableColor4 = new System.Windows.Forms.Button();
            this.availableColor5 = new System.Windows.Forms.Button();
            this.availableColor6 = new System.Windows.Forms.Button();
            this.availableColor7 = new System.Windows.Forms.Button();
            this.btnQuit2 = new System.Windows.Forms.Button();
            this.validateBtn = new System.Windows.Forms.Button();
            this.pnlCombination = new System.Windows.Forms.TableLayoutPanel();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReturn2 = new System.Windows.Forms.Button();
            this.playerPnl = new System.Windows.Forms.Panel();
            this.hintPnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // availableColor1
            // 
            this.availableColor1.BackColor = System.Drawing.Color.Green;
            this.availableColor1.FlatAppearance.BorderSize = 0;
            this.availableColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableColor1.ForeColor = System.Drawing.SystemColors.Control;
            this.availableColor1.Location = new System.Drawing.Point(639, 12);
            this.availableColor1.Name = "availableColor1";
            this.availableColor1.Size = new System.Drawing.Size(30, 30);
            this.availableColor1.TabIndex = 0;
            this.availableColor1.UseVisualStyleBackColor = false;
            this.availableColor1.Click += new System.EventHandler(this.availableColor1_Click);
            // 
            // availableColor2
            // 
            this.availableColor2.BackColor = System.Drawing.Color.White;
            this.availableColor2.FlatAppearance.BorderSize = 0;
            this.availableColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableColor2.ForeColor = System.Drawing.Color.White;
            this.availableColor2.Location = new System.Drawing.Point(639, 63);
            this.availableColor2.Name = "availableColor2";
            this.availableColor2.Size = new System.Drawing.Size(30, 30);
            this.availableColor2.TabIndex = 1;
            this.availableColor2.UseVisualStyleBackColor = false;
            this.availableColor2.Click += new System.EventHandler(this.availableColor1_Click);
            // 
            // availableColor3
            // 
            this.availableColor3.BackColor = System.Drawing.Color.Yellow;
            this.availableColor3.FlatAppearance.BorderSize = 0;
            this.availableColor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableColor3.Location = new System.Drawing.Point(639, 119);
            this.availableColor3.Name = "availableColor3";
            this.availableColor3.Size = new System.Drawing.Size(30, 30);
            this.availableColor3.TabIndex = 2;
            this.availableColor3.UseVisualStyleBackColor = false;
            this.availableColor3.Click += new System.EventHandler(this.availableColor1_Click);
            // 
            // availableColor4
            // 
            this.availableColor4.BackColor = System.Drawing.Color.Red;
            this.availableColor4.FlatAppearance.BorderSize = 0;
            this.availableColor4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableColor4.Location = new System.Drawing.Point(639, 180);
            this.availableColor4.Name = "availableColor4";
            this.availableColor4.Size = new System.Drawing.Size(30, 30);
            this.availableColor4.TabIndex = 3;
            this.availableColor4.UseVisualStyleBackColor = false;
            this.availableColor4.Click += new System.EventHandler(this.availableColor1_Click);
            // 
            // availableColor5
            // 
            this.availableColor5.BackColor = System.Drawing.Color.Blue;
            this.availableColor5.FlatAppearance.BorderSize = 0;
            this.availableColor5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableColor5.Location = new System.Drawing.Point(639, 236);
            this.availableColor5.Name = "availableColor5";
            this.availableColor5.Size = new System.Drawing.Size(30, 30);
            this.availableColor5.TabIndex = 4;
            this.availableColor5.UseVisualStyleBackColor = false;
            this.availableColor5.Click += new System.EventHandler(this.availableColor1_Click);
            // 
            // availableColor6
            // 
            this.availableColor6.BackColor = System.Drawing.Color.Magenta;
            this.availableColor6.FlatAppearance.BorderSize = 0;
            this.availableColor6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableColor6.Location = new System.Drawing.Point(639, 289);
            this.availableColor6.Name = "availableColor6";
            this.availableColor6.Size = new System.Drawing.Size(30, 30);
            this.availableColor6.TabIndex = 5;
            this.availableColor6.UseVisualStyleBackColor = false;
            this.availableColor6.Click += new System.EventHandler(this.availableColor1_Click);
            // 
            // availableColor7
            // 
            this.availableColor7.BackColor = System.Drawing.Color.Cyan;
            this.availableColor7.FlatAppearance.BorderSize = 0;
            this.availableColor7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableColor7.Location = new System.Drawing.Point(639, 342);
            this.availableColor7.Name = "availableColor7";
            this.availableColor7.Size = new System.Drawing.Size(30, 30);
            this.availableColor7.TabIndex = 6;
            this.availableColor7.UseVisualStyleBackColor = false;
            this.availableColor7.Click += new System.EventHandler(this.availableColor1_Click);
            // 
            // btnQuit2
            // 
            this.btnQuit2.BackColor = System.Drawing.Color.Lavender;
            this.btnQuit2.ForeColor = System.Drawing.Color.Black;
            this.btnQuit2.Location = new System.Drawing.Point(594, 490);
            this.btnQuit2.Name = "btnQuit2";
            this.btnQuit2.Size = new System.Drawing.Size(75, 26);
            this.btnQuit2.TabIndex = 7;
            this.btnQuit2.Text = "Quitter";
            this.btnQuit2.UseVisualStyleBackColor = false;
            this.btnQuit2.Click += new System.EventHandler(this.btnReturn2_Click);
            // 
            // validateBtn
            // 
            this.validateBtn.BackColor = System.Drawing.Color.Lavender;
            this.validateBtn.ForeColor = System.Drawing.Color.Black;
            this.validateBtn.Location = new System.Drawing.Point(446, 363);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(75, 26);
            this.validateBtn.TabIndex = 19;
            this.validateBtn.Text = "Valider";
            this.validateBtn.UseVisualStyleBackColor = false;
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
            // 
            // pnlCombination
            // 
            this.pnlCombination.BackColor = System.Drawing.Color.Black;
            this.pnlCombination.ColumnCount = 4;
            this.pnlCombination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCombination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCombination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCombination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCombination.Location = new System.Drawing.Point(6, 395);
            this.pnlCombination.Name = "pnlCombination";
            this.pnlCombination.RowCount = 1;
            this.pnlCombination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCombination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.pnlCombination.Size = new System.Drawing.Size(200, 55);
            this.pnlCombination.TabIndex = 21;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Lavender;
            this.btnHide.ForeColor = System.Drawing.Color.Black;
            this.btnHide.Location = new System.Drawing.Point(6, 456);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(200, 26);
            this.btnHide.TabIndex = 22;
            this.btnHide.Text = "Afficher/Cacher";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Lavender;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(6, 490);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 26);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Nouvelle Combinaison";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReturn2
            // 
            this.btnReturn2.BackColor = System.Drawing.Color.Lavender;
            this.btnReturn2.ForeColor = System.Drawing.Color.Black;
            this.btnReturn2.Location = new System.Drawing.Point(594, 442);
            this.btnReturn2.Name = "btnReturn2";
            this.btnReturn2.Size = new System.Drawing.Size(75, 26);
            this.btnReturn2.TabIndex = 19;
            this.btnReturn2.Text = "Menu";
            this.btnReturn2.UseVisualStyleBackColor = false;
            this.btnReturn2.Click += new System.EventHandler(this.btnReturn2_Click_1);
            // 
            // playerPnl
            // 
            this.playerPnl.BackColor = System.Drawing.Color.Transparent;
            this.playerPnl.Location = new System.Drawing.Point(3, 12);
            this.playerPnl.Name = "playerPnl";
            this.playerPnl.Size = new System.Drawing.Size(218, 377);
            this.playerPnl.TabIndex = 23;
            // 
            // hintPnl
            // 
            this.hintPnl.BackColor = System.Drawing.Color.Transparent;
            this.hintPnl.Location = new System.Drawing.Point(227, 12);
            this.hintPnl.Name = "hintPnl";
            this.hintPnl.Size = new System.Drawing.Size(200, 377);
            this.hintPnl.TabIndex = 24;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(681, 528);
            this.Controls.Add(this.hintPnl);
            this.Controls.Add(this.playerPnl);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.pnlCombination);
            this.Controls.Add(this.btnReturn2);
            this.Controls.Add(this.validateBtn);
            this.Controls.Add(this.btnQuit2);
            this.Controls.Add(this.availableColor7);
            this.Controls.Add(this.availableColor6);
            this.Controls.Add(this.availableColor5);
            this.Controls.Add(this.availableColor4);
            this.Controls.Add(this.availableColor3);
            this.Controls.Add(this.availableColor2);
            this.Controls.Add(this.availableColor1);
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button availableColor1;
        private System.Windows.Forms.Button availableColor2;
        private System.Windows.Forms.Button availableColor3;
        private System.Windows.Forms.Button availableColor4;
        private System.Windows.Forms.Button availableColor5;
        private System.Windows.Forms.Button availableColor6;
        private System.Windows.Forms.Button availableColor7;
        private System.Windows.Forms.Button btnQuit2;
        private System.Windows.Forms.Button validateBtn;
        private System.Windows.Forms.TableLayoutPanel pnlCombination;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReturn2;
        private System.Windows.Forms.Panel playerPnl;
        private System.Windows.Forms.Panel hintPnl;
    }
}