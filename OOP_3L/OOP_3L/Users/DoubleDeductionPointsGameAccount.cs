using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
    public class DoubleDeductionPointsGameAccount : GameAccount
    {
        public DoubleDeductionPointsGameAccount(string name) : base(name) { }

        public int LoseCounter { get; set; }

        public override void WinGame(AbstractGame game)
        {
            game.Result = GameResult.Win;
            game.GameId = GamesCount + 1;

            CurrentRating = CurrentRating + game.Rating;

            LoseCounter = 0;

            GamesHistory.Add(game);
        }

        public override void LoseGame(AbstractGame game)
        {
            game.Result = GameResult.Lose;
            game.GameId = GamesCount + 1;

            LoseCounter = LoseCounter + 1;

            if (LoseCounter > 2)
            {
                CurrentRating = CurrentRating - (game.Rating * LoseCounter);
            }

            GamesHistory.Add(game);
        }
    }
}
