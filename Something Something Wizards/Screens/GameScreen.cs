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
    public partial class GameScreen : UserControl
    {
        int screenSelector = 0;
        int attackSelector = 0;
        Pen drawPen = new Pen(Color.Black);
        Death_Wizard dk = new Death_Wizard();
        Lightining_Wizard lk = new Lightining_Wizard();
        MEGAMEME_Fire_Wizard_ mega = new MEGAMEME_Fire_Wizard_();
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            //switch)
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

            switch (OrignalForm.player_Charcter)
            {
                case 1:
                    e.Graphics.DrawImage(Properties.Resources.FUCK_DIMA, dk.x, dk.y);
                    break;
                case 2:
                    e.Graphics.DrawImage(Properties.Resources.Dima_is_a_shit_influence, mega.x, mega.y);
                    break;
                case 3:
                    e.Graphics.DrawImage(Properties.Resources.Light_Wizard, lk.x, lk.y);
                    break;
            }
            switch(attackSelector)
            {
                case 1:
                    switch(OrignalForm.player_Charcter)
                    {
                        case 1:
                            e.Graphics.DrawRectangle(drawPen, dk.objectX, dk.objectY, 200, 200);
                            break;
                    }               
                break;
            }
            Refresh();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
        if(screenSelector == 1 || screenSelector== 2 || screenSelector== 3)
            {
                changeScreen();
            }

            switch (attackSelector)
            {
                case 1:
                        dk.DeathEyes();                                    
               break;
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            screenSelector = 1;
        }

        private void changeScreen()
        {
            switch (screenSelector)
            {
                case 1:
                    attackButton.Visible = false;
                    passButton.Visible = false;
                    defendButton.Visible = false;
                    uselessButton.Visible = false;
                    attack1Button.Visible = true;
                    attack2Button.Visible = true;
                    attack3Button.Visible = true;
                    attack4Button.Visible = true;
                    switch (OrignalForm.player_Charcter)
                    {
                        case 1:
                            attack1Button.Text = "Death Eyes";
                            attack2Button.Text = "Death Hand";
                            attack3Button.Text = "Death Sword";
                            attack4Button.Text = "Shout";
                            break;
                        case 2:
                            attack1Button.Text = "expolsion";
                            attack2Button.Text = "Explosion";
                            attack3Button.Text = "EXPLOSION";
                            attack4Button.Text = "Baka";
                            break;
                        case 3:
                            attack1Button.Text = "Sparks";
                            attack2Button.Text = "Crakle";
                            attack3Button.Text = "Lightining";
                            attack4Button.Text = "Lizards";
                            break;
                    }
                    break;
                    
            }
        }

        private void attack1Button_Click(object sender, EventArgs e)
        {
            attackSelector = 1;
        }
    }
}
