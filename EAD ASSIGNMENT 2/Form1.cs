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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_newUser_Click(object sender, EventArgs e)
        {
            signup_form sf = new signup_form(null, 0);
            sf.ShowDialog();
        }

        private void btn_existingUser_Click(object sender, EventArgs e)
        {
            login_form lf = new login_form();
            lf.ShowDialog();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            admin_form af = new admin_form();
            af.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
