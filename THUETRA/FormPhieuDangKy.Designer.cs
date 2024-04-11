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
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.dataGridView_pdk = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mapdk = new System.Windows.Forms.TextBox();
            this.button_hethan = new System.Windows.Forms.Button();
            this.button_xemhd = new System.Windows.Forms.Button();
            this.button_hoanthanh = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pdk)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExpectedArrival
            // 
            this.lblExpectedArrival.AutoSize = true;
            this.lblExpectedArrival.Location = new System.Drawing.Point(25, 108);
            this.lblExpectedArrival.Name = "lblExpectedArrival";
            this.lblExpectedArrival.Size = new System.Drawing.Size(85, 17);
            this.lblExpectedArrival.TabIndex = 0;
            this.lblExpectedArrival.Text = "Dự Kiến Đến";
            // 
            // dtpExpectedArrival
            // 
            this.dtpExpectedArrival.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpExpectedArrival.Location = new System.Drawing.Point(156, 108);
            this.dtpExpectedArrival.Name = "dtpExpectedArrival";
            this.dtpExpectedArrival.Size = new System.Drawing.Size(265, 24);
            this.dtpExpectedArrival.TabIndex = 1;
            // 
            // lblExpectedDeparture
            // 
            this.lblExpectedDeparture.AutoSize = true;
            this.lblExpectedDeparture.Location = new System.Drawing.Point(25, 158);
            this.lblExpectedDeparture.Name = "lblExpectedDeparture";
            this.lblExpectedDeparture.Size = new System.Drawing.Size(72, 17);
            this.lblExpectedDeparture.TabIndex = 2;
            this.lblExpectedDeparture.Text = "Dự Kiến Đi";
            // 
            // dtpExpectedDeparture
            // 
            this.dtpExpectedDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpExpectedDeparture.Location = new System.Drawing.Point(156, 158);
            this.dtpExpectedDeparture.Name = "dtpExpectedDeparture";
            this.dtpExpectedDeparture.Size = new System.Drawing.Size(265, 24);
            this.dtpExpectedDeparture.TabIndex = 3;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Location = new System.Drawing.Point(25, 208);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(87, 17);
            this.lblDepositAmount.TabIndex = 4;
            this.lblDepositAmount.Text = "Tiền Đặt Cọc";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(156, 208);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(176, 24);
            this.txtDepositAmount.TabIndex = 5;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(25, 258);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(69, 17);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Nhân Viên";
            // 
            // cboEmployee
            // 
            this.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(156, 258);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(176, 24);
            this.cboEmployee.TabIndex = 7;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(25, 308);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(82, 17);
            this.lblCustomer.TabIndex = 8;
            this.lblCustomer.Text = "Khách Hàng";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(156, 308);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(176, 24);
            this.cboCustomer.TabIndex = 9;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(25, 358);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(48, 17);
            this.lblRoom.TabIndex = 10;
            this.lblRoom.Text = "Phòng";
            // 
            // cboRoom
            // 
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(156, 358);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(176, 24);
            this.cboRoom.TabIndex = 11;
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Location = new System.Drawing.Point(156, 408);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(88, 30);
            this.btnCreateBooking.TabIndex = 12;
            this.btnCreateBooking.Text = "Tạo";
            // 
            // dataGridView_pdk
            // 
            this.dataGridView_pdk.AllowUserToAddRows = false;
            this.dataGridView_pdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pdk.Location = new System.Drawing.Point(427, 50);
            this.dataGridView_pdk.Name = "dataGridView_pdk";
            this.dataGridView_pdk.RowHeadersWidth = 51;
            this.dataGridView_pdk.RowTemplate.Height = 26;
            this.dataGridView_pdk.Size = new System.Drawing.Size(572, 424);
            this.dataGridView_pdk.TabIndex = 13;
            this.dataGridView_pdk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pdk_CellClick);
            this.dataGridView_pdk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pdk_CellContentClick);
            this.dataGridView_pdk.SelectionChanged += new System.EventHandler(this.dataGridView_pdk_SelectionChanged);
            this.dataGridView_pdk.Click += new System.EventHandler(this.dataGridView_pdk_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_hethan);
            this.groupBox3.Controls.Add(this.button_xemhd);
            this.groupBox3.Controls.Add(this.button_hoanthanh);
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_modify);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 481);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1029, 217);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã PĐK";
            // 
            // tb_mapdk
            // 
            this.tb_mapdk.Enabled = false;
            this.tb_mapdk.Location = new System.Drawing.Point(156, 68);
            this.tb_mapdk.Name = "tb_mapdk";
            this.tb_mapdk.Size = new System.Drawing.Size(176, 24);
            this.tb_mapdk.TabIndex = 5;
            // 
            // button_hethan
            // 
            this.button_hethan.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_hethan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hethan.Location = new System.Drawing.Point(163, 145);
            this.button_hethan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_hethan.Name = "button_hethan";
            this.button_hethan.Padding = new System.Windows.Forms.Padding(4);
            this.button_hethan.Size = new System.Drawing.Size(258, 53);
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
            this.button_xemhd.Location = new System.Drawing.Point(481, 88);
            this.button_xemhd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_xemhd.Name = "button_xemhd";
            this.button_xemhd.Padding = new System.Windows.Forms.Padding(4);
            this.button_xemhd.Size = new System.Drawing.Size(258, 53);
            this.button_xemhd.TabIndex = 16;
            this.button_xemhd.Text = "Xem thông tin hoá đơn";
            this.button_xemhd.UseVisualStyleBackColor = true;
            this.button_xemhd.Click += new System.EventHandler(this.button_xemhd_Click);
            // 
            // button_hoanthanh
            // 
            this.button_hoanthanh.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_hoanthanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hoanthanh.Location = new System.Drawing.Point(163, 88);
            this.button_hoanthanh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_hoanthanh.Name = "button_hoanthanh";
            this.button_hoanthanh.Padding = new System.Windows.Forms.Padding(4);
            this.button_hoanthanh.Size = new System.Drawing.Size(258, 53);
            this.button_hoanthanh.TabIndex = 16;
            this.button_hoanthanh.Text = "Đánh dấu hoàn thành";
            this.button_hoanthanh.UseVisualStyleBackColor = true;
            this.button_hoanthanh.Click += new System.EventHandler(this.button_hoanthanh_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::QuanLyHotel.Properties.Resources.loading;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(317, 38);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLoad.Size = new System.Drawing.Size(114, 46);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "   Reload";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::QuanLyHotel.Properties.Resources.trash;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(626, 38);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(4);
            this.btn_delete.Size = new System.Drawing.Size(113, 46);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "   Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Image = global::QuanLyHotel.Properties.Resources.edit;
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.Location = new System.Drawing.Point(472, 38);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Padding = new System.Windows.Forms.Padding(4);
            this.btn_modify.Size = new System.Drawing.Size(113, 46);
            this.btn_modify.TabIndex = 3;
            this.btn_modify.Text = "   Sửa";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(163, 38);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(4);
            this.btn_add.Size = new System.Drawing.Size(113, 46);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "   Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FormPhieuDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 698);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView_pdk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblExpectedArrival);
            this.Controls.Add(this.dtpExpectedArrival);
            this.Controls.Add(this.lblExpectedDeparture);
            this.Controls.Add(this.dtpExpectedDeparture);
            this.Controls.Add(this.lblDepositAmount);
            this.Controls.Add(this.tb_mapdk);
            this.Controls.Add(this.txtDepositAmount);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cboEmployee);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.cboRoom);
            this.Controls.Add(this.btnCreateBooking);
            this.Name = "FormPhieuDangKy";
            this.Text = "Tạo Phiếu Đăng Ký";
            this.Load += new System.EventHandler(this.FormPhieuDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pdk)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnCreateBooking;
        private DataGridView dataGridView_pdk;
        private GroupBox groupBox3;
        private Button btnLoad;
        private Button btn_delete;
        private Button btn_modify;
        private Button btn_add;
        private Button button_hethan;
        private Button button_hoanthanh;
        private Label label2;
        private TextBox tb_mapdk;
        private Button button_xemhd;
    }
}