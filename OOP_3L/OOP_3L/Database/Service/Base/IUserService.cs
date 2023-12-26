using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
    public interface IUserService
    {
        public bool CreateAccount(GameAccount user, UserType userType);
        public List<GameAccount> ReadAccounts();
        public GameAccount ReadAccountbyId(int searchId);
    }
}
