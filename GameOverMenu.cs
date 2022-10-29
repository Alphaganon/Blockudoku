using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace StockManagerHero
{
    public partial class GameOverMenu : UserControl
    {
        private Blockudoku MainForm;

        public GameOverMenu(Blockudoku mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
            if (MainForm.isFrench)
            {
                Translate();
            }
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


        public void SetText(string str)
        {
            FinalScoreText.Text += str;
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            this.FindForm().Controls.Remove(this);
            this.Dispose();
        }

        public void Translate()
        {
            GameOverText.Text = "Perdu";
            PlayAgainButton.Text = "Rejouer";
            LostText.Text = "Impossible de placer la prochaine pièce";
            FinalScoreText.Text = "Score Final : ";
        }
    }
}
