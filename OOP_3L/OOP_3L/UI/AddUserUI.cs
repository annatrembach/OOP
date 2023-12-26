using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;

namespace OOP_3L
{
    public class AddUserUI : IUserInterface
    {
        IUserService userService;
        public AddUserUI(DbContext context)
        {
            userService = new UserService(context);
        }
        public string Action()
        {
            //username
            string userName;
            Console.WriteLine("Enter User username:");
            userName = Console.ReadLine();

            //usertype
            //UserEntity userEntity = new UserEntity();
            GameAccount userEntity;
            Console.WriteLine("Choose type of User:\r\n\t\tGame Account[0],\r\n\t\tDouble Deduction Points Game Account[1],\r\n\t\tDouble Points Game Account[2]");
            UserType userTypeEnum;
            string usertype = Console.ReadLine();
            if (usertype[0] != '0' && usertype[0] != '1' && usertype[0] != '2')
                return "Can`t create user. Unknown student type.";
            if (usertype[0] == '1')
            {
                userEntity = new DoubleDeductionPointsGameAccount(userName);
                userTypeEnum = UserType.DoubleDeductionPointsGameAccount;
            }
            else
            {
                if(usertype[0] == '2')
                {
                    userEntity = new DoublePointsGameAccount(userName);
                    userTypeEnum = UserType.DoublePointsGameAccount;
                }
                else
                {
                    userEntity = new GameAccount(userName);
                    userTypeEnum = UserType.GameAccount;
                }
            }
            
            //userid
            Console.WriteLine("Enter User id:");
            int id;
            var validId = int.TryParse(Console.ReadLine(), out id);
            if (!validId)
                return "Can`t create user. Invalid ID.";
            userEntity.Id = id;
            try
            {
                var result = userService.CreateAccount(userEntity, userTypeEnum);
                return "Student added";
            }
            catch (Exception e)
            {
                return $"Can`t add user. {e.Message}";
            }
        }
        public string Show()
        {
            return "Add User.";
        }

    }
}
