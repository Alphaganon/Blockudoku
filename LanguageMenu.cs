using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace StockManagerHero
{
    public partial class LanguageMenu : UserControl
    {
        private Blockudoku MainForm;

        public LanguageMenu(Blockudoku mainForm)
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

        private void FrenchButton_Click(object sender, EventArgs e)
        {
            MainForm.isFrench = true;
            StartMenu2 startMenu2 = new StartMenu2(MainForm);
            this.FindForm().Controls.Add(startMenu2);
            startMenu2.Translate();
            startMenu2.BringToFront();
            this.FindForm().Controls.Remove(this);
            this.Dispose();
        }

        private void EnglishButton_Click(object sender, EventArgs e)
        {
            MainForm.isFrench = false;
            StartMenu2 startMenu2 = new StartMenu2(MainForm);
            this.FindForm().Controls.Add(startMenu2);
            startMenu2.BringToFront();
            this.FindForm().Controls.Remove(this);
            this.Dispose();
        }
    }
}
