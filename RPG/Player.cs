using System;
using System.Collections.Generic;
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
            this.Name = name;
            this.Opponent = opponent;
        }

        public string Class { get; protected set; }

        public string Name { get; set; }

        public Player Opponent { get; set; } = null;

        public double Hp { get; set; } = rand.Next(1, 101);

        public int Strength { get; } = rand.Next(1, 101);

        public bool IsDebuffed { get; set; } = false;

        public bool IsSkipped { get; set; } = false;

        public bool SkillUsed { get; set; } = false;

        internal IUseSkill Usingskill { get; set; }

        public void Skip()
        {
        }

        public virtual void Attack()
        {
            if (!IsSkipped)
            {
                if (!IsDebuffed)
                {
                    Opponent.Hp -= Strength;
                    Logger.LogMessage($"({Class}) {Name} наносит урон {Strength} противнику ({Opponent.Class}) {Opponent.Name}.");
                }
                else
                {
                    Hp -= 2;
                    Logger.LogMessage($"({Class}) {Name} получает урон 2 от (Огненные стрелы).");
                    Opponent.Hp -= Strength;
                    Logger.LogMessage($"({Class}) {Name} наносит урон {Strength} противнику ({Opponent.Class}) {Opponent.Name}.");
                }
            }
            else
            {
                Logger.LogMessage($"({Class}) {Name} пропускает ход.");
                IsSkipped = false;
            }
        }

        public void UseSkill()
        {
            if (!IsSkipped)
            {
                if (!IsDebuffed)
                {
                    Usingskill.UseSkill(this);
                }
                else
                {
                    Hp -= 2;
                    Logger.LogMessage($"({Class}) {Name} получает урон 2 от (Огненные стрелы).");
                    Usingskill.UseSkill(this);
                }
            }
            else
            {
                Logger.LogMessage($"({Class}) {Name} пропускает ход.");
                IsSkipped = false;
            }
        }
    }
}
