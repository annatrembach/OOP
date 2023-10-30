using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1L
{
    public enum GameResult
    {
        Lose,
        Win
    }

    public class Game
    {
        public Game() { }

        public string OpponentName { get; set; }
        public int Rating { get; set; }
        public GameResult Result { get; set; }
        public int GameId { get; set; }
    }
}
