using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.DAL
{
    public static class UserDAO
    {
        public static bool validateUser(String login, String password)
        {
            String query = String.Format("SELECT * FROM eadproject.user where login='{0}' and password='{1}'", login, password);
            using (ConnectionMySql connection = new ConnectionMySql())
            {
                var reader = connection.ExcueteReader(query);
                if (reader.Read())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
