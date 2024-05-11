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
            this.roundedButton_xemkhaibao = new QuanLyHotel.RoundedButton();
            this.roundedButton1 = new QuanLyHotel.RoundedButton();
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
            this.tabPage_qlhoadon.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage_qlhoadon.Controls.Add(this.dataGridView_hoadon);
            this.tabPage_qlhoadon.Controls.Add(this.roundedButton_xemkhaibao);
            this.tabPage_qlhoadon.Controls.Add(this.roundedButton1);
            this.tabPage_qlhoadon.Controls.Add(this.bt_timkiem);
            this.tabPage_qlhoadon.Controls.Add(this.textBox_inputkhachhang);
            this.tabPage_qlhoadon.Location = new System.Drawing.Point(4, 26);
            this.tabPage_qlhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_qlhoadon.Name = "tabPage_qlhoadon";
            this.tabPage_qlhoadon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_qlhoadon.Size = new System.Drawing.Size(1285, 644);
            this.tabPage_qlhoadon.TabIndex = 0;
            this.tabPage_qlhoadon.Text = "Quản lí hoá đơn";
            // 
            // dataGridView_hoadon
            // 
            this.dataGridView_hoadon.AllowUserToAddRows = false;
            this.dataGridView_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_hoadon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hoadon.Location = new System.Drawing.Point(26, 103);
            this.dataGridView_hoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_hoadon.MultiSelect = false;
            this.dataGridView_hoadon.Name = "dataGridView_hoadon";
            this.dataGridView_hoadon.ReadOnly = true;
            this.dataGridView_hoadon.RowHeadersWidth = 51;
            this.dataGridView_hoadon.RowTemplate.Height = 26;
            this.dataGridView_hoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_hoadon.Size = new System.Drawing.Size(1201, 413);
            this.dataGridView_hoadon.TabIndex = 2;
            // 
            // roundedButton_xemkhaibao
            // 
            this.roundedButton_xemkhaibao.BackColor = System.Drawing.Color.IndianRed;
            this.roundedButton_xemkhaibao.Font = new System.Drawing.Font("Tahoma", 15F);
            this.roundedButton_xemkhaibao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedButton_xemkhaibao.Location = new System.Drawing.Point(727, 532);
            this.roundedButton_xemkhaibao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedButton_xemkhaibao.Name = "roundedButton_xemkhaibao";
            this.roundedButton_xemkhaibao.Size = new System.Drawing.Size(225, 58);
            this.roundedButton_xemkhaibao.TabIndex = 1;
            this.roundedButton_xemkhaibao.Text = "Xem khai báo";
            this.roundedButton_xemkhaibao.UseVisualStyleBackColor = false;
            this.roundedButton_xemkhaibao.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.IndianRed;
            this.roundedButton1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.roundedButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedButton1.Location = new System.Drawing.Point(186, 532);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(225, 58);
            this.roundedButton1.TabIndex = 1;
            this.roundedButton1.Text = "Xem chi tiết hoá đơn";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.IndianRed;
            this.bt_timkiem.Font = new System.Drawing.Font("Tahoma", 15F);
            this.bt_timkiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_timkiem.Location = new System.Drawing.Point(826, 20);
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
            this.textBox_inputkhachhang.Font = new System.Drawing.Font("Tahoma", 15F);
            this.textBox_inputkhachhang.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_inputkhachhang.Location = new System.Drawing.Point(155, 32);
            this.textBox_inputkhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_inputkhachhang.Name = "textBox_inputkhachhang";
            this.textBox_inputkhachhang.Size = new System.Drawing.Size(602, 32);
            this.textBox_inputkhachhang.TabIndex = 0;
            this.textBox_inputkhachhang.Text = "Tìm theo tên khách hàng, mã khách hàng, số cmt, SĐT";
            this.textBox_inputkhachhang.Click += new System.EventHandler(this.textBox_inputkhachhang_Click);
            this.textBox_inputkhachhang.TextChanged += new System.EventHandler(this.textBox_inputkhachhang_TextChanged);
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
            this.tabControl_hoadon.Size = new System.Drawing.Size(1293, 674);
            this.tabControl_hoadon.TabIndex = 0;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 674);
            this.Controls.Add(this.tabControl_hoadon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
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
        private RoundedButton roundedButton_xemkhaibao;
        private RoundedButton roundedButton1;
    }
}