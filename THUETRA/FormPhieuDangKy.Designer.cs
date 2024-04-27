using System.Windows.Forms;

namespace QuanLyHotel.THUETRA
{
    partial class FormPhieuDangKy
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

        private void InitializeComponent()
        {
            this.lblExpectedArrival = new System.Windows.Forms.Label();
            this.dtpExpectedArrival = new System.Windows.Forms.DateTimePicker();
            this.lblExpectedDeparture = new System.Windows.Forms.Label();
            this.dtpExpectedDeparture = new System.Windows.Forms.DateTimePicker();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.dataGridView_pdk = new System.Windows.Forms.DataGridView();
            this.groupBox_tacvu = new System.Windows.Forms.GroupBox();
            this.button_hethan = new System.Windows.Forms.Button();
            this.button_xemhd = new System.Windows.Forms.Button();
            this.button_hoanthanh = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mapdk = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.button_chuyenphong = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pdk)).BeginInit();
            this.groupBox_tacvu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExpectedArrival
            // 
            this.lblExpectedArrival.AutoSize = true;
            this.lblExpectedArrival.Location = new System.Drawing.Point(27, 93);
            this.lblExpectedArrival.Name = "lblExpectedArrival";
            this.lblExpectedArrival.Size = new System.Drawing.Size(67, 13);
            this.lblExpectedArrival.TabIndex = 0;
            this.lblExpectedArrival.Text = "Dự Kiến Đến";
            // 
            // dtpExpectedArrival
            // 
            this.dtpExpectedArrival.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dtpExpectedArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpectedArrival.Location = new System.Drawing.Point(151, 93);
            this.dtpExpectedArrival.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpExpectedArrival.Name = "dtpExpectedArrival";
            this.dtpExpectedArrival.Size = new System.Drawing.Size(189, 20);
            this.dtpExpectedArrival.TabIndex = 1;
            // 
            // lblExpectedDeparture
            // 
            this.lblExpectedDeparture.AutoSize = true;
            this.lblExpectedDeparture.Location = new System.Drawing.Point(27, 134);
            this.lblExpectedDeparture.Name = "lblExpectedDeparture";
            this.lblExpectedDeparture.Size = new System.Drawing.Size(57, 13);
            this.lblExpectedDeparture.TabIndex = 2;
            this.lblExpectedDeparture.Text = "Dự Kiến Đi";
            // 
            // dtpExpectedDeparture
            // 
            this.dtpExpectedDeparture.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dtpExpectedDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpectedDeparture.Location = new System.Drawing.Point(151, 134);
            this.dtpExpectedDeparture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpExpectedDeparture.Name = "dtpExpectedDeparture";
            this.dtpExpectedDeparture.Size = new System.Drawing.Size(189, 20);
            this.dtpExpectedDeparture.TabIndex = 3;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Location = new System.Drawing.Point(27, 175);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(69, 13);
            this.lblDepositAmount.TabIndex = 4;
            this.lblDepositAmount.Text = "Tiền Đặt Cọc";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(151, 175);
            this.txtDepositAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(189, 20);
            this.txtDepositAmount.TabIndex = 5;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(27, 215);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(55, 13);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Nhân Viên";
            // 
            // cboEmployee
            // 
            this.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(151, 215);
            this.cboEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(151, 21);
            this.cboEmployee.TabIndex = 7;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(27, 256);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(64, 13);
            this.lblCustomer.TabIndex = 8;
            this.lblCustomer.Text = "Khách Hàng";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(151, 256);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(151, 21);
            this.cboCustomer.TabIndex = 9;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(27, 297);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(75, 13);
            this.lblRoom.TabIndex = 10;
            this.lblRoom.Text = "Phòng hiện tại";
            // 
            // cboRoom
            // 
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(151, 297);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(151, 21);
            this.cboRoom.TabIndex = 11;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // dataGridView_pdk
            // 
            this.dataGridView_pdk.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView_pdk.AllowUserToAddRows = false;
            this.dataGridView_pdk.AllowUserToDeleteRows = false;
            this.dataGridView_pdk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_pdk.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_pdk.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_pdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pdk.Location = new System.Drawing.Point(3, 0);
            this.dataGridView_pdk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_pdk.MultiSelect = false;
            this.dataGridView_pdk.Name = "dataGridView_pdk";
            this.dataGridView_pdk.ReadOnly = true;
            this.dataGridView_pdk.RowHeadersVisible = false;
            this.dataGridView_pdk.RowHeadersWidth = 51;
            this.dataGridView_pdk.RowTemplate.Height = 26;
            this.dataGridView_pdk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_pdk.Size = new System.Drawing.Size(754, 448);
            this.dataGridView_pdk.TabIndex = 13;
            this.dataGridView_pdk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pdk_CellClick);
            this.dataGridView_pdk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pdk_CellContentClick);
            this.dataGridView_pdk.SelectionChanged += new System.EventHandler(this.dataGridView_pdk_SelectionChanged);
            this.dataGridView_pdk.Click += new System.EventHandler(this.dataGridView_pdk_Click);
            // 
            // groupBox_tacvu
            // 
            this.groupBox_tacvu.Controls.Add(this.button_hethan);
            this.groupBox_tacvu.Controls.Add(this.button_xemhd);
            this.groupBox_tacvu.Controls.Add(this.button_hoanthanh);
            this.groupBox_tacvu.Controls.Add(this.btnLoad);
            this.groupBox_tacvu.Controls.Add(this.btn_delete);
            this.groupBox_tacvu.Controls.Add(this.btn_modify);
            this.groupBox_tacvu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_tacvu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_tacvu.Location = new System.Drawing.Point(0, 515);
            this.groupBox_tacvu.Name = "groupBox_tacvu";
            this.groupBox_tacvu.Size = new System.Drawing.Size(1178, 184);
            this.groupBox_tacvu.TabIndex = 14;
            this.groupBox_tacvu.TabStop = false;
            this.groupBox_tacvu.Text = "Tác vụ";
            // 
            // button_hethan
            // 
            this.button_hethan.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_hethan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hethan.Location = new System.Drawing.Point(509, 43);
            this.button_hethan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_hethan.Name = "button_hethan";
            this.button_hethan.Padding = new System.Windows.Forms.Padding(3);
            this.button_hethan.Size = new System.Drawing.Size(221, 43);
            this.button_hethan.TabIndex = 17;
            this.button_hethan.Text = "Đánh dấu hết hạn";
            this.button_hethan.UseVisualStyleBackColor = true;
            this.button_hethan.Click += new System.EventHandler(this.button_hethan_Click);
            // 
            // button_xemhd
            // 
            this.button_xemhd.Enabled = false;
            this.button_xemhd.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_xemhd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xemhd.Location = new System.Drawing.Point(923, 43);
            this.button_xemhd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_xemhd.Name = "button_xemhd";
            this.button_xemhd.Padding = new System.Windows.Forms.Padding(3);
            this.button_xemhd.Size = new System.Drawing.Size(221, 43);
            this.button_xemhd.TabIndex = 16;
            this.button_xemhd.Text = "Xem thông tin hoá đơn";
            this.button_xemhd.UseVisualStyleBackColor = true;
            this.button_xemhd.Click += new System.EventHandler(this.button_xemhd_Click);
            // 
            // button_hoanthanh
            // 
            this.button_hoanthanh.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_hoanthanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hoanthanh.Location = new System.Drawing.Point(244, 43);
            this.button_hoanthanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_hoanthanh.Name = "button_hoanthanh";
            this.button_hoanthanh.Padding = new System.Windows.Forms.Padding(3);
            this.button_hoanthanh.Size = new System.Drawing.Size(221, 43);
            this.button_hoanthanh.TabIndex = 16;
            this.button_hoanthanh.Text = "Đánh dấu hoàn thành";
            this.button_hoanthanh.UseVisualStyleBackColor = true;
            this.button_hoanthanh.Click += new System.EventHandler(this.button_hoanthanh_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::QuanLyHotel.Properties.Resources.loading;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(583, 126);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Size = new System.Drawing.Size(98, 37);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "   Reload";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::QuanLyHotel.Properties.Resources.trash;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(445, 126);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(3);
            this.btn_delete.Size = new System.Drawing.Size(97, 37);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "   Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Image = global::QuanLyHotel.Properties.Resources.edit;
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.Location = new System.Drawing.Point(304, 126);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Padding = new System.Windows.Forms.Padding(3);
            this.btn_modify.Size = new System.Drawing.Size(97, 37);
            this.btn_modify.TabIndex = 3;
            this.btn_modify.Text = "   Sửa";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
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
            // tb_mapdk
            // 
            this.tb_mapdk.Enabled = false;
            this.tb_mapdk.Location = new System.Drawing.Point(151, 61);
            this.tb_mapdk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_mapdk.Name = "tb_mapdk";
            this.tb_mapdk.Size = new System.Drawing.Size(189, 20);
            this.tb_mapdk.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.dataGridView_pdk);
            this.panel1.Location = new System.Drawing.Point(399, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 448);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tb_mapdk);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.cboRoom);
            this.panel2.Controls.Add(this.lblRoom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_chuyenphong);
            this.panel2.Controls.Add(this.cboCustomer);
            this.panel2.Controls.Add(this.lblExpectedArrival);
            this.panel2.Controls.Add(this.lblCustomer);
            this.panel2.Controls.Add(this.dtpExpectedArrival);
            this.panel2.Controls.Add(this.cboEmployee);
            this.panel2.Controls.Add(this.lblExpectedDeparture);
            this.panel2.Controls.Add(this.lblEmployee);
            this.panel2.Controls.Add(this.dtpExpectedDeparture);
            this.panel2.Controls.Add(this.txtDepositAmount);
            this.panel2.Controls.Add(this.lblDepositAmount);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 448);
            this.panel2.TabIndex = 16;
            // 
            // btn_add
            // 
            this.btn_add.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(113, 20);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(3);
            this.btn_add.Size = new System.Drawing.Size(147, 37);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "   Thêm mới PĐK";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button_chuyenphong
            // 
            this.button_chuyenphong.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_chuyenphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_chuyenphong.Location = new System.Drawing.Point(110, 369);
            this.button_chuyenphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_chuyenphong.Name = "button_chuyenphong";
            this.button_chuyenphong.Padding = new System.Windows.Forms.Padding(3);
            this.button_chuyenphong.Size = new System.Drawing.Size(150, 37);
            this.button_chuyenphong.TabIndex = 1;
            this.button_chuyenphong.Text = "   Chuyển phòng";
            this.button_chuyenphong.UseVisualStyleBackColor = true;
            this.button_chuyenphong.Click += new System.EventHandler(this.button_chuyenphong_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(15, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 448);
            this.panel3.TabIndex = 17;
            // 
            // FormPhieuDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1178, 699);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_tacvu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPhieuDangKy";
            this.Text = "Tạo Phiếu Đăng Ký";
            this.Load += new System.EventHandler(this.FormPhieuDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pdk)).EndInit();
            this.groupBox_tacvu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblExpectedArrival;
        private System.Windows.Forms.DateTimePicker dtpExpectedArrival;
        private System.Windows.Forms.Label lblExpectedDeparture;
        private System.Windows.Forms.DateTimePicker dtpExpectedDeparture;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cboRoom;
        private DataGridView dataGridView_pdk;
        private GroupBox groupBox_tacvu;
        private Button btnLoad;
        private Button btn_delete;
        private Button btn_modify;
        private Button btn_add;
        private Button button_hethan;
        private Button button_hoanthanh;
        private Label label2;
        private TextBox tb_mapdk;
        private Button button_xemhd;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button_chuyenphong;
    }
}