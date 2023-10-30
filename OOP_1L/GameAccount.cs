using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_1L
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
                if(currentRating < 1)
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

        public List<Game> GamesHistory = new List<Game>();

        public void CheckRating(int rating)
        {
            if (rating < 0)
            {
                throw new InvalidOperationException("Rating is negative");
            }
        }

        public void WinGame(int rating, string opponentName)
        {
            CheckRating(rating);

            Game game = new Game();
            game.OpponentName = opponentName;
            game.Rating = rating;
            game.Result = GameResult.Win;
            game.GameId = GamesCount + 1;

            CurrentRating = CurrentRating + rating;

            GamesHistory.Add(game);
        }

        public void LoseGame(int rating, string opponentName)
        {
            CheckRating(rating);

            Game game = new Game();
            game.OpponentName = opponentName;
            game.Rating = rating;
            game.Result = GameResult.Lose;
            game.GameId = GamesCount + 1;

            CurrentRating = CurrentRating - rating;

            GamesHistory.Add(game);
        }

        public void GetStats()
        {
            Console.WriteLine(this.UserName + "`s rating");
            foreach (var item in GamesHistory)
            {
                 Console.WriteLine($"GameId: {item.GameId}");
                 Console.WriteLine($"Rating: {item.Rating}");
                 Console.WriteLine($"Result: {item.Result}");
                 Console.WriteLine($"Opponent Name: {item.OpponentName}\n");
            }
                
        }
    }
}
