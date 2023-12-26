using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
    public class DoublePointsGameAccount : GameAccount
    {

        public DoublePointsGameAccount(string name) : base(name) { }

        public int WinCounter { get; set; }

        public override void WinGame(AbstractGame game)
        {
            game.Result = GameResult.Win;
            game.GameId = GamesCount + 1;

            WinCounter = WinCounter + 1;

            if (WinCounter > 1)
            {
                CurrentRating = CurrentRating + (game.Rating * 2);
            }
            else
            {
                CurrentRating = CurrentRating + game.Rating;
            }

            GamesHistory.Add(game);
        }

        public override void LoseGame(AbstractGame game)
        {
            game.Result = GameResult.Lose;
            game.GameId = GamesCount + 1;

            WinCounter = 0;

            CurrentRating = CurrentRating - (game.Rating * 4);

            GamesHistory.Add(game);
        }
    }
}
