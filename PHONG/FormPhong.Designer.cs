namespace QuanLyHotel.PHONG
{
    partial class FormPhong
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
            this.tabControl_phong = new System.Windows.Forms.TabControl();
            this.tabPage_qlphong = new System.Windows.Forms.TabPage();
            this.tabPage_qlloaiphong = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_phong = new System.Windows.Forms.DataGridView();
            this.hotelManagementDataSet1 = new QuanLyHotel.HotelManagementDataSet1();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongTableAdapter = new QuanLyHotel.HotelManagementDataSet1TableAdapters.PhongTableAdapter();
            this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangPhongDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maLoaiPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_maloaiphong = new System.Windows.Forms.ComboBox();
            this.textBox_tenloaiphong = new System.Windows.Forms.TextBox();
            this.textBox_trangthietbi = new System.Windows.Forms.TextBox();
            this.textBox_gia = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox_mota = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_maloai = new System.Windows.Forms.TextBox();
            this.txt_tenphong = new System.Windows.Forms.TextBox();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox_stt = new System.Windows.Forms.CheckBox();
            this.tabControl_phong.SuspendLayout();
            this.tabPage_qlphong.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_phong
            // 
            this.tabControl_phong.Controls.Add(this.tabPage_qlphong);
            this.tabControl_phong.Controls.Add(this.tabPage_qlloaiphong);
            this.tabControl_phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_phong.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_phong.Location = new System.Drawing.Point(0, 0);
            this.tabControl_phong.Name = "tabControl_phong";
            this.tabControl_phong.SelectedIndex = 0;
            this.tabControl_phong.Size = new System.Drawing.Size(863, 676);
            this.tabControl_phong.TabIndex = 0;
            // 
            // tabPage_qlphong
            // 
            this.tabPage_qlphong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage_qlphong.Controls.Add(this.groupBox1);
            this.tabPage_qlphong.Controls.Add(this.panel4);
            this.tabPage_qlphong.Controls.Add(this.btnLoad);
            this.tabPage_qlphong.Controls.Add(this.btn_delete);
            this.tabPage_qlphong.Controls.Add(this.btn_modify);
            this.tabPage_qlphong.Controls.Add(this.btn_add);
            this.tabPage_qlphong.Controls.Add(this.checkBox1);
            this.tabPage_qlphong.Controls.Add(this.button1);
            this.tabPage_qlphong.Controls.Add(this.textBox6);
            this.tabPage_qlphong.Controls.Add(this.panel2);
            this.tabPage_qlphong.Controls.Add(this.panel1);
            this.tabPage_qlphong.Location = new System.Drawing.Point(4, 27);
            this.tabPage_qlphong.Name = "tabPage_qlphong";
            this.tabPage_qlphong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_qlphong.Size = new System.Drawing.Size(855, 645);
            this.tabPage_qlphong.TabIndex = 0;
            this.tabPage_qlphong.Text = "Quản lý phòng";
            // 
            // tabPage_qlloaiphong
            // 
            this.tabPage_qlloaiphong.Location = new System.Drawing.Point(4, 27);
            this.tabPage_qlloaiphong.Name = "tabPage_qlloaiphong";
            this.tabPage_qlloaiphong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_qlloaiphong.Size = new System.Drawing.Size(894, 546);
            this.tabPage_qlloaiphong.TabIndex = 1;
            this.tabPage_qlloaiphong.Text = "Loại phòng";
            this.tabPage_qlloaiphong.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.dataGridView_phong);
            this.panel1.Location = new System.Drawing.Point(6, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 304);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_phong
            // 
            this.dataGridView_phong.AutoGenerateColumns = false;
            this.dataGridView_phong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhongDataGridViewTextBoxColumn,
            this.tenPhongDataGridViewTextBoxColumn,
            this.tinhTrangPhongDataGridViewCheckBoxColumn,
            this.maLoaiPhongDataGridViewTextBoxColumn});
            this.dataGridView_phong.DataSource = this.phongBindingSource;
            this.dataGridView_phong.Location = new System.Drawing.Point(14, 0);
            this.dataGridView_phong.Name = "dataGridView_phong";
            this.dataGridView_phong.Size = new System.Drawing.Size(554, 304);
            this.dataGridView_phong.TabIndex = 0;
            this.dataGridView_phong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_phong_CellContentClick);
            this.dataGridView_phong.Click += new System.EventHandler(this.dataGridView_phong_Click);
            // 
            // hotelManagementDataSet1
            // 
            this.hotelManagementDataSet1.DataSetName = "HotelManagementDataSet1";
            this.hotelManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "Phong";
            this.phongBindingSource.DataSource = this.hotelManagementDataSet1;
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // maPhongDataGridViewTextBoxColumn
            // 
            this.maPhongDataGridViewTextBoxColumn.DataPropertyName = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.HeaderText = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.Name = "maPhongDataGridViewTextBoxColumn";
            // 
            // tenPhongDataGridViewTextBoxColumn
            // 
            this.tenPhongDataGridViewTextBoxColumn.DataPropertyName = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.HeaderText = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.Name = "tenPhongDataGridViewTextBoxColumn";
            // 
            // tinhTrangPhongDataGridViewCheckBoxColumn
            // 
            this.tinhTrangPhongDataGridViewCheckBoxColumn.DataPropertyName = "TinhTrangPhong";
            this.tinhTrangPhongDataGridViewCheckBoxColumn.HeaderText = "TinhTrangPhong";
            this.tinhTrangPhongDataGridViewCheckBoxColumn.Name = "tinhTrangPhongDataGridViewCheckBoxColumn";
            // 
            // maLoaiPhongDataGridViewTextBoxColumn
            // 
            this.maLoaiPhongDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiPhong";
            this.maLoaiPhongDataGridViewTextBoxColumn.HeaderText = "MaLoaiPhong";
            this.maLoaiPhongDataGridViewTextBoxColumn.Name = "maLoaiPhongDataGridViewTextBoxColumn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(533, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 467);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.textBox_mota);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.textBox_gia);
            this.panel3.Controls.Add(this.textBox_trangthietbi);
            this.panel3.Controls.Add(this.textBox_tenloaiphong);
            this.panel3.Controls.Add(this.comboBox_maloaiphong);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(13, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 467);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "label1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "label1";
            // 
            // comboBox_maloaiphong
            // 
            this.comboBox_maloaiphong.FormattingEnabled = true;
            this.comboBox_maloaiphong.Location = new System.Drawing.Point(73, 42);
            this.comboBox_maloaiphong.Name = "comboBox_maloaiphong";
            this.comboBox_maloaiphong.Size = new System.Drawing.Size(173, 26);
            this.comboBox_maloaiphong.TabIndex = 1;
            // 
            // textBox_tenloaiphong
            // 
            this.textBox_tenloaiphong.Location = new System.Drawing.Point(73, 84);
            this.textBox_tenloaiphong.Name = "textBox_tenloaiphong";
            this.textBox_tenloaiphong.Size = new System.Drawing.Size(173, 26);
            this.textBox_tenloaiphong.TabIndex = 2;
            // 
            // textBox_trangthietbi
            // 
            this.textBox_trangthietbi.Location = new System.Drawing.Point(73, 128);
            this.textBox_trangthietbi.Multiline = true;
            this.textBox_trangthietbi.Name = "textBox_trangthietbi";
            this.textBox_trangthietbi.Size = new System.Drawing.Size(173, 107);
            this.textBox_trangthietbi.TabIndex = 2;
            // 
            // textBox_gia
            // 
            this.textBox_gia.Location = new System.Drawing.Point(73, 241);
            this.textBox_gia.Name = "textBox_gia";
            this.textBox_gia.Size = new System.Drawing.Size(173, 26);
            this.textBox_gia.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(73, 284);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(173, 26);
            this.textBox4.TabIndex = 2;
            // 
            // textBox_mota
            // 
            this.textBox_mota.Location = new System.Drawing.Point(73, 289);
            this.textBox_mota.Multiline = true;
            this.textBox_mota.Name = "textBox_mota";
            this.textBox_mota.Size = new System.Drawing.Size(173, 161);
            this.textBox_mota.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(81, 201);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(213, 26);
            this.textBox6.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(309, 208);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 22);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Còn trống";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::QuanLyHotel.Properties.Resources.loading;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(154, 596);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Size = new System.Drawing.Size(98, 37);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "   Reload";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::QuanLyHotel.Properties.Resources.trash;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(419, 596);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(3);
            this.btn_delete.Size = new System.Drawing.Size(97, 37);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "   Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_modify
            // 
            this.btn_modify.Image = global::QuanLyHotel.Properties.Resources.edit;
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.Location = new System.Drawing.Point(287, 596);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Padding = new System.Windows.Forms.Padding(3);
            this.btn_modify.Size = new System.Drawing.Size(97, 37);
            this.btn_modify.TabIndex = 8;
            this.btn_modify.Text = "   Sửa";
            this.btn_modify.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(22, 596);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(3);
            this.btn_add.Size = new System.Drawing.Size(97, 37);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "   Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.checkBox_stt);
            this.groupBox1.Controls.Add(this.txt_maloai);
            this.groupBox1.Controls.Add(this.txt_tenphong);
            this.groupBox1.Controls.Add(this.txt_maphong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 190);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // txt_maloai
            // 
            this.txt_maloai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maloai.Location = new System.Drawing.Point(120, 145);
            this.txt_maloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maloai.MaxLength = 10;
            this.txt_maloai.Name = "txt_maloai";
            this.txt_maloai.Size = new System.Drawing.Size(252, 26);
            this.txt_maloai.TabIndex = 10;
            // 
            // txt_tenphong
            // 
            this.txt_tenphong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenphong.Location = new System.Drawing.Point(120, 63);
            this.txt_tenphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenphong.Name = "txt_tenphong";
            this.txt_tenphong.Size = new System.Drawing.Size(252, 26);
            this.txt_tenphong.TabIndex = 9;
            // 
            // txt_maphong
            // 
            this.txt_maphong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maphong.Location = new System.Drawing.Point(120, 32);
            this.txt_maphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(252, 26);
            this.txt_maphong.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tình Trạng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mã loại";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tên Phòng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mã Phòng";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 190);
            this.panel4.TabIndex = 12;
            // 
            // checkBox_stt
            // 
            this.checkBox_stt.AutoSize = true;
            this.checkBox_stt.Location = new System.Drawing.Point(120, 110);
            this.checkBox_stt.Name = "checkBox_stt";
            this.checkBox_stt.Size = new System.Drawing.Size(93, 23);
            this.checkBox_stt.TabIndex = 11;
            this.checkBox_stt.Text = "Đang thuê";
            this.checkBox_stt.UseVisualStyleBackColor = true;
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 676);
            this.Controls.Add(this.tabControl_phong);
            this.Name = "FormPhong";
            this.Text = "FormPhong";
            this.Load += new System.EventHandler(this.FormPhong_Load);
            this.tabControl_phong.ResumeLayout(false);
            this.tabPage_qlphong.ResumeLayout(false);
            this.tabPage_qlphong.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_phong;
        private System.Windows.Forms.TabPage tabPage_qlphong;
        private System.Windows.Forms.TabPage tabPage_qlloaiphong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_phong;
        private HotelManagementDataSet1 hotelManagementDataSet1;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private HotelManagementDataSet1TableAdapters.PhongTableAdapter phongTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tinhTrangPhongDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox_mota;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox_gia;
        private System.Windows.Forms.TextBox textBox_trangthietbi;
        private System.Windows.Forms.TextBox textBox_tenloaiphong;
        private System.Windows.Forms.ComboBox comboBox_maloaiphong;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_maloai;
        private System.Windows.Forms.TextBox txt_tenphong;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox_stt;
    }
}