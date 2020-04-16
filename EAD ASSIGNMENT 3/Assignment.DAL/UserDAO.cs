using Assignment.Entities;
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

        public static int save(UserDTO user)
        {
            String query = String.Format("INSERT INTO eadproject.user(name, login, password) VALUES('{0}', '{1}', '{2}')", user.name, user.login, user.password);
            query = query + "; Select LAST_INSERT_ID()";
            using (ConnectionMySql connection = new ConnectionMySql())
            {
                int userId=0;
                if(user.id==0)
                {
                    try
                    {
                        var recs = connection.ExcueteScalar(query);
                        String res = recs.ToString();
                        userId = Int32.Parse(res);
                    }
                    catch(Exception e)
                    {
                        userId = 0;
                    }
                }
                return userId;
            }

        }
    }
}
