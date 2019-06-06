using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Something_Something_Wizards
{
    public class Death_Wizard : Wizards
    {
        public int objectX, objectY, objectSize;

        public Death_Wizard()
        {
            name = OrignalForm.name;
            wizardSelection = 1;
            objectX = sizeX + 100;
            objectY = y + 50;
            objectSize = 50;
            sizeX = 215;
            sizeY = 235;
        }

        public void  ObjectMove()
        {
            objectX += 4;
        }

        public bool Collsion(Wizards dk, Wizards mega)
        {
            Rectangle rec1 = new Rectangle(dk.x, dk.y, dk.sizeX, dk.sizeY);
            Rectangle rec2 = new Rectangle(mega.x, mega.y, mega.sizeX, mega.sizeY);
            Rectangle rec3 = new Rectangle(objectX, objectY, objectSize, objectSize);
            if (rec3.IntersectsWith(rec2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
