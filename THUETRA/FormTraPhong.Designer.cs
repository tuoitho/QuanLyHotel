namespace QuanLyHotel.THUETRA
{
    partial class FormTraPhong
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
            this.dataGridView_hoadon = new System.Windows.Forms.DataGridView();
            this.textBox_inputkhachhang = new System.Windows.Forms.TextBox();
            this.textBox_kh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_timkiem = new QuanLyHotel.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_hoadon
            // 
            this.dataGridView_hoadon.AllowUserToAddRows = false;
            this.dataGridView_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_hoadon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hoadon.Location = new System.Drawing.Point(69, 161);
            this.dataGridView_hoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_hoadon.Name = "dataGridView_hoadon";
            this.dataGridView_hoadon.RowHeadersWidth = 51;
            this.dataGridView_hoadon.RowTemplate.Height = 26;
            this.dataGridView_hoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_hoadon.Size = new System.Drawing.Size(938, 413);
            this.dataGridView_hoadon.TabIndex = 5;
            this.dataGridView_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hoadon_CellClick);
            // 
            // textBox_inputkhachhang
            // 
            this.textBox_inputkhachhang.Location = new System.Drawing.Point(-43, -25);
            this.textBox_inputkhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_inputkhachhang.Name = "textBox_inputkhachhang";
            this.textBox_inputkhachhang.Size = new System.Drawing.Size(420, 20);
            this.textBox_inputkhachhang.TabIndex = 3;
            this.textBox_inputkhachhang.Text = "Tìm theo tên khách hàng, mã khách hàng, số cmt, SĐT";
            // 
            // textBox_kh
            // 
            this.textBox_kh.Location = new System.Drawing.Point(165, 57);
            this.textBox_kh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_kh.Name = "textBox_kh";
            this.textBox_kh.Size = new System.Drawing.Size(222, 20);
            this.textBox_kh.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(408, 114);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Khoảng ngày";
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.IndianRed;
            this.bt_timkiem.Location = new System.Drawing.Point(408, 38);
            this.bt_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(200, 56);
            this.bt_timkiem.TabIndex = 4;
            this.bt_timkiem.Text = "Tìm kiếm khách hàng";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // FormTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 624);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_kh);
            this.Controls.Add(this.dataGridView_hoadon);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.textBox_inputkhachhang);
            this.Name = "FormTraPhong";
            this.Text = "FormTraPhong";
            this.Load += new System.EventHandler(this.FormTraPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_hoadon;
        private RoundedButton bt_timkiem;
        private System.Windows.Forms.TextBox textBox_inputkhachhang;
        private System.Windows.Forms.TextBox textBox_kh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
    }
}