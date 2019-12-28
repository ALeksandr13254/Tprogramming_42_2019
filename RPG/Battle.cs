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
                int useSkill1 = rand.Next(0, 2);
                int useSkill2 = rand.Next(0, 2);
                if (useSkill1 == 0 && p.Hp > 0)
                {
                    p.Attack();
                }
                else if (useSkill1 == 1 && p.Hp > 0)
                {
                    p.UseSkill();
                }

                if (useSkill2 == 0 && p.Opponent.Hp > 0)
                {
                    p.Opponent.Attack();
                }
                else if (useSkill2 == 1 && p.Opponent.Hp > 0)
                {
                    p.Opponent.UseSkill();
                }
            }

            if (p.Hp < 1)
            {
                Logger.LogMessage($"({p.Class}) {p.Name} погиб!\n");
                p.Opponent.Hp = rand.Next(1, 100);
                p.Opponent.IsDebuffed = false;
                return p;
            }
            else if (p.Opponent.Hp < 1)
            {
                Logger.LogMessage($"({p.Opponent.Class}) {p.Opponent.Name} погиб!\n");
                p.Hp = rand.Next(1, 100);
                p.IsDebuffed = false;
                return p.Opponent;
            }

            throw new Exception("Ошибка!!!");
        }
    }
}
