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
        public static UserDTO validateUser(String login, String password)
        {
            String query = String.Format("SELECT * FROM [dbo].[user] where login='{0}' and password='{1}'", login, password);
            using (ConnectionSQLServer connection = new ConnectionSQLServer())
            {
                UserDTO user = new UserDTO();
                var reader = connection.ExcueteReader(query);
                if (reader.Read())
                {
                    user.id = reader.GetInt32(0);
                    user.login = reader.GetString(1);
                    user.name = reader.GetString(2);
                    user.password = reader.GetString(3);
                }
                else
                {
                    user = null;
                }
                return user;
            }
        }

        public static int save(UserDTO user)
        {
            String query = String.Format("INSERT INTO [dbo].[user](name, login, password) VALUES('{0}', '{1}', '{2}')", user.name, user.login, user.password);
            query = query + ";Select Scope_Identity()";
            using (ConnectionSQLServer connection = new ConnectionSQLServer())
            {
                int userId = 0;
                if (user.id == 0)
                {
                    try
                    {
                        var recs = connection.ExcueteScalar(query);
                        String res = recs.ToString();
                        userId = Int32.Parse(res);
                    }
                    catch (Exception e)
                    {
                        userId = 0;
                    }
                }
                return userId;
            }

        }
    }
}
