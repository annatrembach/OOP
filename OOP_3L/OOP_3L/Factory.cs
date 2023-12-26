using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
    internal class Factory
    {
        public AbstractGame CreateStandartGame(GameAccount firstUserName, GameAccount secondUserName)
        {
            StandartGame game = new StandartGame(firstUserName, secondUserName);
            AbstractGame newGame = game;
            return newGame;
        }

        public AbstractGame CreateWithoutDeductionPointsGame(GameAccount firstUserName, GameAccount secondUserName)
        {
            WithoutDeductionPointsGame game = new WithoutDeductionPointsGame(firstUserName, secondUserName);
            return game;
        }
    }
}
