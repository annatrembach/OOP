using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
    public interface IGameService
    {
        public bool CreateGame(AbstractGame game, GameType gameType);
        public List<AbstractGame> ReadGame();
        public List<AbstractGame> ReadUsersGamesByUserId(int searchId);
    }
}
