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
        : this(name, null)
        {
        }

        public Player(string name, Player opponent)
        {
            Skills = new List<IUseSkill>();
            Effects = new List<string>();
            this.Name = name;
            this.Opponent = opponent;
            Skills.Add(new Attack());
        }

        public string Class { get; protected set; }

        public string Name { get; set; }

        public Player Opponent { get; set; } = null;

        public double Hp { get; set; } = rand.Next(1, 101);

        public int Strength { get; } = rand.Next(1, 101);

        public List<IUseSkill> Skills { get; set; }

        public List<string> Effects { get; set; }

        public IUseSkill UsingSkill { get; set; }

        public void UseSkill()
        {
            if (!Effects.Any(item => item == "Заворожение"))
            {
                if (!Effects.Any(item => item == "Огненные стрелы"))
                {
                    UsingSkill.UseSkill(this);
                }
                else
                {
                    Hp -= 2;
                    Logger.LogMessage($"({Class}) {Name} получает урон 2 от (Огненные стрелы).");
                    UsingSkill.UseSkill(this);
                }
            }
            else
            {
                Logger.LogMessage($"({Class}) {Name} пропускает ход.");
                Effects.Remove("Заворожение");
            }
        }
    }
}
