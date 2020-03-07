using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RPG
{
    public class MageSkill : IUseSkill
    {
        public void UseSkill(Player user)
        {
            user.Opponent.Effects.Add("Заворожение");
            Logger.LogMessage($"({user.Class}) {user.Name} использует (Заворожение) на ({user.Opponent.Class}) {user.Opponent.Name}.");
        }
    }
}
