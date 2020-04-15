﻿using Assignment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BAL
{
    static public class UserBO
    {
        public static bool validateUser(String login, String password)
        {
            return UserDAO.validateUser(login, password);
        }
    }
}
