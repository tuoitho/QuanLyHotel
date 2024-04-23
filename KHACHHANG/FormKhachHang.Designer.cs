namespace QuanLyHotel.KHACHHANG
{
    partial class FormKhachHang
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_quoctich = new System.Windows.Forms.TextBox();
            this.textBox_cccd = new System.Windows.Forms.TextBox();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.textBox_hoten = new System.Windows.Forms.TextBox();
            this.textBox_makh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_phongmuonchuyen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExpectedArrival = new System.Windows.Forms.Label();
            this.lblExpectedDeparture = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_kh = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.button_xemhd = new System.Windows.Forms.Button();
            this.button_xemphong = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(28, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 551);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox_quoctich);
            this.panel2.Controls.Add(this.textBox_cccd);
            this.panel2.Controls.Add(this.textBox_sdt);
            this.panel2.Controls.Add(this.textBox_hoten);
            this.panel2.Controls.Add(this.textBox_makh);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label_phongmuonchuyen);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblExpectedArrival);
            this.panel2.Controls.Add(this.lblExpectedDeparture);
            this.panel2.Controls.Add(this.lblEmployee);
            this.panel2.Controls.Add(this.lblDepositAmount);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 551);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox_quoctich
            // 
            this.textBox_quoctich.Location = new System.Drawing.Point(117, 262);
            this.textBox_quoctich.Name = "textBox_quoctich";
            this.textBox_quoctich.Size = new System.Drawing.Size(230, 24);
            this.textBox_quoctich.TabIndex = 13;
            // 
            // textBox_cccd
            // 
            this.textBox_cccd.Location = new System.Drawing.Point(117, 212);
            this.textBox_cccd.Name = "textBox_cccd";
            this.textBox_cccd.Size = new System.Drawing.Size(230, 24);
            this.textBox_cccd.TabIndex = 13;
            this.textBox_cccd.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Location = new System.Drawing.Point(117, 158);
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(230, 24);
            this.textBox_sdt.TabIndex = 13;
            this.textBox_sdt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.Location = new System.Drawing.Point(117, 108);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.Size = new System.Drawing.Size(230, 24);
            this.textBox_hoten.TabIndex = 13;
            // 
            // textBox_makh
            // 
            this.textBox_makh.Enabled = false;
            this.textBox_makh.Location = new System.Drawing.Point(117, 67);
            this.textBox_makh.Name = "textBox_makh";
            this.textBox_makh.Size = new System.Drawing.Size(230, 24);
            this.textBox_makh.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox1.Location = new System.Drawing.Point(117, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 134);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label_phongmuonchuyen
            // 
            this.label_phongmuonchuyen.AutoSize = true;
            this.label_phongmuonchuyen.Location = new System.Drawing.Point(32, 331);
            this.label_phongmuonchuyen.Name = "label_phongmuonchuyen";
            this.label_phongmuonchuyen.Size = new System.Drawing.Size(62, 17);
            this.label_phongmuonchuyen.TabIndex = 10;
            this.label_phongmuonchuyen.Text = "Hình ảnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã KH";
            // 
            // lblExpectedArrival
            // 
            this.lblExpectedArrival.AutoSize = true;
            this.lblExpectedArrival.Location = new System.Drawing.Point(32, 115);
            this.lblExpectedArrival.Name = "lblExpectedArrival";
            this.lblExpectedArrival.Size = new System.Drawing.Size(49, 17);
            this.lblExpectedArrival.TabIndex = 0;
            this.lblExpectedArrival.Text = "Họ tên";
            // 
            // lblExpectedDeparture
            // 
            this.lblExpectedDeparture.AutoSize = true;
            this.lblExpectedDeparture.Location = new System.Drawing.Point(32, 165);
            this.lblExpectedDeparture.Name = "lblExpectedDeparture";
            this.lblExpectedDeparture.Size = new System.Drawing.Size(34, 17);
            this.lblExpectedDeparture.TabIndex = 2;
            this.lblExpectedDeparture.Text = "SĐT";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(32, 265);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(70, 17);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Quốc Tịch";
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Location = new System.Drawing.Point(32, 215);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(45, 17);
            this.lblDepositAmount.TabIndex = 4;
            this.lblDepositAmount.Text = "CCCD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.dataGridView_kh);
            this.panel1.Location = new System.Drawing.Point(476, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 551);
            this.panel1.TabIndex = 18;
            // 
            // dataGridView_kh
            // 
            this.dataGridView_kh.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView_kh.AllowUserToAddRows = false;
            this.dataGridView_kh.AllowUserToDeleteRows = false;
            this.dataGridView_kh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_kh.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_kh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kh.Location = new System.Drawing.Point(3, 0);
            this.dataGridView_kh.MultiSelect = false;
            this.dataGridView_kh.Name = "dataGridView_kh";
            this.dataGridView_kh.ReadOnly = true;
            this.dataGridView_kh.RowHeadersVisible = false;
            this.dataGridView_kh.RowHeadersWidth = 51;
            this.dataGridView_kh.RowTemplate.Height = 50;
            this.dataGridView_kh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_kh.Size = new System.Drawing.Size(880, 551);
            this.dataGridView_kh.TabIndex = 13;
            this.dataGridView_kh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_kh_CellClick);
            this.dataGridView_kh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_kh_CellContentClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::QuanLyHotel.Properties.Resources.loading;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(471, 708);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLoad.Size = new System.Drawing.Size(114, 46);
            this.btnLoad.TabIndex = 23;
            this.btnLoad.Text = "   Reload";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::QuanLyHotel.Properties.Resources.trash;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(780, 708);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(4);
            this.btn_delete.Size = new System.Drawing.Size(113, 46);
            this.btn_delete.TabIndex = 22;
            this.btn_delete.Text = "   Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Image = global::QuanLyHotel.Properties.Resources.edit;
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.Location = new System.Drawing.Point(626, 708);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Padding = new System.Windows.Forms.Padding(4);
            this.btn_modify.Size = new System.Drawing.Size(113, 46);
            this.btn_modify.TabIndex = 21;
            this.btn_modify.Text = "   Sửa";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(317, 708);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(4);
            this.btn_add.Size = new System.Drawing.Size(113, 46);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "   Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button_xemhd
            // 
            this.button_xemhd.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_xemhd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xemhd.Location = new System.Drawing.Point(471, 643);
            this.button_xemhd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_xemhd.Name = "button_xemhd";
            this.button_xemhd.Padding = new System.Windows.Forms.Padding(4);
            this.button_xemhd.Size = new System.Drawing.Size(148, 46);
            this.button_xemhd.TabIndex = 20;
            this.button_xemhd.Text = "   Xem hoá đơn";
            this.button_xemhd.UseVisualStyleBackColor = true;
            // 
            // button_xemphong
            // 
            this.button_xemphong.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_xemphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xemphong.Location = new System.Drawing.Point(647, 643);
            this.button_xemphong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_xemphong.Name = "button_xemphong";
            this.button_xemphong.Padding = new System.Windows.Forms.Padding(4);
            this.button_xemphong.Size = new System.Drawing.Size(113, 46);
            this.button_xemphong.TabIndex = 20;
            this.button_xemphong.Text = "   Thêm";
            this.button_xemphong.UseVisualStyleBackColor = true;
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(496, 13);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(209, 24);
            this.textBox_input.TabIndex = 24;
            this.textBox_input.Click += new System.EventHandler(this.textBox_input_Click);
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // button_timkiem
            // 
            this.button_timkiem.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_timkiem.Location = new System.Drawing.Point(746, 1);
            this.button_timkiem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Padding = new System.Windows.Forms.Padding(4);
            this.button_timkiem.Size = new System.Drawing.Size(126, 46);
            this.button_timkiem.TabIndex = 25;
            this.button_timkiem.Text = "   Tìm kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 873);
            this.Controls.Add(this.button_timkiem);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.button_xemphong);
            this.Controls.Add(this.button_xemhd);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_kh;
        private System.Windows.Forms.Label label_phongmuonchuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExpectedArrival;
        private System.Windows.Forms.Label lblExpectedDeparture;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.TextBox textBox_quoctich;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.TextBox textBox_hoten;
        private System.Windows.Forms.TextBox textBox_makh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_cccd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button_xemhd;
        private System.Windows.Forms.Button button_xemphong;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_timkiem;
    }
}