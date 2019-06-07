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
        bool zKey, cKey, xKey, vKey, attackPhase, possibleAttacks, attackInMotion;
        int attackSelector, timer;
        int aiSelectedCharcter = 2;
        List<Wizards> baka = new List<Wizards>();
        Pen drawPen = new Pen(Color.Black);
        Font drawFont = new Font("Arial", 30);
        SolidBrush drawBrush = new SolidBrush(Color.Green);
        Death_Wizard dk = new Death_Wizard();
        Death_Wizard aiDK = new Death_Wizard();
        Lightining_Wizard lk = new Lightining_Wizard();
        Lightining_Wizard aiLK = new Lightining_Wizard();
        MEGAMEME_Fire_Wizard_ mega = new MEGAMEME_Fire_Wizard_();
        MEGAMEME_Fire_Wizard_ aiMega = new MEGAMEME_Fire_Wizard_();

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        private void GameScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'z':
                    zKey = true;
                    if (zKey == true && cKey != true && xKey != true && vKey != true && possibleAttacks == false)
                    {
                        attackPhase = true;
                    }
                    if (zKey == true && cKey != true && xKey != true && vKey != true && possibleAttacks == true)
                    {
                        attackSelector = 1;
                    }
                    break;
                case 'c':
                    cKey = true;
                    if (cKey == true && zKey != true && xKey != true && vKey != true && possibleAttacks == true)
                    {
                        attackSelector = 2;
                    }
                    break;
                case 'v':
                    vKey = true;
                    if (vKey == true && cKey != true && xKey != true && zKey != true && possibleAttacks == true)
                    {
                        attackSelector = 3;
                    }
                    break;
                case 'x':
                    xKey = true;
                    if (xKey == true && cKey != true && zKey != true && vKey != true && possibleAttacks == true)
                    {
                        attackSelector = 4;
                    }
                    break;
            }
        }

        public void OnStart()
        {
        }


        private void GameScreen_Keyup(object sender, PreviewKeyDownEventArgs e)
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
                case Keys.Z:
                    zKey = false;
                    break;
            }
        }



        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (OrignalForm.player_Charcter == 2)
            {
                if (mega.Collsion(aiMega) == true)
                {
                    switch (attackSelector)
                    {
                        case 1:
                            aiMega.health -= 3;
                            mega.mana -= 2;
                            break;
                        case 2:
                            aiMega.health -= 6;
                            mega.mana -= 4;
                            break;
                        case 3:
                            aiMega.health -= 9;
                            mega.mana -= 10;
                            break;
                        case 4:
                            aiMega.health -= 3;
                            mega.mana -= 3;
                            break;
                    }
                    attackPhase = false;
                    possibleAttacks = false;
                    mega.objectX = mega.sizeX + 100;
                    timer = 0;
                    attackSelector = 0;
                    if (aiMega.health <= 0 || aiDK.health <= 0 || aiLK.health <= 0)
                    {
                        Form f = this.FindForm();
                        WinScreen g = new WinScreen();
                        f.Controls.Remove(this);
                        f.Controls.Add(g);
                        g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
                    }
                }

            }
            if (OrignalForm.player_Charcter == 1)
            {
                if ((dk.Collsion(mega) == true))
                {
                    switch (attackSelector)
                    {
                        case 1:
                            aiMega.health -= 3;
                            dk.mana -= 2;
                            break;
                        case 2:
                            aiMega.health -= 6;
                            dk.mana -= 4;
                            break;
                        case 3:
                            aiMega.health -= 9;
                            dk.mana -= 10;
                            break;
                        case 4:
                            aiMega.health -= 3;
                            dk.mana -= 3;
                            break;
                    }
                    attackPhase = false;
                    possibleAttacks = false;
                    dk.objectX = dk.x + 100;
                    timer = 0;
                    attackSelector = 0;
                    if (aiMega.health <= 0 || aiDK.health <= 0 || aiLK.health <= 0)
                    {
                        Form f = this.FindForm();
                        WinScreen g = new WinScreen();
                        f.Controls.Remove(this);
                        f.Controls.Add(g);
                        g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
                    }
                }
            }

            if (possibleAttacks == true && zKey == true || xKey == true || cKey == true || xKey == true || timer > 20)
            {
                timer++;
            }
            switch (OrignalForm.player_Charcter)
            {
                case 1:
                    switch (attackSelector)
                    {
                        case 1:
                            dk.ObjectMove();
                            break;
                        case 2:
                            dk.ObjectMove();
                            break;
                        case 3:
                            dk.ObjectMove();
                            break;
                        case 4:
                            dk.ObjectMove();
                            break;

                    }
                    break;
                case 2:
                    switch (attackSelector)
                    {
                        case 1:
                            mega.ObjectMove();
                            break;
                        case 2:
                            mega.ObjectMove();
                            break;
                        case 3:
                            mega.ObjectMove();
                            break;
                        case 4:
                            mega.ObjectMove();
                            break;
                    }
                    break;
                case 3:
                    switch (attackSelector)
                    {
                        case 1:
                            //dk.DeathEyes();
                            break;
                    }
                    break;

            }
            Refresh();

        }
        private void attackDrawer(PaintEventArgs e)
        {
            //Draws what attack the player selects

            if (attackSelector == 1 && possibleAttacks == true || timer > 20 && attackInMotion == true)
            {
                switch (OrignalForm.player_Charcter)
                {
                    case 1:
                        e.Graphics.DrawString(dk.name + " used Death Eyes!", drawFont, drawBrush, 200, 0);
                        e.Graphics.DrawRectangle(drawPen, dk.objectX, dk.objectY, dk.objectSize, dk.objectSize);
                        possibleAttacks = false;
                        attackInMotion = true;
                        break;
                    case 2:
                        e.Graphics.DrawString(mega.name + " used expolsion!", drawFont, drawBrush, 200, 0);
                        e.Graphics.DrawRectangle(drawPen, mega.objectX, mega.objectY, mega.objectSize, mega.objectSize);
                        possibleAttacks = false;
                        attackInMotion = true;
                        break;
                }

            }
            if (attackSelector == 2 && possibleAttacks == true || timer > 20 && attackInMotion == true)
            {
                switch (OrignalForm.player_Charcter)
                {
                    case 1:
                        e.Graphics.DrawString(dk.name + " used Death Hand!", drawFont, drawBrush, 200, 0);
                        e.Graphics.DrawEllipse(drawPen, dk.objectX, dk.objectY, dk.objectSize, dk.objectSize);
                        possibleAttacks = false;
                        attackInMotion = true;
                        break;
                    case 2:
                        e.Graphics.DrawString(mega.name + " used Expolsion!", drawFont, drawBrush, 200, 0);
                        e.Graphics.DrawEllipse(drawPen, mega.objectX, mega.objectY, mega.objectSize, mega.objectSize);
                        possibleAttacks = false;
                        attackInMotion = true;
                        break;
                }
            }
            if (attackSelector == 3 && possibleAttacks == true || timer > 20 && attackInMotion == true)
            {
                switch (OrignalForm.player_Charcter)
                {
                    case 1:
                        e.Graphics.DrawString(dk.name + " used Death Sword!", drawFont, drawBrush, 200, 0);
                        e.Graphics.DrawImage(Properties.Resources.Wizardry_Logo, dk.objectX, dk.objectY, dk.objectSize, dk.objectSize);
                        possibleAttacks = false;
                        attackInMotion = true;
                        break;
                    case 2:
                        e.Graphics.DrawString(mega.name + " used EXPOLSION!", drawFont, drawBrush, 200, 0);
                        e.Graphics.DrawImage(Properties.Resources.Wizardry_Logo, mega.objectX, mega.objectY, mega.objectSize, mega.objectSize);
                        attackInMotion = true;
                        break;
                }
            }
            if (attackSelector == 4 && possibleAttacks == true || timer > 20 && attackInMotion == true)
            {
                switch (OrignalForm.player_Charcter)
                {
                    case 1:
                        e.Graphics.DrawString(dk.name + " used Shout!", drawFont, drawBrush, 200, 0);
                        e.Graphics.DrawImage(Properties.Resources.Cat_Of_Hell, dk.objectX, dk.objectY, dk.objectSize, dk.objectSize);
                        possibleAttacks = false;
                        attackInMotion = true;
                        break;
                    case 2:
                        e.Graphics.DrawString(mega.name + " used Baka!", drawFont, drawBrush, 200, 0);
                        e.Graphics.DrawImage(Properties.Resources.Cat_Of_Hell, mega.objectX, mega.objectY, mega.objectSize, mega.objectSize);
                        possibleAttacks = false;
                        attackInMotion = true;
                        break;
                }
            }

        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            if (attackSelector == 0)
            {
                e.Graphics.DrawString("What Will You Do?", drawFont, drawBrush, 200, 0);
            }
            else { }
            //Message for players

            //This is the default phase, where pepole start out and will need to decide to go
            if (attackPhase == false)
            {
                drawBrush.Color = Color.Green;
                e.Graphics.DrawString("Attack", drawFont, drawBrush, 100, 330);
                drawBrush.Color = Color.SkyBlue;
                e.Graphics.DrawString("Defend", drawFont, drawBrush, 500, 330);
                drawBrush.Color = Color.Red;
                e.Graphics.DrawString("Pass", drawFont, drawBrush, 90, 410);
                drawBrush.Color = Color.Yellow;
                e.Graphics.DrawString("Useless", drawFont, drawBrush, 500, 410);
            }
            switch (aiSelectedCharcter)
            {
                case 1:
                    e.Graphics.DrawImage(Properties.Resources.FUCK_DIMA, aiDK.x, aiDK.y, aiDK.sizeX, aiDK.sizeY);
                    break;
                case 2:
                    e.Graphics.DrawImage(Properties.Resources.Dima_is_a_shit_influence, aiMega.aiX, aiMega.aiY);
                    break;
                case 3:
                    e.Graphics.DrawImage(Properties.Resources.Light_Wizard, lk.x, lk.y);
                    break;
            }
            //Decides what Wizard to draw
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

            //Switches around what is drawn when attacking and based off of what wizard you selected
            if (attackPhase == true)
            {
                switch (OrignalForm.player_Charcter)
                {
                    case 1:
                        drawBrush.Color = Color.Green;
                        e.Graphics.DrawString("Death Eyes", drawFont, drawBrush, 100, 330);
                        drawBrush.Color = Color.SkyBlue;
                        e.Graphics.DrawString("Death Hand", drawFont, drawBrush, 500, 330);
                        drawBrush.Color = Color.Red;
                        e.Graphics.DrawString("Death Sword", drawFont, drawBrush, 90, 410);
                        drawBrush.Color = Color.Yellow;
                        e.Graphics.DrawString("Shout", drawFont, drawBrush, 500, 410);
                        drawBrush.Color = Color.Green;
                        possibleAttacks = true;
                        zKey = false;
                        cKey = false;
                        xKey = false;
                        vKey = false;
                        break;
                    case 2:
                        drawBrush.Color = Color.Crimson;
                        e.Graphics.DrawString("expolsion", drawFont, drawBrush, 100, 330);
                        drawBrush.Color = Color.Firebrick;
                        e.Graphics.DrawString("Explosion", drawFont, drawBrush, 500, 330);
                        drawBrush.Color = Color.IndianRed;
                        e.Graphics.DrawString("EXPLOSION", drawFont, drawBrush, 90, 410);
                        drawBrush.Color = Color.White;
                        e.Graphics.DrawString("Baka", drawFont, drawBrush, 500, 410);
                        possibleAttacks = true;
                        zKey = false;
                        cKey = false;
                        xKey = false;
                        vKey = false;
                        break;
                    case 3:
                        //attackLabel.Text = "Sparks";
                        //defenedLabel.Text = "Crakle";
                        //passLabel.Text = "Lightining";
                        //uselessLabel.Text = "Lizards";
                        break;
                }
            }

            if (possibleAttacks == true || attackInMotion == true)
            {
                attackDrawer(e);
            }
        }


    }
}

