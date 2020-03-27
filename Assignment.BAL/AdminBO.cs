using Assignment.DAL;
using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BAL
{
    public static class AdminBO
    {
        public static int validateAdmin(AdminDTO admin)
        {
            return AdminDAO.validateAdmin(admin);
        }

        public static DataTable getAllUsersDTO()
        {
            DataTable dt = AdminDAO.getAllUsersDTO();
            return dt;
        }
    }
}
