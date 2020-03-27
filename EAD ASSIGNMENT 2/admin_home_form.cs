using Assignment.BAL;
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
    public partial class admin_home_form : Form
    {
        public admin_home_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = Application.OpenForms["Form1"];
            form.Show();
        }

        private void admin_home_form_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = AdminBO.getAllUsersDTO();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var uid = (int)dataGridView1.CurrentRow.Cells[0].Value;
                signup_form _Form = new signup_form(null, uid);
                this.Close();
                _Form.Show();
            }
        }
    }
}
