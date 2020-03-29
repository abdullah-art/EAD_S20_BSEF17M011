using Assignment.BAL;
using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAD_ASSIGNMENT_2
{
    public partial class updatePassword_form : Form
    {
        String email;
        public updatePassword_form(String userEmail)
        {
            email = userEmail;
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            String password = textBox_password.Text.Trim();
            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill out the field!");
            }
            else
            {
                UserDTO user = UserBO.getUserDTOByEmail(email);
                user.Password = password;
                int result = UserBO.Save(user);
                if (result == 0)
                {
                    String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                    String pathToSaveImage = applicationBasePath + @"\images\";
                    String imgPath = pathToSaveImage + user.ImageName;
                    home_form home = new home_form(user.Name, imgPath, user.UserID);
                    this.Close();
                    home.Show();
                }

            }
        }

        private void textBox_password_MouseUp(object sender, MouseEventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
        }

        private void textBox_password_MouseDown(object sender, MouseEventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
        }
    }
}
