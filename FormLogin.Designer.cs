namespace QuanLyHotel
{
    partial class FormLogin
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
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton_admin = new System.Windows.Forms.RadioButton();
            this.radioButton_emp = new System.Windows.Forms.RadioButton();
            this.radioButton_cus = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_user = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(309, 129);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(126, 20);
            this.textBox_username.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(309, 198);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(126, 20);
            this.textBox_password.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton_admin
            // 
            this.radioButton_admin.AutoSize = true;
            this.radioButton_admin.Location = new System.Drawing.Point(309, 250);
            this.radioButton_admin.Name = "radioButton_admin";
            this.radioButton_admin.Size = new System.Drawing.Size(54, 17);
            this.radioButton_admin.TabIndex = 2;
            this.radioButton_admin.TabStop = true;
            this.radioButton_admin.Text = "Admin";
            this.radioButton_admin.UseVisualStyleBackColor = true;
            this.radioButton_admin.CheckedChanged += new System.EventHandler(this.radioButton_admin_CheckedChanged);
            // 
            // radioButton_emp
            // 
            this.radioButton_emp.AutoSize = true;
            this.radioButton_emp.Location = new System.Drawing.Point(24, 35);
            this.radioButton_emp.Name = "radioButton_emp";
            this.radioButton_emp.Size = new System.Drawing.Size(71, 17);
            this.radioButton_emp.TabIndex = 2;
            this.radioButton_emp.TabStop = true;
            this.radioButton_emp.Text = "Employee";
            this.radioButton_emp.UseVisualStyleBackColor = true;
            // 
            // radioButton_cus
            // 
            this.radioButton_cus.AutoSize = true;
            this.radioButton_cus.Location = new System.Drawing.Point(118, 35);
            this.radioButton_cus.Name = "radioButton_cus";
            this.radioButton_cus.Size = new System.Drawing.Size(76, 17);
            this.radioButton_cus.TabIndex = 2;
            this.radioButton_cus.TabStop = true;
            this.radioButton_cus.Text = "Cusstomer";
            this.radioButton_cus.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_cus);
            this.groupBox1.Controls.Add(this.radioButton_emp);
            this.groupBox1.Location = new System.Drawing.Point(299, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Form";
            // 
            // radioButton_user
            // 
            this.radioButton_user.AutoSize = true;
            this.radioButton_user.Location = new System.Drawing.Point(381, 250);
            this.radioButton_user.Name = "radioButton_user";
            this.radioButton_user.Size = new System.Drawing.Size(47, 17);
            this.radioButton_user.TabIndex = 2;
            this.radioButton_user.TabStop = true;
            this.radioButton_user.Text = "User";
            this.radioButton_user.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton_user);
            this.Controls.Add(this.radioButton_admin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton_admin;
        private System.Windows.Forms.RadioButton radioButton_emp;
        private System.Windows.Forms.RadioButton radioButton_cus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_user;
    }
}