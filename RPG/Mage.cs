using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Mage : Player
    {
        public Mage()
        : this("Без имени")
        {
        }

        public Mage(string name)
        : base(name)
        {
            Class = "Маг";
            Skills.Add(new MageSkill());
        }
    }
}
