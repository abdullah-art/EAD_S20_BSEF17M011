using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.DAL
{
    public static class UserDAO
    {
        public static int Save(UserDTO userDTO)
        {
            String query;
            if (userDTO.UserID > 0)
            {
                query = String.Format("update [dbo].[Users]  set Name='{0}',Login='{1}',Password='{2}',Email='{3}', Gender='{4}',Address='{5}',Age='{6}',NIC='{7}',DOB='{8}',IsCricket='{9}',Hockey='{10}',Chess='{11}',ImageName='{12}',CreatedOn='{13}',CreatedBy='{14}',ModifiedOn='{15}',ModifiedBy='{16}',isActive='{17}' where UserID='{18}'", userDTO.Name, userDTO.Login, userDTO.Password, userDTO.Email, userDTO.Gender, userDTO.Address, userDTO.Age, userDTO.NIC, userDTO.DOB, userDTO.isCricket, userDTO.isHockey, userDTO.Chess, userDTO.ImageName, userDTO.createdOn, userDTO.createdBy, userDTO.modifiedOn, userDTO.modifiedBy, userDTO.isActive, userDTO.UserID);

            }
            else
            {
                query = String.Format("insert into [dbo].[Users]  (Name,Login,Password,Email,Gender,Address,Age,NIC,DOB,IsCricket,Hockey,Chess,ImageName,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,isActive)  Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')", userDTO.Name, userDTO.Login, userDTO.Password, userDTO.Email, userDTO.Gender, userDTO.Address, userDTO.Age, userDTO.NIC, userDTO.DOB, userDTO.isCricket, userDTO.isHockey, userDTO.Chess, userDTO.ImageName, userDTO.createdOn, userDTO.createdBy, userDTO.modifiedOn, userDTO.modifiedBy, userDTO.isActive);
                query = query + "; Select Scope_Identity()";
            }

            using (DBConnection dBConnection = new DBConnection())
            {
                int userId = 0;
                if (userDTO.UserID > 0)
                {
                    dBConnection.ExcueteQuery(query);
                }
                else
                {
                    var recs = dBConnection.ExcueteScalar(query);
                    String res = recs.ToString();
                    userId = Int32.Parse(res);
                }
                return userId;
            }

        }

        public static UserDTO validateUser(String login, String password, String email, int uid, int flag)
        {
            UserDTO user = null;
            String query = "";
            if (flag == 1)
            {
                query = String.Format("Select * from [dbo].[Users] where Login='{0}' and Password='{1}'", login, password);
            }
            else if (flag == 2)
            {
                query = String.Format("Select * from [dbo].[Users] where Login='{0}'or Email='{1}'", login, email);
            }
            else
            {
                query = String.Format("Select * from [dbo].[Users] where (Login='{0}' or Email='{1}') and UserID!='{2}'", login, email, uid);
            }
            using (DBConnection dBConnection = new DBConnection())
            {
                var reader = dBConnection.ExcueteReader(query);
                if (reader.Read())
                {
                    user = fillDTO(reader);
                }
                return user;
            }
        }

        public static int validateUserWithEmail(String email)
        {
            String query = String.Format("Select count(*) from [dbo].[Users] where Email='{0}'", email);
            using (DBConnection dBConnection = new DBConnection())
            {
                var recs = dBConnection.ExcueteScalar(query);
                String res = recs.ToString();
                int count = Int32.Parse(res);
                return count;
            }
        }


        public static UserDTO getUserDTOById(int userId)
        {
            String query = String.Format("Select * from [dbo].[Users] where UserID='{0}'", userId);
            using (DBConnection dBConnection = new DBConnection())
            {
                var reader = dBConnection.ExcueteReader(query);
                UserDTO user = null;
                if (reader.Read())
                {
                    user = fillDTO(reader);
                }
                return user;
            }
        }

        public static UserDTO getUserDTOByEmail(String email)
        {
            String query = String.Format("Select * from [dbo].[Users] where Email='{0}'", email);
            using (DBConnection dBConnection = new DBConnection())
            {
                var reader = dBConnection.ExcueteReader(query);
                UserDTO user = null;
                if (reader.Read())
                {
                    user = fillDTO(reader);
                }
                return user;
            }
        }

        public static UserDTO fillDTO(SqlDataReader dataReader)
        {
            UserDTO user = new UserDTO(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetInt32(7).ToString(), dataReader.GetString(8), dataReader.GetDateTime(9), dataReader.GetBoolean(10), dataReader.GetBoolean(11), dataReader.GetBoolean(12), dataReader.GetString(13), dataReader.GetDateTime(14), dataReader.GetString(15), dataReader.GetDateTime(16), dataReader.GetString(17), dataReader.GetBoolean(18));
            user.UserID = dataReader.GetInt32(0);
            return user;
        }
    }
}
