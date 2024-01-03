using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
    public class AddGameUI : IUserInterface
    {
        IGameService gameService;
        IUserService userService;
        Random rndm;
        public AddGameUI(DbContext context)
        {
            gameService = new GameService(context);
            userService = new UserService(context);
            rndm = new Random();
        }
        public string Action()
        {
            //gametype
            AbstractGame gameEntity;
            Console.WriteLine("Choose type of Game:\r\n\t\tStandart game[0],\r\n\t\tWithout Deduction Points Game[1]");
            GameType gameTypeEnum;
            string gametype = Console.ReadLine();
            if (gametype[0] != '0' && gametype[0] != '1' && gametype[0] != '2')
                return "Unknown game type.";
            if (gametype[0] == '1')
            {
                gameEntity = new WithoutDeductionPointsGame();
                gameTypeEnum = GameType.WithoutDeductionPointsGame;
            }
            else
            {
                gameEntity = new StandartGame();
                gameTypeEnum = GameType.StandartGame;
            }

            //firstid
            Console.WriteLine("Enter User id:");
            int firstuserid;
            var firstvalidId = int.TryParse(Console.ReadLine(), out firstuserid);
            if (!firstvalidId)
                return "Can`t find user. Invalid ID.";
            gameEntity.FirstUser = userService.ReadAccountbyId(firstuserid);

            //secondid
            Console.WriteLine("Enter User id:");
            int seconduserid;
            var secondvalidId = int.TryParse(Console.ReadLine(), out seconduserid);
            if (!secondvalidId)
                return "Can`t find user. Invalid ID.";
            gameEntity.SecondUser = userService.ReadAccountbyId(seconduserid);

            //rating
            Console.WriteLine("Enter Rating Users are playing for:");
            int rating;
            var validrating = int.TryParse(Console.ReadLine(), out rating);
            if (!validrating)
                return "Invalid Rating.";
            gameEntity.Rating = rating;

            //result
            int result = rndm.Next(0, 2);
            if (result != 0 && result != 1)
                return "Invalid Result.";
            if (result == 1)
            {
                gameEntity.Result = GameResult.Win;
                Console.WriteLine($"User {firstuserid} {gameEntity.Result}");
            }
            else
            {
                gameEntity.Result = GameResult.Lose;
                Console.WriteLine($"User {firstuserid} {gameEntity.Result}");
            }

            //gameid
            Console.WriteLine("Enter Game id:");
            int gameid;
            var validId = int.TryParse(Console.ReadLine(), out gameid);
            if (!validId)
                return "Invalid ID.";
            gameEntity.GameId = gameid;
            try
            {
                var resultAddGame = gameService.CreateGame(gameEntity, gameTypeEnum);
                return "Game added";
            }
            catch (Exception e)
            {
                return $"Can`t add game. {e.Message}";
            }

        }
        public string Show()
        {
                return "Add Game.";
        }
    }
       
}
