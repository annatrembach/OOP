using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2L
{
    public class WithoutDeductionPointsGame : AbstractGame
    {
        public WithoutDeductionPointsGame(GameAccount firstUserName, GameAccount secondUserName)
        {
            FirstUser = firstUserName;
            SecondUser = secondUserName;
            Rating = 0;
        }

        public override int GetRating()
        {
            return Rating;
        }
    }
}
