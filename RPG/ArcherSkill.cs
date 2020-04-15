using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class ArcherSkill : IUseSkill
    {
        public void UseSkill(Player user)
        {
            if (!user.SkillUsed)
            {
                user.Opponent.IsDebuffed = true;
                Logger.LogMessage($"({user.Class}) {user.Name} использует (Огненные стрелы) на ({user.Opponent.Class}) {user.Opponent.Name}.");
                user.SkillUsed = true;
            }
            else
            {
                user.Attack();
            }
        }
    }
}
