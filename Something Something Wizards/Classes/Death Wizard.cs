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
            objectX = x + 200;
            objectY = y;
            objectSize = 100;
        }

        public void DeathEyes()
        {
            objectX += 4;
        }

        public bool Collsion(Death_Wizard MC, MEGAMEME_Fire_Wizard_ MC2)
        {
            Rectangle rec1 = new Rectangle(MC.x, MC.y, MC.size, MC.size);
            Rectangle rec2 = new Rectangle(MC2.x, MC2.y, MC2.size, MC2.size);
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
