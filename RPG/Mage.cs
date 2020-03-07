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
        : this(name, null)
        {
        }

        public Mage(string name, Player opponent)
        : base(name, opponent)
        {
            Skills.Add(new MageSkill());
            Class = "Маг";
        }
    }
}
