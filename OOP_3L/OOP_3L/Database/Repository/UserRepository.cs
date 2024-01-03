using OOP_3L;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
    internal class UserRepository : IUserRepository
    {
        private readonly DbContext dbcontext;
        public UserRepository(DbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public void Create(UserEntity user)
        {
            dbcontext.Users.Add(user);
        }

        public void Delete(int Id)
        {
            dbcontext.Users.Remove(ReadAccountbyId(Id));
        }

        public IEnumerable<UserEntity> Read()
        {
            return dbcontext.Users;
        }

        public void Update(UserEntity user)
        {
            dbcontext.Users.Remove(ReadAccountbyId(user.Id));
            dbcontext.Users.Add(user);
        }

        public UserEntity ReadAccountbyId(int searchId)
        {
            foreach (UserEntity user in Read())
            {
                if (user.Id == searchId)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
