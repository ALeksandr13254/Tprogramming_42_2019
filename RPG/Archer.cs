using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Archer : Player
    {
        public Archer()
        : this("Без имени")
        {
        }

        public Archer(string name)
        : base(name)
        {
            Class = "Лучник";
            Skills.Add(new ArcherSkill());
        }
    }
}
