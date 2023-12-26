using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
    public class DbContext
    {
        public List<UserEntity> Users { get; set; }
        public List<GameEntity> Games { get; set; }

        public DbContext() {
            Users = new List<UserEntity>
            {
                new UserEntity {Id = 1, UserName = "Anna", CurrentRating = 1000, Type = UserType.GameAccount},
                new UserEntity {Id = 2, UserName = "Anastasiia", CurrentRating = 1000, Type = UserType.GameAccount},
                new UserEntity {Id = 3, UserName = "Tom", CurrentRating = 1000, Type = UserType.GameAccount},
                new UserEntity {Id = 4, UserName = "Bob", CurrentRating = 1000, Type = UserType.GameAccount}
            };
            Games = new List<GameEntity>
            {
                new GameEntity{FirstUserId = 1, SecondUserId = 2, Rating = 1000, Result = GameResult.Win, GameId = 1, Type = GameType.StandartGame},
                new GameEntity{FirstUserId = 3, SecondUserId = 4, Rating = 100, Result = GameResult.Win, GameId = 2, Type = GameType.StandartGame},
                new GameEntity{FirstUserId = 1, SecondUserId = 2, Rating = 1000, Result = GameResult.Lose, GameId = 3, Type = GameType.StandartGame},
            };
        }
        
    }
}
