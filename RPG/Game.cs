using System;
using System.Collections.Generic;

namespace RPG
{
    public class Game
    {
        public static void Main(string[] args)
        {
            string[] players_names = { "Игрок1", "Игрок2", "Игрок3", "Игрок4", "Игрок5", "Игрок6", "Игрок7", "Игрок8", "Игрок9", "Игрок10", "Игрок11", "Игрок12", "Игрок13", "Игрок14", "Игрок15", "Игрок16" };
            int kol = 0;
            try
            {
                Console.Write($"Введите кол-во игроков(1-16):");
                string nString = Console.ReadLine();
                kol = Convert.ToInt32(nString);
            }
            catch (System.FormatException)
            {
                Console.Write($"Введите кол-во игроков(1-16):");
                string nString = Console.ReadLine();
                kol = Convert.ToInt32(nString);
            }

            while (kol % 2 != 0 || kol <= 0)
            {
                Console.Write($"Введите кол-во игроков(1-16):");
                kol = Convert.ToInt32(Console.ReadLine());
            }

            Random rand = new Random();
            List<Player> kon_a = new List<Player>();
            List<Player> kon_b = new List<Player>();
            int k = 0;
            int kon = 1;
            while (kon_a.Count < kol)
            {
                int r = rand.Next(0, 3);
                switch (r)
                {
                    case 0:
                        kon_a.Add(new Knight(players_names[k]));
                        break;
                    case 1:
                        kon_a.Add(new Archer(players_names[k]));
                        break;
                    case 2:
                        kon_a.Add(new Mage(players_names[k]));
                        break;
                }

                k++;
            }

            Logger.LogMessage($"{kon++}-й Кон\n");
            while (kon_a.Count + kon_b.Count > 1)
            {
                if (kon_a.Count >= 2)
                {
                    Player tempPlayer = Battle.BattlePlayers(kon_a[PickPlayers.PickOp(kon_a)]);
                    kon_b.Add(tempPlayer.Opponent);
                    kon_a.Remove(tempPlayer.Opponent);
                    kon_a[kon_a.IndexOf(tempPlayer)].Opponent.Opponent = null;
                    kon_a.Remove(tempPlayer);
                }
                else
                {
                    Logger.LogMessage($"{kon}-й Кон\n");
                    kon_a.AddRange(kon_b);
                    kon_b.Clear();
                    kon++;
                }
            }

            Logger.LogMessage($"({kon_b[0].Class}) {kon_b[0].Name} Победил!!!");
        }
    }
}
