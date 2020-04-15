using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class FireArrow : IEffects
    {
        public const int DamageFireArrow = 2;

        public void Proc(Player owner)
        {
            owner.Hp -= DamageFireArrow;
            Logger.LogMessage($"({owner.Class}) {owner.Name} получает урон {DamageFireArrow} от эффекта Fire Arrow.");
        }
    }
}
