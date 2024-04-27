namespace QuanLyHotel.KHACHHANG
{
    partial class FormMain_KhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cccd = new System.Windows.Forms.TextBox();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.textBox_hoten = new System.Windows.Forms.TextBox();
            this.textBox_makh = new System.Windows.Forms.TextBox();
            this.lblExpectedArrival = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_xemhd = new System.Windows.Forms.Button();
            this.button_xemphong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView_mgg = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mgg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin cào, ";
            // 
            // textBox_cccd
            // 
            this.textBox_cccd.Location = new System.Drawing.Point(100, 172);
            this.textBox_cccd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_cccd.Name = "textBox_cccd";
            this.textBox_cccd.Size = new System.Drawing.Size(198, 20);
            this.textBox_cccd.TabIndex = 13;
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Location = new System.Drawing.Point(100, 128);
            this.textBox_sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(198, 20);
            this.textBox_sdt.TabIndex = 13;
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.Location = new System.Drawing.Point(100, 88);
            this.textBox_hoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.Size = new System.Drawing.Size(198, 20);
            this.textBox_hoten.TabIndex = 13;
            // 
            // textBox_makh
            // 
            this.textBox_makh.Enabled = false;
            this.textBox_makh.Location = new System.Drawing.Point(100, 54);
            this.textBox_makh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_makh.Name = "textBox_makh";
            this.textBox_makh.Size = new System.Drawing.Size(198, 20);
            this.textBox_makh.TabIndex = 13;
            // 
            // lblExpectedArrival
            // 
            this.lblExpectedArrival.AutoSize = true;
            this.lblExpectedArrival.Location = new System.Drawing.Point(27, 93);
            this.lblExpectedArrival.Name = "lblExpectedArrival";
            this.lblExpectedArrival.Size = new System.Drawing.Size(58, 13);
            this.lblExpectedArrival.TabIndex = 0;
            this.lblExpectedArrival.Text = "Tên Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.textBox_cccd);
            this.panel2.Controls.Add(this.textBox_sdt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_hoten);
            this.panel2.Controls.Add(this.textBox_makh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblExpectedArrival);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 448);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(53, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 341);
            this.panel3.TabIndex = 27;
            // 
            // button_xemhd
            // 
            this.button_xemhd.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_xemhd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xemhd.Location = new System.Drawing.Point(828, 123);
            this.button_xemhd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_xemhd.Name = "button_xemhd";
            this.button_xemhd.Padding = new System.Windows.Forms.Padding(3);
            this.button_xemhd.Size = new System.Drawing.Size(198, 37);
            this.button_xemhd.TabIndex = 28;
            this.button_xemhd.Text = "   Xem hoá đơn";
            this.button_xemhd.UseVisualStyleBackColor = true;
            // 
            // button_xemphong
            // 
            this.button_xemphong.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_xemphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xemphong.Location = new System.Drawing.Point(828, 286);
            this.button_xemphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_xemphong.Name = "button_xemphong";
            this.button_xemphong.Padding = new System.Windows.Forms.Padding(3);
            this.button_xemphong.Size = new System.Drawing.Size(198, 37);
            this.button_xemphong.TabIndex = 30;
            this.button_xemphong.Text = "   Khai báo sử dụng dịch vụ";
            this.button_xemphong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông tin phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mô Tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày vào";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Còn lại";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(453, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 341);
            this.panel1.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridView_mgg);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 341);
            this.panel4.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thông tin mã giảm giá";
            // 
            // dataGridView_mgg
            // 
            this.dataGridView_mgg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mgg.Location = new System.Drawing.Point(19, 61);
            this.dataGridView_mgg.Name = "dataGridView_mgg";
            this.dataGridView_mgg.Size = new System.Drawing.Size(301, 261);
            this.dataGridView_mgg.TabIndex = 1;
            // 
            // FormMain_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_xemhd);
            this.Controls.Add(this.button_xemphong);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Name = "FormMain_KhachHang";
            this.Text = "FormMain_KhachHang";
            this.Load += new System.EventHandler(this.FormMain_KhachHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mgg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cccd;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.TextBox textBox_hoten;
        private System.Windows.Forms.TextBox textBox_makh;
        private System.Windows.Forms.Button button_xemhd;
        private System.Windows.Forms.Label lblExpectedArrival;
        private System.Windows.Forms.Button button_xemphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_mgg;
        private System.Windows.Forms.Label label8;
    }
}