namespace EAD_ASSIGNMENT_2
{
    partial class signup_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_upload = new System.Windows.Forms.Button();
            this.pictureBox_profile = new System.Windows.Forms.PictureBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_chess = new System.Windows.Forms.CheckBox();
            this.checkBox_hockey = new System.Windows.Forms.CheckBox();
            this.checkBox_cricket = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_dob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox_NIC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // button_upload
            // 
            this.button_upload.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.Location = new System.Drawing.Point(684, 184);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(90, 35);
            this.button_upload.TabIndex = 52;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // pictureBox_profile
            // 
            this.pictureBox_profile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_profile.Location = new System.Drawing.Point(638, 23);
            this.pictureBox_profile.Name = "pictureBox_profile";
            this.pictureBox_profile.Size = new System.Drawing.Size(174, 149);
            this.pictureBox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_profile.TabIndex = 51;
            this.pictureBox_profile.TabStop = false;
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(722, 431);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(90, 35);
            this.button_cancel.TabIndex = 50;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(626, 430);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(90, 35);
            this.btn_create.TabIndex = 49;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Sports";
            // 
            // checkBox_chess
            // 
            this.checkBox_chess.AutoSize = true;
            this.checkBox_chess.Location = new System.Drawing.Point(344, 448);
            this.checkBox_chess.Name = "checkBox_chess";
            this.checkBox_chess.Size = new System.Drawing.Size(55, 17);
            this.checkBox_chess.TabIndex = 47;
            this.checkBox_chess.Text = "Chess";
            this.checkBox_chess.UseVisualStyleBackColor = true;
            // 
            // checkBox_hockey
            // 
            this.checkBox_hockey.AutoSize = true;
            this.checkBox_hockey.Location = new System.Drawing.Point(272, 448);
            this.checkBox_hockey.Name = "checkBox_hockey";
            this.checkBox_hockey.Size = new System.Drawing.Size(63, 17);
            this.checkBox_hockey.TabIndex = 46;
            this.checkBox_hockey.Text = "Hockey";
            this.checkBox_hockey.UseVisualStyleBackColor = true;
            // 
            // checkBox_cricket
            // 
            this.checkBox_cricket.AutoSize = true;
            this.checkBox_cricket.Location = new System.Drawing.Point(207, 448);
            this.checkBox_cricket.Name = "checkBox_cricket";
            this.checkBox_cricket.Size = new System.Drawing.Size(59, 17);
            this.checkBox_cricket.TabIndex = 45;
            this.checkBox_cricket.Text = "Cricket";
            this.checkBox_cricket.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_dob
            // 
            this.dateTimePicker_dob.Location = new System.Drawing.Point(207, 404);
            this.dateTimePicker_dob.Name = "dateTimePicker_dob";
            this.dateTimePicker_dob.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_dob.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "DOB";
            // 
            // maskedTextBox_NIC
            // 
            this.maskedTextBox_NIC.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_NIC.Location = new System.Drawing.Point(207, 375);
            this.maskedTextBox_NIC.Mask = "00000-0000000-0";
            this.maskedTextBox_NIC.Name = "maskedTextBox_NIC";
            this.maskedTextBox_NIC.Size = new System.Drawing.Size(97, 24);
            this.maskedTextBox_NIC.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "NIC";
            // 
            // textBox_age
            // 
            this.textBox_age.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_age.Location = new System.Drawing.Point(207, 337);
            this.textBox_age.MaxLength = 2;
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(59, 24);
            this.textBox_age.TabIndex = 40;
            this.textBox_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Age";
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(207, 184);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(175, 113);
            this.textBox_address.TabIndex = 38;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Location = new System.Drawing.Point(207, 141);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(59, 25);
            this.comboBox_gender.TabIndex = 37;
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(207, 109);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(178, 24);
            this.textBox_email.TabIndex = 36;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(207, 79);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(178, 24);
            this.textBox_password.TabIndex = 35;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_password_MouseDown);
            this.textBox_password.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox_password_MouseUp);
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login.Location = new System.Drawing.Point(207, 53);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(178, 24);
            this.textBox_login.TabIndex = 34;
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(207, 24);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(178, 24);
            this.textBox_name.TabIndex = 33;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(99, 210);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(68, 21);
            this.label_address.TabIndex = 32;
            this.label_address.Text = "Address";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(99, 140);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(60, 21);
            this.label_gender.TabIndex = 31;
            this.label_gender.Text = "Gender";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(99, 108);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(47, 21);
            this.label_email.TabIndex = 30;
            this.label_email.Text = "Email";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.Location = new System.Drawing.Point(99, 48);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(46, 21);
            this.label_login.TabIndex = 29;
            this.label_login.Text = "Login";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(99, 78);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(74, 21);
            this.label_password.TabIndex = 28;
            this.label_password.Text = "Password";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(99, 23);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(50, 21);
            this.label_name.TabIndex = 27;
            this.label_name.Text = "Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "7";
            this.openFileDialog1.Filter = "JPG | *jpg";
            // 
            // signup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(910, 489);
            this.ControlBox = false;
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.pictureBox_profile);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox_chess);
            this.Controls.Add(this.checkBox_hockey);
            this.Controls.Add(this.checkBox_cricket);
            this.Controls.Add(this.dateTimePicker_dob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox_NIC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_name);
            this.Name = "signup_form";
            this.Text = "New User";
            this.Load += new System.EventHandler(this.signup_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.PictureBox pictureBox_profile;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_chess;
        private System.Windows.Forms.CheckBox checkBox_hockey;
        private System.Windows.Forms.CheckBox checkBox_cricket;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_NIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}