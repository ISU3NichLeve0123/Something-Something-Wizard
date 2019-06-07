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
   public class MEGAMEME_Fire_Wizard_ : Wizards
    {
         public int objectX, objectY, objectSize;
        
        public MEGAMEME_Fire_Wizard_()
        {
            name = OrignalForm.name;
            wizardSelection = 1;
            sizeX = 215;
            sizeY = 235;
            objectX = sizeX + 100;
            objectY = y + 50;
            objectSize = 50;                    
        }

        public void ObjectMove()
        {
            objectX += 4;
        }

        public bool Collsion(Wizards aiMega)
        {
            
            Rectangle rec2 = new Rectangle(aiMega.aiX, aiMega.aiY, aiMega.sizeX, aiMega.sizeY);
            Rectangle rec3 = new Rectangle(objectX, objectY, objectSize, objectSize);
            //Rectangle rec4 = new Rectangle(lk.x, lk.y, lk.sizeX, lk.sizeY);
            if (rec2.IntersectsWith(rec3))
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
