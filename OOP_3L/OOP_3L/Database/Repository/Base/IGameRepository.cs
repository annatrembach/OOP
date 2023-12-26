using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
    public interface IGameRepository
    {
        public void Create(GameEntity game);
        public IEnumerable<GameEntity> Read();
        public void Update(GameEntity game);
        public void Delete(int Id);
        public GameEntity ReadGamebyId(int searchId);


    }
}
