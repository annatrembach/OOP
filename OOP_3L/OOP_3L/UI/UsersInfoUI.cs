﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3L
{
    public class UsersInfoUI : IUserInterface
    {
        IUserService userService;
        public UsersInfoUI(DbContext context)
        {
            userService = new UserService(context);
        }
        public string Action()
        {
            var users = userService.ReadAccounts();
            string result = "";
            foreach (var userEntity in users)
            {
                result += userEntity.GetInfo() + "\n";
            }
            return result;
        }
        public string Show()
        {
            return "Show all users";
        }
    }
}
