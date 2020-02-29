using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public static class Logger
    {
        public static void LogBattle(Player player)
        {
            Console.WriteLine($"{player.Class} {player.Name} vs {player.Opponent.Class} {player.Opponent.Name}.");
        }

        public static void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
