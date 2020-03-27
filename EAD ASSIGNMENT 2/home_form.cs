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
    public partial class home_form : Form
    {
        String userName;
        String imgPath;
        int uid;
        public home_form(String name, String path, int id)
        {
            InitializeComponent();
            userName = name;
            imgPath = path;
            label_name.Text = name;
            pictureBox_homePic.Image = Image.FromFile(imgPath);
            uid = id;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            UserDTO user = UserBO.getUserDTOById(uid);
            signup_form signup_Form = new signup_form(user, 0);
            signup_Form.ShowDialog();
        }

        private void home_form_Load(object sender, EventArgs e)
        {
            pictureBox_homePic.WaitOnLoad = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = Application.OpenForms["Form1"];
            if(form!=null)
            {
                form.Show();
            }
        }
    }
}
