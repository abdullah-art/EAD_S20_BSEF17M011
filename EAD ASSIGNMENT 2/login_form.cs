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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            String email = textBox_resetEmail.Text.Trim();
            bool emailFlag = true;
            if (String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill out the field first!");
                emailFlag = false;
            }
            else
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(email);
                }
                catch (FormatException ex)
                {
                    emailFlag = false;
                    MessageBox.Show("Invalid Email!");
                }
            }

            if (emailFlag)
            {
                int count = UserBO.validateUserWithEmail(email);
                if (count == 1)
                {
                    int resetCode = AdminBO.RandomCodeGenerator();
                    bool isSent = AdminBO.sendEmail(email, "Password Reset Code", String.Format("Your code is {0}", resetCode.ToString()));
                    if (isSent)
                    {

                        var form = Application.OpenForms["Form1"];
                        if (form != null)
                        {
                            form.Hide();
                        }
                        this.Close();
                        enterCode_form enterCode_Form;
                        var eform = Application.OpenForms["enterCode_form"];
                        if (eform == null)
                        {
                            enterCode_Form = new enterCode_form(resetCode, email);
                            enterCode_Form.Show();
                        }
                        else
                        {
                            eform.Show();
                        }

                    }
                }
                else
                {
                    textBox_resetEmail.Text = "";
                    MessageBox.Show("No such email exist in our record!Kindly re-enter your email");
                }
            }
        }
    }
}
