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
        : this(name, null)
        {
        }

        public Archer(string name, Player opponent)
        : base(name, opponent)
        {
            Skills.Add(new ArcherSkill());
            Class = "Лучник";
        }
    }
}
