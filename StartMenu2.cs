using System;
using System.Windows.Forms;

namespace StockManagerHero
{
    public partial class StartMenu2 : UserControl
    {
        private Blockudoku MainForm;

        public StartMenu2(Blockudoku mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        internal void Translate()
        {
            Rules.Text = "Comment Jouer";
            Rule1.Text = "Clic gauche pour placer le carton";
            Rule2.Text = "Clic droit pour changer l'orientation du carton";
            Rule3.Text = "Quand une ligne, une colonne ou un carré 3 par 3 est rempli, il se vide et vous gagnez des points";
            EasyModeButton.Text = "Facile";
            HardModeButton.Text = "Difficile";
            HardModeButton.Location = new System.Drawing.Point(500 - HardModeButton.Width, HardModeButton.Location.Y);
        }

        private void EasyModeButton_Click(object sender, EventArgs e)
        {
            if (!MainForm.rotate)
            {
                MainForm.rotate = true;
            }
            this.FindForm().Controls.Remove(this);
            this.Dispose();
        }

        private void HardModeButton_Click(object sender, EventArgs e)
        {
            if (MainForm.rotate)
            {
                MainForm.rotate = false;
            }
            this.FindForm().Controls.Remove(this);
            this.Dispose();
        }
    }
}
