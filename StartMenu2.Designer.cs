using System.Windows.Forms;

namespace StockManagerHero
{
    partial class StartMenu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rules = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rule1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Rule2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Rule3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.EasyModeButton = new System.Windows.Forms.Button();
            this.HardModeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Rules);
            this.panel1.Location = new System.Drawing.Point(11, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 78);
            this.panel1.TabIndex = 5;
            // 
            // Rules
            // 
            this.Rules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rules.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.Rules.ForeColor = System.Drawing.Color.White;
            this.Rules.Location = new System.Drawing.Point(0, 0);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(579, 78);
            this.Rules.TabIndex = 0;
            this.Rules.Text = "How to play :";
            this.Rules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Rule1);
            this.panel2.Location = new System.Drawing.Point(11, 188);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 39);
            this.panel2.TabIndex = 6;
            // 
            // Rule1
            // 
            this.Rule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rule1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Rule1.ForeColor = System.Drawing.Color.White;
            this.Rule1.Location = new System.Drawing.Point(0, 0);
            this.Rule1.Name = "Rule1";
            this.Rule1.Size = new System.Drawing.Size(579, 39);
            this.Rule1.TabIndex = 0;
            this.Rule1.Text = "Left click to place the cardboard";
            this.Rule1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.Rule2);
            this.panel3.Location = new System.Drawing.Point(11, 228);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 39);
            this.panel3.TabIndex = 7;
            // 
            // Rule2
            // 
            this.Rule2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rule2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Rule2.ForeColor = System.Drawing.Color.White;
            this.Rule2.Location = new System.Drawing.Point(0, 0);
            this.Rule2.Name = "Rule2";
            this.Rule2.Size = new System.Drawing.Size(579, 39);
            this.Rule2.TabIndex = 0;
            this.Rule2.Text = "Right click to change the orientation";
            this.Rule2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.Rule3);
            this.panel4.Location = new System.Drawing.Point(11, 268);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(579, 74);
            this.panel4.TabIndex = 8;
            // 
            // Rule3
            // 
            this.Rule3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rule3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Rule3.ForeColor = System.Drawing.Color.White;
            this.Rule3.Location = new System.Drawing.Point(0, 0);
            this.Rule3.Name = "Rule3";
            this.Rule3.Size = new System.Drawing.Size(579, 74);
            this.Rule3.TabIndex = 0;
            this.Rule3.Text = "When a row, a column or a 3 by 3 block is full, it becomes empty and you earn poi" +
    "nts";
            this.Rule3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.EasyModeButton);
            this.panel5.Controls.Add(this.HardModeButton);
            this.panel5.Location = new System.Drawing.Point(0, 345);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 100);
            this.panel5.TabIndex = 9;
            // 
            // EasyModeButton
            // 
            this.EasyModeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EasyModeButton.AutoSize = true;
            this.EasyModeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(178)))));
            this.EasyModeButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.EasyModeButton.ForeColor = System.Drawing.Color.White;
            this.EasyModeButton.Location = new System.Drawing.Point(100, 34);
            this.EasyModeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EasyModeButton.Name = "EasyModeButton";
            this.EasyModeButton.Size = new System.Drawing.Size(94, 45);
            this.EasyModeButton.TabIndex = 2;
            this.EasyModeButton.Text = "Easy";
            this.EasyModeButton.UseVisualStyleBackColor = false;
            this.EasyModeButton.Click += new System.EventHandler(this.EasyModeButton_Click);
            // 
            // HardModeButton
            // 
            this.HardModeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HardModeButton.AutoSize = true;
            this.HardModeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(178)))));
            this.HardModeButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.HardModeButton.ForeColor = System.Drawing.Color.White;
            this.HardModeButton.Location = new System.Drawing.Point(406, 34);
            this.HardModeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HardModeButton.Name = "HardModeButton";
            this.HardModeButton.Size = new System.Drawing.Size(94, 45);
            this.HardModeButton.TabIndex = 1;
            this.HardModeButton.Text = "Hard";
            this.HardModeButton.UseVisualStyleBackColor = false;
            this.HardModeButton.Click += new System.EventHandler(this.HardModeButton_Click);
            // 
            // StartMenu2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartMenu2";
            this.Size = new System.Drawing.Size(600, 600);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label Rules;
        private Panel panel2;
        private Label Rule1;
        private Panel panel3;
        private Label Rule2;
        private Panel panel4;
        private Label Rule3;
        private Panel panel5;
        private Button EasyModeButton;
        private Button HardModeButton;
    }
}
