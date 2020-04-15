using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class ArcherSkill : IUseSkill
    {
        private int timeSkillUsed = 0;

        public void UseSkill(Player user)
        {
            if (timeSkillUsed < 1)
            {
                user.Opponent.Effects.Add(new FireArrow());
                Logger.LogMessage($"({user.Class}) {user.Name} использует (Огненные стрелы) на ({user.Opponent.Class}) {user.Opponent.Name}.");
                timeSkillUsed++;
            }
            else
            {
                user.Usingskill = new Attack();
                user.UseSkill();
            }
        }
    }
}
