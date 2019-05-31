using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something_Something_Wizards
{
    public class Death_Wizard: Wizards
    {
        public int objectX;
        public int objectY;
        
        public Death_Wizard()
        {
            name = OrignalForm.name;
            wizardSelection = 1;
            objectX = x + 200;
            objectY = y;
        }

        public void DeathEyes()
        {
            objectX += 4;            
        }
    }
}
