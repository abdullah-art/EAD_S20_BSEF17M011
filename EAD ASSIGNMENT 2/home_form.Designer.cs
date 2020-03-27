namespace EAD_ASSIGNMENT_2
{
    partial class home_form
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
            this.label_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.pictureBox_homePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_homePic)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label_name.ForeColor = System.Drawing.SystemColors.Control;
            this.label_name.Location = new System.Drawing.Point(86, 187);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(80, 35);
            this.label_name.TabIndex = 32;
            this.label_name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(52, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 45);
            this.label1.TabIndex = 31;
            this.label1.Text = "Welcome";
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(393, 360);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(90, 35);
            this.btn_logout.TabIndex = 30;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(367, 173);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(116, 35);
            this.btn_edit.TabIndex = 29;
            this.btn_edit.Text = "Edit Profile";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // pictureBox_homePic
            // 
            this.pictureBox_homePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_homePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_homePic.Location = new System.Drawing.Point(347, 23);
            this.pictureBox_homePic.Name = "pictureBox_homePic";
            this.pictureBox_homePic.Size = new System.Drawing.Size(152, 125);
            this.pictureBox_homePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_homePic.TabIndex = 28;
            this.pictureBox_homePic.TabStop = false;
            // 
            // home_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(551, 418);
            this.ControlBox = false;
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.pictureBox_homePic);
            this.Name = "home_form";
            this.Text = "Home ";
            this.Load += new System.EventHandler(this.home_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_homePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.PictureBox pictureBox_homePic;
    }
}