namespace EAD_ASSIGNMENT_2
{
    partial class Form1
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
            this.label_ums = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_existingUser = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_newUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ums
            // 
            this.label_ums.AutoSize = true;
            this.label_ums.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ums.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_ums.Location = new System.Drawing.Point(100, 45);
            this.label_ums.Name = "label_ums";
            this.label_ums.Size = new System.Drawing.Size(530, 53);
            this.label_ums.TabIndex = 9;
            this.label_ums.Text = "USER MANAGMENT SYSTEM";
            this.label_ums.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(236, 381);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(199, 65);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_existingUser
            // 
            this.btn_existingUser.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_existingUser.Location = new System.Drawing.Point(236, 207);
            this.btn_existingUser.Name = "btn_existingUser";
            this.btn_existingUser.Size = new System.Drawing.Size(199, 65);
            this.btn_existingUser.TabIndex = 7;
            this.btn_existingUser.Text = "Existing User";
            this.btn_existingUser.UseVisualStyleBackColor = true;
            this.btn_existingUser.Click += new System.EventHandler(this.btn_existingUser_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Location = new System.Drawing.Point(236, 297);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(199, 65);
            this.btn_admin.TabIndex = 6;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_newUser
            // 
            this.btn_newUser.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_newUser.Location = new System.Drawing.Point(236, 123);
            this.btn_newUser.Name = "btn_newUser";
            this.btn_newUser.Size = new System.Drawing.Size(199, 65);
            this.btn_newUser.TabIndex = 5;
            this.btn_newUser.Text = "New User";
            this.btn_newUser.UseVisualStyleBackColor = true;
            this.btn_newUser.Click += new System.EventHandler(this.btn_newUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(733, 500);
            this.ControlBox = false;
            this.Controls.Add(this.label_ums);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_existingUser);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_newUser);
            this.Name = "Form1";
            this.Text = "Main Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ums;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_existingUser;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_newUser;
    }
}

