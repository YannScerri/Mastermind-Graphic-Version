namespace Mastermind__Windows_Forms_
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            this.rtxtboxRules = new System.Windows.Forms.RichTextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtboxRules
            // 
            this.rtxtboxRules.Font = new System.Drawing.Font("Javanese Text", 13F);
            this.rtxtboxRules.Location = new System.Drawing.Point(91, 37);
            this.rtxtboxRules.Name = "rtxtboxRules";
            this.rtxtboxRules.ReadOnly = true;
            this.rtxtboxRules.Size = new System.Drawing.Size(629, 361);
            this.rtxtboxRules.TabIndex = 0;
            this.rtxtboxRules.Text = resources.GetString("rtxtboxRules.Text");
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 26);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(69, 42);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.rtxtboxRules);
            this.Name = "Rules";
            this.RightToLeftLayout = true;
            this.Text = "Règles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtboxRules;
        private System.Windows.Forms.Button btnReturn;
    }
}