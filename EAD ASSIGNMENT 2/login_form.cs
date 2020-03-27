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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String name = textBox_login.Text.Trim();
            String password = textBox_password.Text.Trim();
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill out all the fields!");
            }
            else
            {
                UserDTO user = UserBO.validateUser(name, password, "", 0, 1);
                if (user == null)
                {
                    MessageBox.Show("Invalid email or password!");
                }
                else
                {
                    String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                    String pathToSaveImage = applicationBasePath + @"\images\";
                    String imgPath = pathToSaveImage + user.ImageName;
                    home_form home_Form = new home_form(user.Name, imgPath, user.UserID);
                    this.Hide();
                    var form = Application.OpenForms["Form1"];
                    if (form != null)
                    {
                        form.Hide();
                    }
                    home_Form.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
