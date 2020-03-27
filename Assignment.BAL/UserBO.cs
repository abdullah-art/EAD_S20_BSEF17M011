using Assignment.DAL;
using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BAL
{
    public static class UserBO
    {
        public static int Save(UserDTO userDTO)
        {
            return UserDAO.Save(userDTO);
        }

        public static UserDTO validateUser(String login, String password, String email, int uid, int flag)
        {
            return UserDAO.validateUser(login, password, email, uid, flag);
        }

        public static int validateUserWithEmail(String email)
        {
            int count = UserDAO.validateUserWithEmail(email);
            return count;
        }


        public static UserDTO getUserDTOById(int userId)
        {
            return UserDAO.getUserDTOById(userId);
        }

        public static UserDTO getUserDTOByEmail(String email)
        {
            return UserDAO.getUserDTOByEmail(email);
        }


    }
}
