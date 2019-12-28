using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class PickPlayers
    {
        public static int PickOp(List<Player> kon_x)
        {
            Random rand = new Random();
            int randPlayer1 = rand.Next(0, kon_x.Count);
            int randPlayer2 = rand.Next(0, kon_x.Count);
            while (randPlayer1 == randPlayer2)
            {
                randPlayer2 = rand.Next(0, kon_x.Count);
            }

            kon_x[randPlayer1].Opponent = kon_x[randPlayer2];
            kon_x[randPlayer2].Opponent = kon_x[randPlayer1];
            return randPlayer1;
        }
    }
}
