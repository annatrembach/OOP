using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
    public class StandartGame : AbstractGame
    {
        public StandartGame()
        {
        }

        public StandartGame(GameAccount firstUserName,GameAccount secondUserName)
        {
            FirstUser = firstUserName;
            SecondUser = secondUserName;
            Rating = 1000;
        }

        public override int GetRating()
        {
            return Rating;  
        }
    }
}