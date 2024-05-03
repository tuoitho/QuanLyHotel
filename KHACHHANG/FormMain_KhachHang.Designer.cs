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
            this.label_xc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_maph = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ngaydi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ngayvao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_mgg = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.button_khaibao = new System.Windows.Forms.Button();
            this.button_f5 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mgg)).BeginInit();
            this.SuspendLayout();
            // 
            // label_xc
            // 
            this.label_xc.AutoSize = true;
            this.label_xc.Location = new System.Drawing.Point(12, 9);
            this.label_xc.Name = "label_xc";
            this.label_xc.Size = new System.Drawing.Size(48, 13);
            this.label_xc.TabIndex = 0;
            this.label_xc.Text = "Xin cào, ";
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
            this.panel2.Controls.Add(this.textBox_maph);
            this.panel2.Controls.Add(this.dateTimePicker_ngaydi);
            this.panel2.Controls.Add(this.dateTimePicker_ngayvao);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 448);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox_maph
            // 
            this.textBox_maph.Location = new System.Drawing.Point(115, 53);
            this.textBox_maph.Name = "textBox_maph";
            this.textBox_maph.Size = new System.Drawing.Size(132, 20);
            this.textBox_maph.TabIndex = 15;
            // 
            // dateTimePicker_ngaydi
            // 
            this.dateTimePicker_ngaydi.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_ngaydi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngaydi.Location = new System.Drawing.Point(98, 161);
            this.dateTimePicker_ngaydi.Name = "dateTimePicker_ngaydi";
            this.dateTimePicker_ngaydi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_ngaydi.TabIndex = 14;
            // 
            // dateTimePicker_ngayvao
            // 
            this.dateTimePicker_ngayvao.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_ngayvao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngayvao.Location = new System.Drawing.Point(98, 100);
            this.dateTimePicker_ngayvao.Name = "dateTimePicker_ngayvao";
            this.dateTimePicker_ngayvao.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_ngayvao.TabIndex = 14;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dự kiến đi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày vào";
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
            // dataGridView_mgg
            // 
            this.dataGridView_mgg.AllowUserToAddRows = false;
            this.dataGridView_mgg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mgg.Location = new System.Drawing.Point(19, 61);
            this.dataGridView_mgg.Name = "dataGridView_mgg";
            this.dataGridView_mgg.Size = new System.Drawing.Size(301, 261);
            this.dataGridView_mgg.TabIndex = 1;
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
            // button_khaibao
            // 
            this.button_khaibao.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_khaibao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_khaibao.Location = new System.Drawing.Point(842, 226);
            this.button_khaibao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_khaibao.Name = "button_khaibao";
            this.button_khaibao.Padding = new System.Windows.Forms.Padding(3);
            this.button_khaibao.Size = new System.Drawing.Size(198, 37);
            this.button_khaibao.TabIndex = 30;
            this.button_khaibao.Text = "   Khai báo sử dụng dịch vụ";
            this.button_khaibao.UseVisualStyleBackColor = true;
            this.button_khaibao.Click += new System.EventHandler(this.button_khaibao_Click);
            // 
            // button_f5
            // 
            this.button_f5.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_f5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_f5.Location = new System.Drawing.Point(525, 433);
            this.button_f5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_f5.Name = "button_f5";
            this.button_f5.Padding = new System.Windows.Forms.Padding(3);
            this.button_f5.Size = new System.Drawing.Size(198, 37);
            this.button_f5.TabIndex = 30;
            this.button_f5.Text = "Reload";
            this.button_f5.UseVisualStyleBackColor = true;
            this.button_f5.Click += new System.EventHandler(this.button_f5_Click);
            // 
            // FormMain_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_f5);
            this.Controls.Add(this.button_khaibao);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label_xc);
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

        private System.Windows.Forms.Label label_xc;
        private System.Windows.Forms.Button button_khaibao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayvao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_mgg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaydi;
        private System.Windows.Forms.TextBox textBox_maph;
        private System.Windows.Forms.Button button_f5;
    }
}