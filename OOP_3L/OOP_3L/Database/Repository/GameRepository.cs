using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
    public class GameRepository : IGameRepository
    {
        private readonly DbContext dbcontext;
        public GameRepository(DbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public void Create(GameEntity game)
        {
            dbcontext.Games.Add(game);
        }

        public void Delete(int Id)
        {
            dbcontext.Games.Remove(ReadGamebyId(Id));
        }

        public IEnumerable<GameEntity> Read()
        {
            return dbcontext.Games;
        }

        public void Update(GameEntity game)
        {
            dbcontext.Games.Remove(ReadGamebyId(game.GameId));
            dbcontext.Games.Add(game);
        }

        public GameEntity ReadGamebyId(int searchId)
        {
            foreach (GameEntity game in Read())
            {
                if (game.GameId == searchId)
                {
                    return game;
                }
            }
            return null;
        }

    }
}
