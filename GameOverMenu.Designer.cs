using System.Windows.Forms;

namespace StockManagerHero
{
    partial class GameOverMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GameOverText = new System.Windows.Forms.Label();
            this.FinalScorePanel = new System.Windows.Forms.Panel();
            this.FinalScoreText = new System.Windows.Forms.Label();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.LostPanel = new System.Windows.Forms.Panel();
            this.LostText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.FinalScorePanel.SuspendLayout();
            this.LostPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.GameOverText);
            this.panel1.Location = new System.Drawing.Point(3, 152);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 100);
            this.panel1.TabIndex = 0;
            // 
            // GameOverText
            // 
            this.GameOverText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameOverText.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.GameOverText.ForeColor = System.Drawing.Color.White;
            this.GameOverText.Location = new System.Drawing.Point(0, 0);
            this.GameOverText.Name = "GameOverText";
            this.GameOverText.Size = new System.Drawing.Size(597, 100);
            this.GameOverText.TabIndex = 0;
            this.GameOverText.Text = "Game Over";
            this.GameOverText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinalScorePanel
            // 
            this.FinalScorePanel.BackColor = System.Drawing.Color.Transparent;
            this.FinalScorePanel.Controls.Add(this.FinalScoreText);
            this.FinalScorePanel.Location = new System.Drawing.Point(0, 291);
            this.FinalScorePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FinalScorePanel.Name = "FinalScorePanel";
            this.FinalScorePanel.Size = new System.Drawing.Size(600, 53);
            this.FinalScorePanel.TabIndex = 1;
            // 
            // FinalScoreText
            // 
            this.FinalScoreText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinalScoreText.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.FinalScoreText.ForeColor = System.Drawing.Color.White;
            this.FinalScoreText.Location = new System.Drawing.Point(0, 0);
            this.FinalScoreText.Name = "FinalScoreText";
            this.FinalScoreText.Size = new System.Drawing.Size(600, 53);
            this.FinalScoreText.TabIndex = 0;
            this.FinalScoreText.Text = "Final Score : ";
            this.FinalScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayAgainButton.AutoSize = true;
            this.PlayAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(178)))));
            this.PlayAgainButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.PlayAgainButton.ForeColor = System.Drawing.Color.White;
            this.PlayAgainButton.Location = new System.Drawing.Point(231, 368);
            this.PlayAgainButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(138, 45);
            this.PlayAgainButton.TabIndex = 2;
            this.PlayAgainButton.Text = "Play again";
            this.PlayAgainButton.UseVisualStyleBackColor = false;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // LostPanel
            // 
            this.LostPanel.Controls.Add(this.LostText);
            this.LostPanel.Location = new System.Drawing.Point(0, 252);
            this.LostPanel.Name = "LostPanel";
            this.LostPanel.Size = new System.Drawing.Size(600, 50);
            this.LostPanel.TabIndex = 5;
            // 
            // LostText
            // 
            this.LostText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LostText.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.LostText.ForeColor = System.Drawing.Color.White;
            this.LostText.Location = new System.Drawing.Point(0, 0);
            this.LostText.Name = "LostText";
            this.LostText.Size = new System.Drawing.Size(600, 50);
            this.LostText.TabIndex = 0;
            this.LostText.Text = "No space left for current piece";
            this.LostText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.LostPanel);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.FinalScorePanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameOverMenu";
            this.Size = new System.Drawing.Size(600, 600);
            this.panel1.ResumeLayout(false);
            this.FinalScorePanel.ResumeLayout(false);
            this.LostPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label GameOverText;
        private Panel FinalScorePanel;
        private Label FinalScoreText;
        private Button PlayAgainButton;
        private Panel LostPanel;
        private Label LostText;
    }
}
