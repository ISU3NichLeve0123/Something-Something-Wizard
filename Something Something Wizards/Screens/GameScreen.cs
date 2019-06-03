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
        bool zKey, cKey, xKey, vKey, attackPhase;
        int screenSelector = 0;
        int attackSelector = 0;
        Pen drawPen = new Pen(Color.Black);
        Font drawFont = new Font("Arial", 30);
        SolidBrush drawBrush = new SolidBrush(Color.Green);
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
        private void gameTimer_Tick(object sender, EventArgs e)
        {

            switch (attackSelector)
            {
                case 1:
                    dk.DeathEyes();
                    break;
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.C:
                    cKey = false;
                    break;
                case Keys.V:
                    vKey = false;
                    break;
                case Keys.X:
                    xKey = false;
                    break;
                case Keys.Left:
                    zKey = false;
                    break;
            }
        }

        private void changeScreen()
        {

        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.C:
                    cKey = true;
                    break;
                case Keys.V:
                    vKey = true;
                    break;
                case Keys.X:
                    xKey = true;
                    break;
                case Keys.Z:
                    zKey = true;
                    attackPhase = true;
                    break;
            }
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            if (zKey == false && attackPhase == false)
            {
                e.Graphics.DrawString("Attack", drawFont, drawBrush, 100, 330);
                drawBrush.Color = Color.SkyBlue;
                e.Graphics.DrawString("Defend", drawFont, drawBrush, 500, 330);
                drawBrush.Color = Color.Red;
                e.Graphics.DrawString("Pass", drawFont, drawBrush, 90, 410);
                drawBrush.Color = Color.Yellow;
                e.Graphics.DrawString("Useless", drawFont, drawBrush, 500, 410);
                drawBrush.Color = Color.Green;
            }

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
            e.Graphics.DrawString("What Will You Do?", drawFont, drawBrush, 200, 0);
            switch (attackSelector)
            {
                case 1:
                    switch (OrignalForm.player_Charcter)
                    {
                        case 1:
                            e.Graphics.DrawRectangle(drawPen, dk.objectX, dk.objectY, 200, 200);
                            break;
                    }
                    break;
            }
            if (zKey == true|| attackPhase == true)
            {
                switch (screenSelector)
                {
                    case 1:
                        e.Graphics.DrawString("Death Eyes", drawFont, drawBrush, 100, 330);
                        drawBrush.Color = Color.SkyBlue;
                        e.Graphics.DrawString("Death Hand", drawFont, drawBrush, 500, 330);
                        drawBrush.Color = Color.Red;
                        e.Graphics.DrawString("Death Sword", drawFont, drawBrush, 90, 410);
                        drawBrush.Color = Color.Yellow;
                        e.Graphics.DrawString("Shout", drawFont, drawBrush, 500, 410);
                        drawBrush.Color = Color.Green;
                        break;
                    case 2:
                        //attackLabel.Text = "expolsion";
                        //defenedLabel.Text = "Explosion";
                        //passLabel.Text = "EXPLOSION";
                        //uselessLabel.Text = "Baka";
                        break;
                    case 3:
                        //attackLabel.Text = "Sparks";
                        //defenedLabel.Text = "Crakle";
                        //passLabel.Text = "Lightining";
                        //uselessLabel.Text = "Lizards";
                        break;
                }
            }
            changeScreen();
            Refresh();
        }
    }
}
