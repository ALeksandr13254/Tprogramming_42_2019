using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public static class Battle
    {
        public static Player BattlePlayers(Player p)
        {
            Random rand = new Random();
            while (p.Hp > 0 && p.Opponent.Hp > 0)
            {
                int randomSkill1 = rand.Next(0, p.Skills.Count);
                int randomSkill2 = rand.Next(0, p.Opponent.Skills.Count);
                if (p.Hp > 0)
                {
                    p.UsingSkill = p.Skills[randomSkill1];
                    p.UseSkill();
                }

                if (p.Opponent.Hp > 0)
                {
                    p.Opponent.UsingSkill = p.Opponent.Skills[randomSkill2];
                    p.Opponent.UseSkill();
                }
            }

            if (p.Hp < 1)
            {
                Logger.LogMessage($"({p.Class}) {p.Name} погиб!\n");
                p.Opponent.Hp = rand.Next(1, 100);
                p.Opponent.Effects.Remove("Огненные стрелы");
                return p;
            }
            else if (p.Opponent.Hp < 1)
            {
                Logger.LogMessage($"({p.Opponent.Class}) {p.Opponent.Name} погиб!\n");
                p.Hp = rand.Next(1, 100);
                p.Effects.Remove("Огненные стрелы");
                return p.Opponent;
            }

            throw new Exception("Ошибка!!!");
        }
    }
}
