using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RPG
{
    public abstract class Player
    {
        private static Random rand = new Random();

        public Player()
        : this("Без имени")
        {
        }

        public Player(string name)
        {
            Name = name;
            Hp = rand.Next(1, 100);
            Strength = rand.Next(1, 99);
            Skills = new List<IUseSkill>();
            Effects = new List<IEffects>();
            Skills.Add(new Attack());
        }

        public string Class { get; protected set; }

        public string Name { get; set; }

        public Player Opponent { get; set; } = null;

        public double Hp { get; set; }

        public int Strength { get; }

        public bool IsStunned { get; set; }

        public IUseSkill Usingskill { get; set; }

        public List<IUseSkill> Skills { get; set; }

        public List<IEffects> Effects { get; set; }

        public void UseSkill()
        {
            {
                Usingskill.UseSkill(this);
            }
        }

        public void ProcEffects()
        {
            for (int i = 0; i < Effects.Count; i++)
            {
                    Effects[i].Proc(this);
            }
        }
    }
}
