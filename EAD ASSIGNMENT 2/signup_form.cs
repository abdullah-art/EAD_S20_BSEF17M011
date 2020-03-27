using Assignment.BAL;
using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAD_ASSIGNMENT_2
{
    public partial class signup_form : Form
    {
        UserDTO user;
        int _userId;
        bool uploadFlag = false;
        public signup_form(UserDTO userDTO, int uid)
        {
            user = userDTO;
            _userId = uid;
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            String name = textBox_name.Text.Trim();
            String login = textBox_login.Text.Trim();
            String email = textBox_email.Text.Trim();
            String password = textBox_password.Text.Trim();
            String gender = comboBox_gender.Text;
            String address = textBox_address.Text.Trim();
            String age = textBox_age.Text.Trim();
            String NIC = maskedTextBox_NIC.Text;
            bool cricket = checkBox_cricket.Checked;
            bool hockey = checkBox_hockey.Checked;
            bool chess = checkBox_chess.Checked;
            DateTime DOB = dateTimePicker_dob.Value;

            DateTime createdOn;
            if (user == null && _userId == 0)
            {
                createdOn = DateTime.Now;
            }
            else if (user != null)
            {
                createdOn = user.createdOn;
            }
            else
            {
                UserDTO userFromAdmin = UserBO.getUserDTOById(_userId);
                createdOn = userFromAdmin.createdOn;
            }
            String createdBy = login;
            String modifiedBy = login;
            DateTime modifiedOn = createdOn;
            bool isActive = true;
            bool emailFlag = true;
            String imgName;
            if (!string.IsNullOrEmpty(email))
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(email);
                }
                catch (FormatException ex)
                {
                    emailFlag = false;
                }
            }

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(address) || !maskedTextBox_NIC.MaskCompleted || pictureBox_profile.Image == null)
            {
                MessageBox.Show("Please fill out all the fields!");
            }
            else if (!emailFlag)
            {
                MessageBox.Show("Wrong Email Address!");
            }
            else
            {
                String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                String pathToSaveImage = applicationBasePath + @"\images\";
                String imgPath;


                if (_userId > 0)
                {
                    if (uploadFlag == true)
                    {
                        imgName = Guid.NewGuid().ToString() + ".jpg";
                        imgPath = pathToSaveImage + imgName;
                        pictureBox_profile.Image.Save(imgPath);
                    }
                    else
                    {
                        UserDTO temp = UserBO.getUserDTOById(_userId);
                        imgName = temp.ImageName;
                        imgPath = pathToSaveImage + imgName;
                    }
                }
                else
                {
                    imgName = Guid.NewGuid().ToString() + ".jpg";
                    imgPath = pathToSaveImage + imgName;
                    pictureBox_profile.Image.Save(imgPath);
                }
                gender = gender.Substring(0, 1);
                UserDTO userDTO = new UserDTO(name, login, password, email, gender, address, age, NIC, DOB, cricket, hockey, chess, imgName, createdOn, createdBy, modifiedOn, modifiedBy, isActive);
                UserDTO userDTO1 = null;


                if (user != null)
                {
                    userDTO.UserID = user.UserID;
                    userDTO1 = UserBO.validateUser(login, password, email, userDTO.UserID, 3);
                }
                else if (_userId > 0)
                {
                    userDTO.UserID = _userId;
                    userDTO1 = UserBO.validateUser(login, password, email, _userId, 3);
                }
                else
                {
                    userDTO1 = UserBO.validateUser(login, password, email, 0, 2);
                }


                if (userDTO1 == null)
                {
                    if (user != null)
                    {
                        userDTO.modifiedOn = DateTime.Now;

                    }
                    else if (_userId > 0)
                    {
                        userDTO.modifiedOn = DateTime.Now;
                        userDTO.modifiedBy = "admin";
                    }
                    int res = UserBO.Save(userDTO);
                    if (res > 0)
                    {
                        userDTO.UserID = res;
                    }
                    if (_userId > 0)
                    {
                        this.Close();
                        admin_home_form admin_Home = new admin_home_form();
                        admin_Home.Show();
                    }
                    else
                    {
                        home_form home_Form = new home_form(name, imgPath, userDTO.UserID);
                        this.Close();
                        var form = Application.OpenForms["Form1"];
                        form.Hide();
                        var hform = Application.OpenForms["home_form"];
                        if (hform != null)
                        {
                            hform.Close();
                        }
                        home_Form.Show();
                    }
                }
                else
                {
                    if (userDTO1 != null)
                    {
                        MessageBox.Show("User already exists with this login or email!");

                        if (user != null || uploadFlag)
                        {
                            if (File.Exists(imgPath))
                            {
                                System.IO.File.Delete(imgPath);
                            }
                        }
                    }
                }

            }
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            uploadFlag = true;
            var result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var filePath = openFileDialog1.FileName;
                pictureBox_profile.Image = Image.FromFile(filePath);
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

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            if (_userId > 0)
            {
                admin_home_form admin_Home = new admin_home_form();
                admin_Home.Show();
            }
        }

        private void signup_form_Load(object sender, EventArgs e)
        {
            pictureBox_profile.WaitOnLoad = false;

            String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            System.IO.Directory.CreateDirectory(applicationBasePath + @"\images\");
            if (user != null)
            {
                textBox_name.Text = user.Name;
                textBox_login.Text = user.Login;
                textBox_password.Text = user.Password;
            }
            if (_userId > 0)
            {
                UserDTO user_edit = UserBO.getUserDTOById(_userId);
                textBox_name.Text = user_edit.Name;
                textBox_login.Text = user_edit.Login;
                textBox_password.Text = user_edit.Password;
                textBox_address.Text = user_edit.Address;
                textBox_age.Text = user_edit.Age.ToString();
                maskedTextBox_NIC.Text = user_edit.NIC;
                dateTimePicker_dob.Value = user_edit.DOB;
                textBox_email.Text = user_edit.Email;

                if (user_edit.isCricket == true)
                {
                    checkBox_cricket.CheckState = CheckState.Checked;
                }
                else if (user_edit.isHockey == true)
                {
                    checkBox_hockey.CheckState = CheckState.Checked;
                }
                else if (user_edit.Chess == true)
                {
                    checkBox_chess.CheckState = CheckState.Checked;
                }


                if (user_edit.Gender.Equals("M"))
                {
                    comboBox_gender.Text = "Male";
                }
                else
                {
                    comboBox_gender.Text = "Female";
                }
                String imgPath = applicationBasePath + @"\images\" + user_edit.ImageName;
                pictureBox_profile.Image = Image.FromFile(imgPath);
            }
            comboBox_gender.Items.Add("Male");
            comboBox_gender.Items.Add("Female");
        }
    }
}
