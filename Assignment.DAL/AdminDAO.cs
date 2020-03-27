using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.DAL
{
    public static class AdminDAO
    {
        public static int validateAdmin(AdminDTO admin)
        {
            String query = String.Format("Select count(*) from [dbo].[Admin] where Login='{0}' and Password='{1}'", admin.Login, admin.Password);
            using (DBConnection dBConnection = new DBConnection())
            {
                var obj = dBConnection.ExcueteScalar(query);
                String recs = obj.ToString();
                int record = Int32.Parse(recs);
                return record;
            }
        }

        public static DataTable getAllUsersDTO()
        {
            String query = "Select * from dbo.Users";
            DataTable dt = new DataTable();
            using (DBConnection dBConnection = new DBConnection())
            {
                var reader = dBConnection.ExcueteReader(query);
                dt.Load(reader);
                return dt;
            }
        }
    }
}
