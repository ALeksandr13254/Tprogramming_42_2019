using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Attack : IUseSkill
    {
        public void UseSkill(Player user)
        {
            user.Opponent.Hp -= user.Strength;
            Logger.LogMessage($"({user.Class}) {user.Name} наносит урон {user.Strength} противнику ({user.Opponent.Class}) {user.Opponent.Name}.");
        }
    }
}
