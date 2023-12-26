using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOP_3L
{
    public class GamesInfoUI : IUserInterface
    {
        IGameService gameService;
        public GamesInfoUI(DbContext context)
        {
            gameService = new GameService(context);
        }
        public string Action()
        {
            var games = gameService.ReadGame();
            string result = "";
            foreach (var gameEntity in games)
            {
                result += gameEntity.GetInfo() + "\n";
            }
            return result;
        }
        public string Show()
        {
            return "Show all games";
        }
    }
}
