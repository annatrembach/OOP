using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
        public class InfoGamesByIdUI : IUserInterface
        {
            IGameService gameService;
            public InfoGamesByIdUI(DbContext context)
            {
                gameService = new GameService(context);
            }
            public string Action()
            {
                Console.WriteLine("Enter User id:");
                int userid;
                var validId = int.TryParse(Console.ReadLine(), out userid);
                if (!validId)
                    return "Can`t find user. Invalid ID.";
                var games = gameService.ReadUsersGamesByUserId(userid); ;
                string result = "";
                foreach (var gameEntity in games)
                {
                    result += gameEntity.GetInfo() + "\n";
                }
                return result;
            }
            public string Show()
            {
                return $"Show User games by Id";
            }
        }
}
