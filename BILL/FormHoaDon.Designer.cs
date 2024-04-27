namespace QuanLyHotel.BILL
{
    partial class FormHoaDon
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
            this.tabPage_qlhoadon = new System.Windows.Forms.TabPage();
            this.dataGridView_hoadon = new System.Windows.Forms.DataGridView();
            this.bt_timkiem = new QuanLyHotel.RoundedButton();
            this.textBox_inputkhachhang = new System.Windows.Forms.TextBox();
            this.tabControl_hoadon = new System.Windows.Forms.TabControl();
            this.tabPage_qlhoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hoadon)).BeginInit();
            this.tabControl_hoadon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_qlhoadon
            // 
            this.tabPage_qlhoadon.Controls.Add(this.dataGridView_hoadon);
            this.tabPage_qlhoadon.Controls.Add(this.bt_timkiem);
            this.tabPage_qlhoadon.Controls.Add(this.textBox_inputkhachhang);
            this.tabPage_qlhoadon.Location = new System.Drawing.Point(4, 26);
            this.tabPage_qlhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_qlhoadon.Name = "tabPage_qlhoadon";
            this.tabPage_qlhoadon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_qlhoadon.Size = new System.Drawing.Size(1078, 597);
            this.tabPage_qlhoadon.TabIndex = 0;
            this.tabPage_qlhoadon.Text = "Quản lí hoá đơn";
            this.tabPage_qlhoadon.UseVisualStyleBackColor = true;
            // 
            // dataGridView_hoadon
            // 
            this.dataGridView_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hoadon.Location = new System.Drawing.Point(69, 145);
            this.dataGridView_hoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_hoadon.Name = "dataGridView_hoadon";
            this.dataGridView_hoadon.RowHeadersWidth = 51;
            this.dataGridView_hoadon.RowTemplate.Height = 26;
            this.dataGridView_hoadon.Size = new System.Drawing.Size(938, 413);
            this.dataGridView_hoadon.TabIndex = 2;
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.IndianRed;
            this.bt_timkiem.Location = new System.Drawing.Point(546, 21);
            this.bt_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(225, 58);
            this.bt_timkiem.TabIndex = 1;
            this.bt_timkiem.Text = "Tìm kiếm khách hàng";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // textBox_inputkhachhang
            // 
            this.textBox_inputkhachhang.Location = new System.Drawing.Point(95, 39);
            this.textBox_inputkhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_inputkhachhang.Name = "textBox_inputkhachhang";
            this.textBox_inputkhachhang.Size = new System.Drawing.Size(420, 25);
            this.textBox_inputkhachhang.TabIndex = 0;
            this.textBox_inputkhachhang.Text = "Tìm theo tên khách hàng, mã khách hàng, số cmt, SĐT";
            // 
            // tabControl_hoadon
            // 
            this.tabControl_hoadon.Controls.Add(this.tabPage_qlhoadon);
            this.tabControl_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_hoadon.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_hoadon.Location = new System.Drawing.Point(0, 0);
            this.tabControl_hoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_hoadon.Name = "tabControl_hoadon";
            this.tabControl_hoadon.SelectedIndex = 0;
            this.tabControl_hoadon.Size = new System.Drawing.Size(1086, 627);
            this.tabControl_hoadon.TabIndex = 0;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 627);
            this.Controls.Add(this.tabControl_hoadon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.tabPage_qlhoadon.ResumeLayout(false);
            this.tabPage_qlhoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hoadon)).EndInit();
            this.tabControl_hoadon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage_qlhoadon;
        private System.Windows.Forms.TabControl tabControl_hoadon;
        private System.Windows.Forms.DataGridView dataGridView_hoadon;
        private RoundedButton bt_timkiem;
        private System.Windows.Forms.TextBox textBox_inputkhachhang;
    }
}