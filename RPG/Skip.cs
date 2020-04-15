using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Skip : IEffects
    {
        public void Proc(Player owner)
        {
            owner.IsStunned = true;
            Logger.LogMessage($"({owner.Class}) {owner.Name} пропускает ход.");
        }
    }
}
