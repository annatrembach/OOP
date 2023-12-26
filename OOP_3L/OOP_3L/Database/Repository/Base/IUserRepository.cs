using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
    public interface IUserRepository
    {
        public void Create(UserEntity user);
        public IEnumerable<UserEntity> Read();
        public void Update(UserEntity user);
        public void Delete(int Id);
        public UserEntity ReadAccountbyId(int searchId);
    }
}
