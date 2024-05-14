using System.Windows.Forms;
using System;

namespace QuanLyHotel.EMPLOYEE
{
    partial class FormNhanVien
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
            this.tabPage_quanlynv = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView_employee = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_manql = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_lc = new System.Windows.Forms.RadioButton();
            this.radioButton_tt = new System.Windows.Forms.RadioButton();
            this.radioButton_ql = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdnu = new System.Windows.Forms.RadioButton();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.datetimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tabControl_nhanvien = new System.Windows.Forms.TabControl();
            this.roundedButton_showall = new QuanLyHotel.RoundedButton();
            this.tabPage_quanlynv.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl_nhanvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_quanlynv
            // 
            this.tabPage_quanlynv.Controls.Add(this.groupBox5);
            this.tabPage_quanlynv.Controls.Add(this.groupBox1);
            this.tabPage_quanlynv.Controls.Add(this.groupBox3);
            this.tabPage_quanlynv.Location = new System.Drawing.Point(4, 26);
            this.tabPage_quanlynv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_quanlynv.Name = "tabPage_quanlynv";
            this.tabPage_quanlynv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_quanlynv.Size = new System.Drawing.Size(1432, 937);
            this.tabPage_quanlynv.TabIndex = 0;
            this.tabPage_quanlynv.Text = "Quản lý nhân viên";
            this.tabPage_quanlynv.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView_employee);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 211);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(1426, 608);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách nhân viên:";
            // 
            // dataGridView_employee
            // 
            this.dataGridView_employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_employee.Location = new System.Drawing.Point(3, 20);
            this.dataGridView_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_employee.Name = "dataGridView_employee";
            this.dataGridView_employee.RowHeadersWidth = 51;
            this.dataGridView_employee.RowTemplate.Height = 26;
            this.dataGridView_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_employee.Size = new System.Drawing.Size(1420, 586);
            this.dataGridView_employee.TabIndex = 6;
            this.dataGridView_employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_employee_CellContentClick);
            this.dataGridView_employee.Click += new System.EventHandler(this.dataGridView_employee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roundedButton_showall);
            this.groupBox1.Controls.Add(this.comboBox_manql);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.datetimePicker_NgaySinh);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.textBox_email);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.txt_HoTen);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1426, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // comboBox_manql
            // 
            this.comboBox_manql.FormattingEnabled = true;
            this.comboBox_manql.Location = new System.Drawing.Point(889, 165);
            this.comboBox_manql.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_manql.Name = "comboBox_manql";
            this.comboBox_manql.Size = new System.Drawing.Size(104, 27);
            this.comboBox_manql.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_lc);
            this.groupBox2.Controls.Add(this.radioButton_tt);
            this.groupBox2.Controls.Add(this.radioButton_ql);
            this.groupBox2.Location = new System.Drawing.Point(455, 97);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(282, 65);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại Nhân Viên";
            this.groupBox2.EnabledChanged += new System.EventHandler(this.groupBox2_EnabledChanged);
            // 
            // radioButton_lc
            // 
            this.radioButton_lc.AutoSize = true;
            this.radioButton_lc.Location = new System.Drawing.Point(183, 28);
            this.radioButton_lc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_lc.Name = "radioButton_lc";
            this.radioButton_lc.Size = new System.Drawing.Size(83, 23);
            this.radioButton_lc.TabIndex = 2;
            this.radioButton_lc.TabStop = true;
            this.radioButton_lc.Text = "Lao công";
            this.radioButton_lc.UseVisualStyleBackColor = true;
            // 
            // radioButton_tt
            // 
            this.radioButton_tt.AutoSize = true;
            this.radioButton_tt.Location = new System.Drawing.Point(96, 28);
            this.radioButton_tt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_tt.Name = "radioButton_tt";
            this.radioButton_tt.Size = new System.Drawing.Size(76, 23);
            this.radioButton_tt.TabIndex = 1;
            this.radioButton_tt.TabStop = true;
            this.radioButton_tt.Text = "Tiếp tân";
            this.radioButton_tt.UseVisualStyleBackColor = true;
            // 
            // radioButton_ql
            // 
            this.radioButton_ql.AutoSize = true;
            this.radioButton_ql.Location = new System.Drawing.Point(14, 28);
            this.radioButton_ql.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_ql.Name = "radioButton_ql";
            this.radioButton_ql.Size = new System.Drawing.Size(75, 23);
            this.radioButton_ql.TabIndex = 0;
            this.radioButton_ql.TabStop = true;
            this.radioButton_ql.Text = "Quản lý";
            this.radioButton_ql.UseVisualStyleBackColor = true;
            this.radioButton_ql.CheckedChanged += new System.EventHandler(this.radioButton_ql_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdnu);
            this.groupBox4.Controls.Add(this.rdnam);
            this.groupBox4.Location = new System.Drawing.Point(455, 20);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(239, 67);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giới Tính";
            // 
            // rdnu
            // 
            this.rdnu.AutoSize = true;
            this.rdnu.Location = new System.Drawing.Point(112, 15);
            this.rdnu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdnu.Name = "rdnu";
            this.rdnu.Size = new System.Drawing.Size(45, 23);
            this.rdnu.TabIndex = 1;
            this.rdnu.TabStop = true;
            this.rdnu.Text = "Nữ";
            this.rdnu.UseVisualStyleBackColor = true;
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.Location = new System.Drawing.Point(14, 15);
            this.rdnam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(56, 23);
            this.rdnam.TabIndex = 0;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = true;
            // 
            // datetimePicker_NgaySinh
            // 
            this.datetimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimePicker_NgaySinh.Location = new System.Drawing.Point(120, 92);
            this.datetimePicker_NgaySinh.Name = "datetimePicker_NgaySinh";
            this.datetimePicker_NgaySinh.Size = new System.Drawing.Size(151, 26);
            this.datetimePicker_NgaySinh.TabIndex = 15;
            this.datetimePicker_NgaySinh.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChi.Location = new System.Drawing.Point(120, 128);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(252, 26);
            this.txt_DiaChi.TabIndex = 14;
            // 
            // textBox_email
            // 
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_email.Location = new System.Drawing.Point(508, 166);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_email.MaxLength = 50;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(252, 26);
            this.textBox_email.TabIndex = 10;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Location = new System.Drawing.Point(120, 166);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SDT.MaxLength = 10;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(252, 26);
            this.txt_SDT.TabIndex = 10;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HoTen.Location = new System.Drawing.Point(120, 63);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(252, 26);
            this.txt_HoTen.TabIndex = 9;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(120, 32);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(252, 26);
            this.txt_MaNV.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(788, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã NQL:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Email:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_modify);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 819);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1426, 116);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::QuanLyHotel.Properties.Resources.loading;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(272, 31);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Size = new System.Drawing.Size(98, 37);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "   Reload";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyHotel.Properties.Resources.trash;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(713, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(174, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Import Từ File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::QuanLyHotel.Properties.Resources.trash;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(537, 31);
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
            this.btn_modify.Location = new System.Drawing.Point(405, 31);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Padding = new System.Windows.Forms.Padding(3);
            this.btn_modify.Size = new System.Drawing.Size(97, 37);
            this.btn_modify.TabIndex = 3;
            this.btn_modify.Text = "   Sửa";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(140, 31);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(3);
            this.btn_add.Size = new System.Drawing.Size(97, 37);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "   Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tabControl_nhanvien
            // 
            this.tabControl_nhanvien.Controls.Add(this.tabPage_quanlynv);
            this.tabControl_nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_nhanvien.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_nhanvien.Location = new System.Drawing.Point(0, 0);
            this.tabControl_nhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_nhanvien.Name = "tabControl_nhanvien";
            this.tabControl_nhanvien.SelectedIndex = 0;
            this.tabControl_nhanvien.Size = new System.Drawing.Size(1440, 967);
            this.tabControl_nhanvien.TabIndex = 7;
            this.tabControl_nhanvien.SelectedIndexChanged += new System.EventHandler(this.tabControl_nhanvien_SelectedIndexChanged);
            // 
            // roundedButton_showall
            // 
            this.roundedButton_showall.BackColor = System.Drawing.Color.LimeGreen;
            this.roundedButton_showall.Location = new System.Drawing.Point(1022, 159);
            this.roundedButton_showall.Name = "roundedButton_showall";
            this.roundedButton_showall.Size = new System.Drawing.Size(122, 37);
            this.roundedButton_showall.TabIndex = 20;
            this.roundedButton_showall.Text = "Show All";
            this.roundedButton_showall.UseVisualStyleBackColor = false;
            this.roundedButton_showall.Click += new System.EventHandler(this.roundedButton_showall_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 967);
            this.Controls.Add(this.tabControl_nhanvien);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.Click += new System.EventHandler(this.FormNhanVien_Click);
            this.tabPage_quanlynv.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl_nhanvien.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private BindingSource employeesBindingSource;
        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private BangLuongDataSet hotelManagementDataSet;
        private TabPage tabPage_quanlynv;
        private GroupBox groupBox5;
        private DataGridView dataGridView_employee;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton_lc;
        private RadioButton radioButton_tt;
        private RadioButton radioButton_ql;
        private GroupBox groupBox4;
        private RadioButton rdnu;
        private RadioButton rdnam;
        private DateTimePicker datetimePicker_NgaySinh;
        private TextBox txt_DiaChi;
        private TextBox txt_SDT;
        private TextBox txt_HoTen;
        private TextBox txt_MaNV;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnLoad;
        private Button btn_delete;
        private Button btn_modify;
        private Button btn_add;
        private TabControl tabControl_nhanvien;
        private ComboBox comboBox_manql;
        private Label label6;
        private TextBox textBox_email;
        private Label label7;
        private Button button1;
        private RoundedButton roundedButton_showall;
    }
}