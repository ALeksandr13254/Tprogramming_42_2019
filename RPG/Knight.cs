using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Knight : Player
    {
        public Knight()
        : this("Без имени")
        {
        }

        public Knight(string name)
        : this(name, null)
        {
        }

        public Knight(string name, Player opponent)
        : base(name, opponent)
        {
            Skills.Add(new KnightSkill());
            Class = "Рыцарь";
        }
    }
}
