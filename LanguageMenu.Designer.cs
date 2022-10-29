namespace StockManagerHero
{
    partial class LanguageMenu
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LanguageText = new System.Windows.Forms.Label();
            this.FrenchButton = new System.Windows.Forms.Button();
            this.EnglishButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.LanguageText);
            this.panel1.Location = new System.Drawing.Point(2, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 100);
            this.panel1.TabIndex = 1;
            // 
            // LanguageText
            // 
            this.LanguageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LanguageText.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.LanguageText.ForeColor = System.Drawing.Color.White;
            this.LanguageText.Location = new System.Drawing.Point(0, 0);
            this.LanguageText.Name = "LanguageText";
            this.LanguageText.Size = new System.Drawing.Size(597, 100);
            this.LanguageText.TabIndex = 0;
            this.LanguageText.Text = "Langue - Language";
            this.LanguageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrenchButton
            // 
            this.FrenchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FrenchButton.AutoSize = true;
            this.FrenchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(178)))));
            this.FrenchButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.FrenchButton.ForeColor = System.Drawing.Color.White;
            this.FrenchButton.Location = new System.Drawing.Point(100, 302);
            this.FrenchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FrenchButton.Name = "FrenchButton";
            this.FrenchButton.Size = new System.Drawing.Size(138, 45);
            this.FrenchButton.TabIndex = 3;
            this.FrenchButton.Text = "Français";
            this.FrenchButton.UseVisualStyleBackColor = false;
            this.FrenchButton.Click += new System.EventHandler(this.FrenchButton_Click);
            // 
            // EnglishButton
            // 
            this.EnglishButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnglishButton.AutoSize = true;
            this.EnglishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(178)))));
            this.EnglishButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.EnglishButton.ForeColor = System.Drawing.Color.White;
            this.EnglishButton.Location = new System.Drawing.Point(362, 302);
            this.EnglishButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.Size = new System.Drawing.Size(138, 45);
            this.EnglishButton.TabIndex = 3;
            this.EnglishButton.Text = "English";
            this.EnglishButton.UseVisualStyleBackColor = false;
            this.EnglishButton.Click += new System.EventHandler(this.EnglishButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 40);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coded by Ahmed EL YAKOUBI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LanguageMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EnglishButton);
            this.Controls.Add(this.FrenchButton);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "LanguageMenu";
            this.Size = new System.Drawing.Size(600, 600);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LanguageText;
        private System.Windows.Forms.Button FrenchButton;
        private System.Windows.Forms.Button EnglishButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
