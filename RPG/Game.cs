using System;
using System.Collections.Generic;

namespace RPG
{
    public class Game
    {
        public static void Main(string[] args)
        {
            int kol = 0;
            try
            {
                Console.Write($"Введите кол-во игроков(1-16):");
                string kolString = Console.ReadLine();
                kol = Convert.ToInt32(kolString);
            }
            catch (System.FormatException)
            {
                Console.Write($"Введите кол-во игроков(1-16):");
                string kolString = Console.ReadLine();
                kol = Convert.ToInt32(kolString);
            }

            while (kol % 2 != 0 || kol <= 0)
            {
                Console.Write($"Введите кол-во игроков(1-16):");
                kol = Convert.ToInt32(Console.ReadLine());
            }

            string[] playersNames = { "Игрок1", "Игрок2", "Игрок3", "Игрок4", "Игрок5", "Игрок6", "Игрок7", "Игрок8", "Игрок9", "Игрок10", "Игрок11", "Игрок12", "Игрок13", "Игрок14", "Игрок15", "Игрок16" };
            List<Player> konA = new List<Player>();
            List<Player> konB = new List<Player>();
            int kon = 1;
            int n = 0;
            Random rand = new Random();
            while (konA.Count < kol)
            {
                int r = rand.Next(0, 3);
                switch (r)
                {
                    case 0:
                        konA.Add(new Knight(playersNames[n]));
                        break;
                    case 1:
                        konA.Add(new Archer(playersNames[n]));
                        break;
                    case 2:
                        konA.Add(new Mage(playersNames[n]));
                        break;
                }

                n++;
            }

            Logger.LogMessage($"{kon++}-й Кон\n");
            while (konA.Count + konB.Count > 1)
            {
                if (konA.Count > 1 && !(konA.Count < 2))
                {
                    Player tempPlayer = Battle.BattlePlayers(konA[PickPlayers.PickOp(konA)]);
                    konB.Add(tempPlayer.Opponent);
                    konA.Remove(tempPlayer.Opponent);
                    konA[konA.IndexOf(tempPlayer)].Opponent.Opponent = null;
                    konA.Remove(tempPlayer);
                }
                else
                {
                    Logger.LogMessage($"{kon}-й Кон\n");
                    konA.AddRange(konB);
                    konB.Clear();
                    kon++;
                }
            }

            Logger.LogMessage($"({konB[0].Class}) {konB[0].Name} Победил!!!");
        }
    }
}
