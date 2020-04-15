using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public static class Battle
    {
        public static Player BattlePlayers(Player p)
        {
            Logger.LogBattle(p);
            Random rand = new Random();
            while (p.Hp > 0 && p.Opponent.Hp > 0)
            {
                int randomSkill1 = rand.Next(0, p.Skills.Count);
                int randomSkill2 = rand.Next(0, p.Opponent.Skills.Count);
                p.SrabatEffects();
                if (p.IsStunned == false)
                {
                    p.Usingskill = p.Skills[randomSkill1];
                    p.UseSkill();
                }
                else
                {
                    p.IsStunned = false;
                    for (int i = 0; i < p.Effects.Count; i++)
                    {
                        if (p.Effects[i] is Skip)
                        {
                            p.Effects.RemoveAt(i);
                            i--;
                        }
                    }
                }

                p.Opponent.SrabatEffects();

                if (p.Opponent.Hp > 0)
                {
                    if (p.Opponent.IsStunned == false)
                    {
                        p.Opponent.Usingskill = p.Opponent.Skills[randomSkill2];
                        p.Opponent.UseSkill();
                    }
                    else
                    {
                        p.Opponent.IsStunned = false;
                        for (int i = 0; i < p.Opponent.Effects.Count; i++)
                        {
                            if (p.Opponent.Effects[i] is Skip)
                            {
                                p.Opponent.Effects.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
            }

            if (p.Hp < 1)
            {
                Logger.LogMessage($"({p.Class}) {p.Name} погиб!\n");
                p.Opponent.Hp = rand.Next(1, 100);
                p.Opponent.Effects.Clear();
                return p;
            }
            else if (p.Opponent.Hp < 1)
            {
                Logger.LogMessage($"({p.Opponent.Class}) {p.Opponent.Name} погиб!\n");
                p.Hp = rand.Next(1, 100);
                p.Effects.Clear();
                return p.Opponent;
            }

            throw new Exception("Ошибка!!!");
        }
    }
}
