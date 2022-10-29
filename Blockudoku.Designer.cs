using System.Windows.Forms;

namespace StockManagerHero
{
    partial class Blockudoku
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blockudoku));
            this.GameCanvas = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BonusText = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameCanvas
            // 
            this.GameCanvas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameCanvas.BackColor = System.Drawing.Color.White;
            this.GameCanvas.Location = new System.Drawing.Point(66, 53);
            this.GameCanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GameCanvas.Name = "GameCanvas";
            this.GameCanvas.Size = new System.Drawing.Size(450, 450);
            this.GameCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GameCanvas.TabIndex = 2;
            this.GameCanvas.TabStop = false;
            this.GameCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Update);
            this.GameCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReactOnClick);
            this.GameCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GetMousePos);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BonusText);
            this.panel1.Controls.Add(this.ScoreText);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 39);
            this.panel1.TabIndex = 3;
            // 
            // BonusText
            // 
            this.BonusText.AutoSize = true;
            this.BonusText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BonusText.ForeColor = System.Drawing.Color.White;
            this.BonusText.Location = new System.Drawing.Point(422, 14);
            this.BonusText.Name = "BonusText";
            this.BonusText.Size = new System.Drawing.Size(57, 23);
            this.BonusText.TabIndex = 1;
            this.BonusText.Text = "Bonus";
            // 
            // ScoreText
            // 
            this.ScoreText.AutoEllipsis = true;
            this.ScoreText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoreText.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ScoreText.ForeColor = System.Drawing.Color.White;
            this.ScoreText.Location = new System.Drawing.Point(0, 0);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(600, 39);
            this.ScoreText.TabIndex = 0;
            this.ScoreText.Text = "Score : 0";
            this.ScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 10;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // StockManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GameCanvas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "StockManager";
            this.Text = "Stock Manager Hero";
            this.Load += new System.EventHandler(this.StockManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox GameCanvas;
        private Panel panel1;
        private Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
        private Label BonusText;
    }
}