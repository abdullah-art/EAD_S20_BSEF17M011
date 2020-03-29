using Assignment.DAL;
using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
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

        public static bool sendEmail(String toEmailAddress, String subject, String body)
        {
            try
            {

                var fromAddress = new MailAddress("lovecodin@gmail.com");
                var fromPassword = "lovecoding123";


                var toAddress = new MailAddress(toEmailAddress);

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })

                    smtp.Send(message);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static int RandomCodeGenerator()
        {
            int randomValue;
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                byte[] val = new byte[4];
                crypto.GetBytes(val);
                randomValue = BitConverter.ToInt16(val, 0);
                randomValue = System.Math.Abs(randomValue);
            }
            return randomValue;
        }
    }
}
