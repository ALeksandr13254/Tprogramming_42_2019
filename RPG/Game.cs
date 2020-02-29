using System;
using System.Collections.Generic;

namespace RPG
{
    public class Game
    {
        public static void Main(string[] args)
        {
            Console.Write($"Введите кол-во игроков (1-16):");
            int kol = Convert.ToInt32(Console.ReadLine());
            if (kol <= 0)
            {
                throw new Exception("Ошибка!!!");
            }

            string[] players_names = { "Игрок1", "Игрок2", "Игрок3", "Игрок4", "Игрок5", "Игрок6", "Игрок7", "Игрок8", "Игрок9", "Игрок10", "Игрок11", "Игрок12", "Игрок13", "Игрок14", "Игрок15", "Игрок16" };
            List<Player> kon_a = new List<Player>();
            List<Player> kon_b = new List<Player>();
            int kon = 1;
            int n = 0;
            Random rand = new Random();
            while (kon_a.Count < kol)
            {
                int r = rand.Next(0, 3);
                if (r == 0)
                {
                    kon_a.Add(new Knight(players_names[n]));
                }

                if (r == 1)
                {
                    kon_a.Add(new Archer(players_names[n]));
                }

                if (r == 2)
                {
                    kon_a.Add(new Mage(players_names[n]));
                }

                n++;
            }

            Logger.LogMessage($"{kon++}-й Кон\n");
            while (kon_a.Count + kon_b.Count > 1)
            {
                if (kon_a.Count > 1 && !(kon_a.Count < 2))
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
            Console.ReadLine();
        }
    }
}
