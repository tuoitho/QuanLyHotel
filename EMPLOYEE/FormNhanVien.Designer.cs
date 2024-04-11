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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_lc = new System.Windows.Forms.RadioButton();
            this.radioButton_tt = new System.Windows.Forms.RadioButton();
            this.radioButton_ql = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdnu = new System.Windows.Forms.RadioButton();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.datetimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView_employee = new System.Windows.Forms.DataGridView();
            this.hotelManagementDataSet = new QuanLyHotel.HotelManagementDataSet();
            this.employeesTableAdapter = new QuanLyHotel.HotelManagementDataSetTableAdapters.EmployeesTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl_nhanvien = new System.Windows.Forms.TabControl();
            this.tabPage_quanlynv = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage_capacc = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl_nhanvien.SuspendLayout();
            this.tabPage_quanlynv.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.datetimePicker_NgaySinh);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.txt_HoTen);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(950, 257);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_lc);
            this.groupBox2.Controls.Add(this.radioButton_tt);
            this.groupBox2.Controls.Add(this.radioButton_ql);
            this.groupBox2.Location = new System.Drawing.Point(531, 119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Size = new System.Drawing.Size(329, 80);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại Nhân Viên";
            // 
            // radioButton_lc
            // 
            this.radioButton_lc.AutoSize = true;
            this.radioButton_lc.Location = new System.Drawing.Point(214, 34);
            this.radioButton_lc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButton_lc.Name = "radioButton_lc";
            this.radioButton_lc.Size = new System.Drawing.Size(101, 27);
            this.radioButton_lc.TabIndex = 2;
            this.radioButton_lc.TabStop = true;
            this.radioButton_lc.Text = "Lao công";
            this.radioButton_lc.UseVisualStyleBackColor = true;
            // 
            // radioButton_tt
            // 
            this.radioButton_tt.AutoSize = true;
            this.radioButton_tt.Location = new System.Drawing.Point(112, 34);
            this.radioButton_tt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButton_tt.Name = "radioButton_tt";
            this.radioButton_tt.Size = new System.Drawing.Size(93, 27);
            this.radioButton_tt.TabIndex = 1;
            this.radioButton_tt.TabStop = true;
            this.radioButton_tt.Text = "Tiếp tân";
            this.radioButton_tt.UseVisualStyleBackColor = true;
            // 
            // radioButton_ql
            // 
            this.radioButton_ql.AutoSize = true;
            this.radioButton_ql.Location = new System.Drawing.Point(16, 34);
            this.radioButton_ql.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButton_ql.Name = "radioButton_ql";
            this.radioButton_ql.Size = new System.Drawing.Size(90, 27);
            this.radioButton_ql.TabIndex = 0;
            this.radioButton_ql.TabStop = true;
            this.radioButton_ql.Text = "Quản lý";
            this.radioButton_ql.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdnu);
            this.groupBox4.Controls.Add(this.rdnam);
            this.groupBox4.Location = new System.Drawing.Point(531, 25);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Size = new System.Drawing.Size(279, 82);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giới Tính";
            // 
            // rdnu
            // 
            this.rdnu.AutoSize = true;
            this.rdnu.Location = new System.Drawing.Point(131, 18);
            this.rdnu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdnu.Name = "rdnu";
            this.rdnu.Size = new System.Drawing.Size(54, 27);
            this.rdnu.TabIndex = 1;
            this.rdnu.TabStop = true;
            this.rdnu.Text = "Nữ";
            this.rdnu.UseVisualStyleBackColor = true;
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.Location = new System.Drawing.Point(16, 18);
            this.rdnam.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(68, 27);
            this.rdnam.TabIndex = 0;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = true;
            // 
            // datetimePicker_NgaySinh
            // 
            this.datetimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimePicker_NgaySinh.Location = new System.Drawing.Point(140, 113);
            this.datetimePicker_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datetimePicker_NgaySinh.Name = "datetimePicker_NgaySinh";
            this.datetimePicker_NgaySinh.Size = new System.Drawing.Size(176, 30);
            this.datetimePicker_NgaySinh.TabIndex = 15;
            this.datetimePicker_NgaySinh.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChi.Location = new System.Drawing.Point(140, 158);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(294, 30);
            this.txt_DiaChi.TabIndex = 14;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Location = new System.Drawing.Point(140, 204);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_SDT.MaxLength = 10;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(294, 30);
            this.txt_SDT.TabIndex = 10;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HoTen.Location = new System.Drawing.Point(140, 78);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(294, 30);
            this.txt_HoTen.TabIndex = 9;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(140, 39);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(294, 30);
            this.txt_MaNV.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_modify);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 656);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(950, 107);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
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
            this.btn_delete.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_modify.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_add.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Size = new System.Drawing.Size(113, 46);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "   Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView_employee
            // 
            this.dataGridView_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employee.Location = new System.Drawing.Point(7, 27);
            this.dataGridView_employee.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView_employee.Name = "dataGridView_employee";
            this.dataGridView_employee.RowHeadersWidth = 51;
            this.dataGridView_employee.RowTemplate.Height = 26;
            this.dataGridView_employee.Size = new System.Drawing.Size(925, 329);
            this.dataGridView_employee.TabIndex = 6;
            this.dataGridView_employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_employee_CellContentClick);
            this.dataGridView_employee.Click += new System.EventHandler(this.dataGridView_employee_Click);
            // 
            // hotelManagementDataSet
            // 
            this.hotelManagementDataSet.DataSetName = "HotelManagementDataSet";
            this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Employees";
            this.bindingSource1.DataSource = this.hotelManagementDataSet;
            // 
            // tabControl_nhanvien
            // 
            this.tabControl_nhanvien.Controls.Add(this.tabPage_quanlynv);
            this.tabControl_nhanvien.Controls.Add(this.tabPage2);
            this.tabControl_nhanvien.Controls.Add(this.tabPage_capacc);
            this.tabControl_nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_nhanvien.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_nhanvien.Location = new System.Drawing.Point(0, 0);
            this.tabControl_nhanvien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabControl_nhanvien.Name = "tabControl_nhanvien";
            this.tabControl_nhanvien.SelectedIndex = 0;
            this.tabControl_nhanvien.Size = new System.Drawing.Size(966, 800);
            this.tabControl_nhanvien.TabIndex = 7;
            // 
            // tabPage_quanlynv
            // 
            this.tabPage_quanlynv.Controls.Add(this.groupBox5);
            this.tabPage_quanlynv.Controls.Add(this.groupBox1);
            this.tabPage_quanlynv.Controls.Add(this.groupBox3);
            this.tabPage_quanlynv.Location = new System.Drawing.Point(4, 31);
            this.tabPage_quanlynv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage_quanlynv.Name = "tabPage_quanlynv";
            this.tabPage_quanlynv.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage_quanlynv.Size = new System.Drawing.Size(958, 765);
            this.tabPage_quanlynv.TabIndex = 0;
            this.tabPage_quanlynv.Text = "Quản lý nhân viên";
            this.tabPage_quanlynv.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView_employee);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(4, 259);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox5.Size = new System.Drawing.Size(950, 361);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách nhân viên:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage2.Size = new System.Drawing.Size(958, 765);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ca làm việc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage_capacc
            // 
            this.tabPage_capacc.Location = new System.Drawing.Point(4, 31);
            this.tabPage_capacc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_capacc.Name = "tabPage_capacc";
            this.tabPage_capacc.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_capacc.Size = new System.Drawing.Size(958, 765);
            this.tabPage_capacc.TabIndex = 2;
            this.tabPage_capacc.Text = "Cấp Tài Khoản";
            this.tabPage_capacc.UseVisualStyleBackColor = true;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 800);
            this.Controls.Add(this.tabControl_nhanvien);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.Click += new System.EventHandler(this.FormNhanVien_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabControl_nhanvien.ResumeLayout(false);
            this.tabPage_quanlynv.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private GroupBox groupBox1;
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
        private GroupBox groupBox2;
        private RadioButton radioButton_lc;
        private RadioButton radioButton_tt;
        private RadioButton radioButton_ql;
        private GroupBox groupBox3;
        private Button btnLoad;
        private Button btn_delete;
        private Button btn_modify;
        private Button btn_add;
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
        private DataGridView dataGridView_employee;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private HotelManagementDataSet hotelManagementDataSet;
        private HotelManagementDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private BindingSource bindingSource1;
        private TabControl tabControl_nhanvien;
        private TabPage tabPage_quanlynv;
        private TabPage tabPage2;
        private GroupBox groupBox5;
        private TabPage tabPage_capacc;
    }
}