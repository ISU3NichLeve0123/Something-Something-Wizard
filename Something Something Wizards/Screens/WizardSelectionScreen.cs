using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Something_Something_Wizards
{
    public partial class WizardSelectionScreen : UserControl
    {
        public WizardSelectionScreen()
        {
            InitializeComponent();
        }

        private void WizardSelectionScreen_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawImage(Properties.Resources.FUCK_DIMA,50, 100);

            e.Graphics.DrawImage(Properties.Resources.Dima_is_a_shit_influence, 300, 100);

            e.Graphics.DrawImage(Properties.Resources.Light_Wizard, 600, 100);
        }

        private void darknessWizardButton_Click(object sender, EventArgs e)
        {
            OrignalForm.player_Charcter = 1;
            Form f = this.FindForm();
            GameScreen g = new GameScreen();
            f.Controls.Remove(this);
            f.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
        }

        private void fireWizardButton_Click(object sender, EventArgs e)
        {
            OrignalForm.player_Charcter = 2;
            Form f = this.FindForm();
            GameScreen g = new GameScreen();
            f.Controls.Remove(this);
            f.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
        }

        private void lightiningWizardButton_Click(object sender, EventArgs e)
        {
            OrignalForm.player_Charcter = 3;
            Form f = this.FindForm();
            GameScreen g = new GameScreen();
            f.Controls.Remove(this);
            f.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
        }
    }
}
