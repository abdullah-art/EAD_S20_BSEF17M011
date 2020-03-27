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
    public partial class admin_form : Form
    {
        public admin_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_alogin_Click(object sender, EventArgs e)
        {

            String login = textBox_alogin.Text.Trim();
            String password = textBox_apassword.Text.Trim();
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill out all the fields!");
            }
            else
            {
                AdminDTO admin = new AdminDTO();
                admin.Login = login;
                admin.Password = password;
                int recs = AdminBO.validateAdmin(admin);
                if (recs == 1)
                {

                    var form = Application.OpenForms["Form1"];
                    form.Hide();
                    this.Close();
                    admin_home_form home_Form = new admin_home_form();
                    home_Form.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login or password!");
                }

            }
        }
    }
}
