namespace QuanLyHotel
{
    partial class FormRegister
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
            this.components = new System.ComponentModel.Container();
            this.radioButton_nv = new System.Windows.Forms.RadioButton();
            this.radioButton_kh = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.button_getcode = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_u = new System.Windows.Forms.TextBox();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timerSendCode = new System.Windows.Forms.Timer(this.components);
            this.button_check = new System.Windows.Forms.Button();
            this.button_checkcode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_noti = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_nv
            // 
            this.radioButton_nv.AutoSize = true;
            this.radioButton_nv.Location = new System.Drawing.Point(159, 14);
            this.radioButton_nv.Name = "radioButton_nv";
            this.radioButton_nv.Size = new System.Drawing.Size(73, 17);
            this.radioButton_nv.TabIndex = 0;
            this.radioButton_nv.TabStop = true;
            this.radioButton_nv.Text = "Nhân viên";
            this.radioButton_nv.UseVisualStyleBackColor = true;
            // 
            // radioButton_kh
            // 
            this.radioButton_kh.AutoSize = true;
            this.radioButton_kh.Location = new System.Drawing.Point(305, 14);
            this.radioButton_kh.Name = "radioButton_kh";
            this.radioButton_kh.Size = new System.Drawing.Size(81, 17);
            this.radioButton_kh.TabIndex = 0;
            this.radioButton_kh.TabStop = true;
            this.radioButton_kh.Text = "Khách hàng";
            this.radioButton_kh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bạn là:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập email đã khai báo";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(180, 78);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(186, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "OTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Enabled = false;
            this.textBoxCode.Location = new System.Drawing.Point(180, 116);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(186, 20);
            this.textBoxCode.TabIndex = 2;
            // 
            // button_getcode
            // 
            this.button_getcode.Enabled = false;
            this.button_getcode.Location = new System.Drawing.Point(488, 78);
            this.button_getcode.Name = "button_getcode";
            this.button_getcode.Size = new System.Drawing.Size(75, 23);
            this.button_getcode.TabIndex = 3;
            this.button_getcode.Text = "Send OTP";
            this.button_getcode.UseVisualStyleBackColor = true;
            this.button_getcode.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // textBox_u
            // 
            this.textBox_u.Location = new System.Drawing.Point(198, 27);
            this.textBox_u.Name = "textBox_u";
            this.textBox_u.Size = new System.Drawing.Size(186, 20);
            this.textBox_u.TabIndex = 2;
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(198, 80);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(186, 20);
            this.textBox_p.TabIndex = 2;
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(245, 142);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(75, 23);
            this.button_register.TabIndex = 3;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_register);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_u);
            this.groupBox1.Controls.Add(this.textBox_p);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(26, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Kí";
            // 
            // timerSendCode
            // 
            this.timerSendCode.Interval = 1000;
            this.timerSendCode.Tick += new System.EventHandler(this.timerSendCode_Tick);
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(392, 78);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(75, 23);
            this.button_check.TabIndex = 3;
            this.button_check.Text = "Check email";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // button_checkcode
            // 
            this.button_checkcode.Location = new System.Drawing.Point(392, 113);
            this.button_checkcode.Name = "button_checkcode";
            this.button_checkcode.Size = new System.Drawing.Size(75, 23);
            this.button_checkcode.TabIndex = 3;
            this.button_checkcode.Text = "Xác minh OTP";
            this.button_checkcode.UseVisualStyleBackColor = true;
            this.button_checkcode.Click += new System.EventHandler(this.button_checkcode_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_noti);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton_nv);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.radioButton_kh);
            this.panel1.Controls.Add(this.button_checkcode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_check);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_getcode);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxCode);
            this.panel1.Location = new System.Drawing.Point(54, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 390);
            this.panel1.TabIndex = 6;
            // 
            // label_noti
            // 
            this.label_noti.AutoSize = true;
            this.label_noti.Location = new System.Drawing.Point(23, 150);
            this.label_noti.Name = "label_noti";
            this.label_noti.Size = new System.Drawing.Size(35, 13);
            this.label_noti.TabIndex = 4;
            this.label_noti.Text = "label6";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 485);
            this.Controls.Add(this.panel1);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_nv;
        private System.Windows.Forms.RadioButton radioButton_kh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button button_getcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_u;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerSendCode;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_checkcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_noti;
    }
}