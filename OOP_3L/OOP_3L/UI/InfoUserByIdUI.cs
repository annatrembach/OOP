using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
    public class InfoUserByIdUI : IUserInterface
    {
        IUserService userService;
        UserEntity userEntity = new UserEntity();
        public InfoUserByIdUI(DbContext context)
        {
            userService = new UserService(context);
        }
        public string Action()
        {
            Console.WriteLine("Enter User id:");
            int userid;
            var validId = int.TryParse(Console.ReadLine(), out userid);
            if (!validId)
                return "Can`t find user. Invalid ID.";
            var user = userService.ReadAccountbyId(userid);
            string result = "";
            result += user.GetInfo();
            return result;
        }
        public string Show()
        {
            return $"Show User info by Id";
        }
    }
}
