namespace EAD_ASSIGNMENT_2
{
    partial class admin_form
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_alogin = new System.Windows.Forms.Button();
            this.textBox_apassword = new System.Windows.Forms.TextBox();
            this.textBox_alogin = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(233, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 35;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_alogin
            // 
            this.btn_alogin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alogin.Location = new System.Drawing.Point(117, 138);
            this.btn_alogin.Name = "btn_alogin";
            this.btn_alogin.Size = new System.Drawing.Size(86, 28);
            this.btn_alogin.TabIndex = 34;
            this.btn_alogin.Text = "Login";
            this.btn_alogin.UseVisualStyleBackColor = true;
            this.btn_alogin.Click += new System.EventHandler(this.btn_alogin_Click);
            // 
            // textBox_apassword
            // 
            this.textBox_apassword.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_apassword.Location = new System.Drawing.Point(199, 82);
            this.textBox_apassword.Name = "textBox_apassword";
            this.textBox_apassword.Size = new System.Drawing.Size(178, 24);
            this.textBox_apassword.TabIndex = 33;
            this.textBox_apassword.UseSystemPasswordChar = true;
            // 
            // textBox_alogin
            // 
            this.textBox_alogin.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_alogin.Location = new System.Drawing.Point(199, 44);
            this.textBox_alogin.Name = "textBox_alogin";
            this.textBox_alogin.Size = new System.Drawing.Size(178, 24);
            this.textBox_alogin.TabIndex = 32;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.Location = new System.Drawing.Point(91, 82);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(74, 21);
            this.label_login.TabIndex = 31;
            this.label_login.Text = "Password";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(91, 43);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(46, 21);
            this.label_name.TabIndex = 30;
            this.label_name.Text = "Login";
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(469, 209);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_alogin);
            this.Controls.Add(this.textBox_apassword);
            this.Controls.Add(this.textBox_alogin);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_name);
            this.Name = "admin_form";
            this.Text = "Admin ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_alogin;
        private System.Windows.Forms.TextBox textBox_apassword;
        private System.Windows.Forms.TextBox textBox_alogin;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_name;
    }
}