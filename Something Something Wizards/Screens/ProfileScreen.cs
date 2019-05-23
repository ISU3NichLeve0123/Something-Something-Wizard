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
    public partial class ProfileScreen : UserControl
    {
        public ProfileScreen()
        {
            InitializeComponent();
            nameOutputlLabel.Text = Form1.name;
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            MainScreen g = new MainScreen();
            f.Controls.Remove(this);
            f.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
        }

        private void changeNameButton_Click(object sender, EventArgs e)
        {
            saveNameButton.Visible = true;
            nameOutputlLabel.Text = "";
            nameInputTextBox.Visible = true;
            currentNameLabel.Text = "New Name";
            profileLabel.Text = "Change Name";
            mainMenuButton.Visible = false;

        }
    }
    }

