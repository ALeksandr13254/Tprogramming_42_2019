using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class ArcherSkill : IUseSkill
    {
        private int timesUsedSkill = 0;

        public void UseSkill(Player user)
        {
            if (timesUsedSkill < 1)
            {
                user.Opponent.Effects.Add("Огненные стрелы");
                Logger.LogMessage($"({user.Class}) {user.Name} использует (Огненные стрелы) на ({user.Opponent.Class}) {user.Opponent.Name}.");
                timesUsedSkill++;
            }
            else
            {
                user.UsingSkill = new Attack();
                user.UseSkill();
            }
        }
    }
}
