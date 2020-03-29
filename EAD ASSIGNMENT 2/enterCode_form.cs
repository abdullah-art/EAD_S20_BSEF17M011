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
    public partial class enterCode_form : Form
    {
        int reset_code = 0;
        String user_email;
        int tik = 0;
        int tik1 = 0;
        bool flag = true;
        login_form login_Form;
        public enterCode_form(int code, String email)
        {
            reset_code = code;
            user_email = email;
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            String code = textBox_code.Text.Trim();
            if (String.IsNullOrEmpty(code))
            {
                MessageBox.Show("Please out the field!");
            }
            else
            {
                if (reset_code == Int32.Parse(code))
                {
                    flag = false;
                    updatePassword_form password_Form = new updatePassword_form(user_email);
                    this.Close();
                    password_Form.Show();
                }
                else
                {
                    MessageBox.Show("You are entering wrong code!");
                }
            }
        }

        private void textBox_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void enterCode_form_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            login_Form = new login_form();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tik++;
            if (tik == 30 && flag)
            {
                timer1.Stop();
                var form = Application.OpenForms["Form1"];
                if (form != null)
                {
                    form.Show();
                }
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tik1++;
            if (tik1 == 5)
            {
                label2.Text = "";
                timer2.Stop();
                btn_confirm.Location = new System.Drawing.Point(114, 150);
            }
        }

        private void enterCode_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = Application.OpenForms["Form1"];
            form.Show();
        }
    }
}
