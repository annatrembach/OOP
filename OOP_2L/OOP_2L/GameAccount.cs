using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_2L
{
    public class GameAccount
    {
        public GameAccount(string name)
        {
            UserName = name;
            CurrentRating = 1;
        }

        public string UserName { get; set; }

        private int currentRating;
        public int CurrentRating
        {
            get { return currentRating; }
            set
            {
                currentRating = value;
                if (currentRating < 1)
                {
                    currentRating = 1;
                }
            }
        }
        public int GamesCount
        {
            get
            {
                return GamesHistory.Count;
            }
        }

        public List<AbstractGame> GamesHistory = new List<AbstractGame>();

        public virtual void WinGame(AbstractGame game)
        { 
            game.Result = GameResult.Win;
            game.GameId = GamesCount + 1;

            CurrentRating = CurrentRating + game.Rating;

            GamesHistory.Add(game);
        }

        public virtual void LoseGame(AbstractGame game)
        { 
            game.Result = GameResult.Lose;
            game.GameId = GamesCount + 1;

            CurrentRating = CurrentRating - game.Rating;

            GamesHistory.Add(game);
        }

        public void GetStats()
        {
            Console.WriteLine(this.UserName + "`s rating:" + this.CurrentRating);
            foreach (var item in GamesHistory)
            {
                Console.WriteLine($"GameId: {item.GameId}");
                Console.WriteLine($"Rating: {item.Rating}");
                Console.WriteLine($"Result: {item.Result}");
                Console.WriteLine($"First User Name: {item.FirstUser.UserName}");
                Console.WriteLine($"Second User Name: {item.SecondUser.UserName}\n");
            }

        }
    }
}
