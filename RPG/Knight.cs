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
        : base(name)
        {
            Class = "Рыцарь";
            Skills.Add(new KnightSkill());
        }
    }
}
