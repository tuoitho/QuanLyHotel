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
            this.tabControl_hoadon = new System.Windows.Forms.TabControl();
            this.textBox_inputkhachhang = new System.Windows.Forms.TextBox();
            this.bt_timkiem = new QuanLyHotel.RoundedButton();
            this.dataGridView_hoadon = new System.Windows.Forms.DataGridView();
            this.tabPage_qlhoadon.SuspendLayout();
            this.tabControl_hoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage_qlhoadon
            // 
            this.tabPage_qlhoadon.Controls.Add(this.dataGridView_hoadon);
            this.tabPage_qlhoadon.Controls.Add(this.bt_timkiem);
            this.tabPage_qlhoadon.Controls.Add(this.textBox_inputkhachhang);
            this.tabPage_qlhoadon.Location = new System.Drawing.Point(4, 31);
            this.tabPage_qlhoadon.Name = "tabPage_qlhoadon";
            this.tabPage_qlhoadon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_qlhoadon.Size = new System.Drawing.Size(1259, 737);
            this.tabPage_qlhoadon.TabIndex = 0;
            this.tabPage_qlhoadon.Text = "Quản lí hoá đơn";
            this.tabPage_qlhoadon.UseVisualStyleBackColor = true;
            // 
            // tabControl_hoadon
            // 
            this.tabControl_hoadon.Controls.Add(this.tabPage_qlhoadon);
            this.tabControl_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_hoadon.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_hoadon.Location = new System.Drawing.Point(0, 0);
            this.tabControl_hoadon.Name = "tabControl_hoadon";
            this.tabControl_hoadon.SelectedIndex = 0;
            this.tabControl_hoadon.Size = new System.Drawing.Size(1267, 772);
            this.tabControl_hoadon.TabIndex = 0;
            // 
            // textBox_inputkhachhang
            // 
            this.textBox_inputkhachhang.Location = new System.Drawing.Point(333, 48);
            this.textBox_inputkhachhang.Name = "textBox_inputkhachhang";
            this.textBox_inputkhachhang.Size = new System.Drawing.Size(268, 29);
            this.textBox_inputkhachhang.TabIndex = 0;
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.IndianRed;
            this.bt_timkiem.Location = new System.Drawing.Point(637, 26);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(262, 72);
            this.bt_timkiem.TabIndex = 1;
            this.bt_timkiem.Text = "Tìm kiếm khách hàng";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            // 
            // dataGridView_hoadon
            // 
            this.dataGridView_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hoadon.Location = new System.Drawing.Point(80, 179);
            this.dataGridView_hoadon.Name = "dataGridView_hoadon";
            this.dataGridView_hoadon.RowHeadersWidth = 51;
            this.dataGridView_hoadon.RowTemplate.Height = 26;
            this.dataGridView_hoadon.Size = new System.Drawing.Size(1094, 508);
            this.dataGridView_hoadon.TabIndex = 2;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 772);
            this.Controls.Add(this.tabControl_hoadon);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.tabPage_qlhoadon.ResumeLayout(false);
            this.tabPage_qlhoadon.PerformLayout();
            this.tabControl_hoadon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hoadon)).EndInit();
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