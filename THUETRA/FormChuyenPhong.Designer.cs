namespace QuanLyHotel.THUETRA
{
    partial class FormChuyenPhong
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_phongmuonchyyen = new System.Windows.Forms.ComboBox();
            this.label_phongmuonchuyen = new System.Windows.Forms.Label();
            this.button_chuyenphong = new System.Windows.Forms.Button();
            this.textBox_room = new System.Windows.Forms.TextBox();
            this.tb_mapdk = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBox_phongmuonchyyen);
            this.panel2.Controls.Add(this.label_phongmuonchuyen);
            this.panel2.Controls.Add(this.button_chuyenphong);
            this.panel2.Controls.Add(this.textBox_room);
            this.panel2.Controls.Add(this.tb_mapdk);
            this.panel2.Controls.Add(this.lblRoom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(37, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 234);
            this.panel2.TabIndex = 19;
            // 
            // comboBox_phongmuonchyyen
            // 
            this.comboBox_phongmuonchyyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_phongmuonchyyen.FormattingEnabled = true;
            this.comboBox_phongmuonchyyen.Location = new System.Drawing.Point(152, 132);
            this.comboBox_phongmuonchyyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_phongmuonchyyen.Name = "comboBox_phongmuonchyyen";
            this.comboBox_phongmuonchyyen.Size = new System.Drawing.Size(151, 21);
            this.comboBox_phongmuonchyyen.TabIndex = 14;
            // 
            // label_phongmuonchuyen
            // 
            this.label_phongmuonchuyen.AutoSize = true;
            this.label_phongmuonchuyen.Location = new System.Drawing.Point(28, 134);
            this.label_phongmuonchuyen.Name = "label_phongmuonchuyen";
            this.label_phongmuonchuyen.Size = new System.Drawing.Size(104, 13);
            this.label_phongmuonchuyen.TabIndex = 13;
            this.label_phongmuonchuyen.Text = "Phòng muốn chuyển";
            // 
            // button_chuyenphong
            // 
            this.button_chuyenphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_chuyenphong.Location = new System.Drawing.Point(118, 160);
            this.button_chuyenphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_chuyenphong.Name = "button_chuyenphong";
            this.button_chuyenphong.Padding = new System.Windows.Forms.Padding(3);
            this.button_chuyenphong.Size = new System.Drawing.Size(150, 37);
            this.button_chuyenphong.TabIndex = 12;
            this.button_chuyenphong.Text = "   Chuyển phòng";
            this.button_chuyenphong.UseVisualStyleBackColor = true;
            this.button_chuyenphong.Click += new System.EventHandler(this.button_chuyenphong_Click);
            // 
            // textBox_room
            // 
            this.textBox_room.Enabled = false;
            this.textBox_room.Location = new System.Drawing.Point(151, 96);
            this.textBox_room.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_room.Name = "textBox_room";
            this.textBox_room.Size = new System.Drawing.Size(152, 20);
            this.textBox_room.TabIndex = 5;
            this.textBox_room.TextChanged += new System.EventHandler(this.tb_mapdk_TextChanged);
            // 
            // tb_mapdk
            // 
            this.tb_mapdk.Enabled = false;
            this.tb_mapdk.Location = new System.Drawing.Point(151, 61);
            this.tb_mapdk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_mapdk.Name = "tb_mapdk";
            this.tb_mapdk.Size = new System.Drawing.Size(189, 20);
            this.tb_mapdk.TabIndex = 5;
            this.tb_mapdk.TextChanged += new System.EventHandler(this.tb_mapdk_TextChanged);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(28, 99);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(37, 13);
            this.lblRoom.TabIndex = 10;
            this.lblRoom.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã PĐK";
            // 
            // FormChuyenPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(448, 273);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "FormChuyenPhong";
            this.Text = "FormChuyenPhong";
            this.Load += new System.EventHandler(this.FormChuyenPhong_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_mapdk;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_chuyenphong;
        private System.Windows.Forms.ComboBox comboBox_phongmuonchyyen;
        private System.Windows.Forms.Label label_phongmuonchuyen;
        private System.Windows.Forms.TextBox textBox_room;
    }
}