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
        Lightining_Wizard lk = new Lightining_Wizard();
        MEGAMEME_Fire_Wizard_ mega = new MEGAMEME_Fire_Wizard_();

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        private void GameScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case 'z':
                    zKey = true;
                    if (zKey == true && cKey != true && xKey != true && vKey != true && possibleAttacks == false)
                    {
                        attackPhase = true;
                    }
                    if(zKey == true && cKey != true && xKey != true && vKey != true && possibleAttacks == true)
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
       switch(aiSelectedCharcter)
            {
                case 2:
                    mega.x = 600;
                    mega.y = 120;
                    break;
            }
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
            
            if ((dk.Collsion(dk, mega) == true))
            {
                mega.health -= 4;
                mega.mana -= 3;
                attackPhase = false;
                possibleAttacks = false;
                dk.objectX = dk.x + 100;
                timer = 0;
                attackSelector = 0;
                if(mega.health == 0| dk.health == 0|| lk.health == 0)
                {

                }
            }
            if (possibleAttacks == true && zKey == true|| xKey == true || cKey == true|| xKey == true|| timer > 20)
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
                            //dk.DeathEyes();
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
                }
            }

        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {   if(attackSelector == 0)
            {
                e.Graphics.DrawString("What Will You Do?", drawFont, drawBrush, 200, 0);
            }
            else {}
            //Message for players
          
            //This is the default phase, where pepole start out and will need to decide to go
            if (attackPhase == false)
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
            switch(aiSelectedCharcter)
            {
                case 1:
                    e.Graphics.DrawImage(Properties.Resources.FUCK_DIMA, dk.x, dk.y, dk.sizeX, dk.sizeY);
                    break;
                case 2:
                    e.Graphics.DrawImage(Properties.Resources.Dima_is_a_shit_influence, mega.x, mega.y, mega.sizeX, mega.sizeY);
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

            if (possibleAttacks == true || attackInMotion == true)
            {
                attackDrawer(e);
            }
            }

        }
    }


