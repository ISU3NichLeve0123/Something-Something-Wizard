﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something_Something_Wizards
{
     public class Wizards
    {
        public int x, y, mana, health, wizardSelection, size;
        public string name;

        public Wizards()
        {
            health = 20;
            mana = 10;
            x = 0;
            y = 100;
        }

        public Wizards(int _X,int _Y, int _Mana, int _Health, int _WizardSelection,int _size, string _name)
        {
            x= _X;
            y = _Y;
            mana = _Mana;
            health = _Health;
            wizardSelection= _WizardSelection;
            name = _name;
            size = _size;
        }
    }
}
