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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_stt = new System.Windows.Forms.CheckBox();
            this.txt_tenphong = new System.Windows.Forms.TextBox();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_mota = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox_gia = new System.Windows.Forms.TextBox();
            this.textBox_trangthietbi = new System.Windows.Forms.TextBox();
            this.textBox_tenloaiphong = new System.Windows.Forms.TextBox();
            this.comboBox_maloaiphong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_phong = new System.Windows.Forms.DataGridView();
            this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangPhongDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maLoaiPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementDataSet1 = new QuanLyHotel.HotelManagementDataSet1();
            this.tabPage_qlloaiphong = new System.Windows.Forms.TabPage();
            this.phongTableAdapter = new QuanLyHotel.HotelManagementDataSet1TableAdapters.PhongTableAdapter();
            this.comboBox_maloai = new System.Windows.Forms.ComboBox();
            this.button_editloaiphong = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox_p2_mota = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox_p2_gia = new System.Windows.Forms.TextBox();
            this.textBox_p2_trangthietbi = new System.Windows.Forms.TextBox();
            this.textBox_p2_tenloai = new System.Windows.Forms.TextBox();
            this.comboBox_p2_loai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button_p2_reload = new System.Windows.Forms.Button();
            this.button_p2_xoa = new System.Windows.Forms.Button();
            this.button_p2_sua = new System.Windows.Forms.Button();
            this.button_p2_them = new System.Windows.Forms.Button();
            this.tabControl_phong.SuspendLayout();
            this.tabPage_qlphong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet1)).BeginInit();
            this.tabPage_qlloaiphong.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_phong
            // 
            this.tabControl_phong.Controls.Add(this.tabPage_qlphong);
            this.tabControl_phong.Controls.Add(this.tabPage_qlloaiphong);
            this.tabControl_phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_phong.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_phong.Location = new System.Drawing.Point(0, 0);
            this.tabControl_phong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl_phong.Name = "tabControl_phong";
            this.tabControl_phong.SelectedIndex = 0;
            this.tabControl_phong.Size = new System.Drawing.Size(1007, 832);
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
            this.tabPage_qlphong.Location = new System.Drawing.Point(4, 32);
            this.tabPage_qlphong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_qlphong.Name = "tabPage_qlphong";
            this.tabPage_qlphong.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_qlphong.Size = new System.Drawing.Size(999, 796);
            this.tabPage_qlphong.TabIndex = 0;
            this.tabPage_qlphong.Text = "Quản lý phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboBox_maloai);
            this.groupBox1.Controls.Add(this.checkBox_stt);
            this.groupBox1.Controls.Add(this.txt_tenphong);
            this.groupBox1.Controls.Add(this.txt_maphong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(554, 234);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // checkBox_stt
            // 
            this.checkBox_stt.AutoSize = true;
            this.checkBox_stt.Location = new System.Drawing.Point(140, 135);
            this.checkBox_stt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_stt.Name = "checkBox_stt";
            this.checkBox_stt.Size = new System.Drawing.Size(93, 27);
            this.checkBox_stt.TabIndex = 11;
            this.checkBox_stt.Text = "Đã thuê";
            this.checkBox_stt.UseVisualStyleBackColor = true;
            // 
            // txt_tenphong
            // 
            this.txt_tenphong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenphong.Location = new System.Drawing.Point(140, 78);
            this.txt_tenphong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_tenphong.Name = "txt_tenphong";
            this.txt_tenphong.Size = new System.Drawing.Size(294, 30);
            this.txt_tenphong.TabIndex = 9;
            // 
            // txt_maphong
            // 
            this.txt_maphong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maphong.Location = new System.Drawing.Point(140, 39);
            this.txt_maphong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(294, 30);
            this.txt_maphong.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tình Trạng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mã loại";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tên Phòng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mã Phòng";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(5, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(570, 234);
            this.panel4.TabIndex = 12;
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::QuanLyHotel.Properties.Resources.loading;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(180, 734);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLoad.Size = new System.Drawing.Size(114, 46);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "   Reload";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::QuanLyHotel.Properties.Resources.trash;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(489, 734);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Size = new System.Drawing.Size(113, 46);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "   Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_modify
            // 
            this.btn_modify.Image = global::QuanLyHotel.Properties.Resources.edit;
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.Location = new System.Drawing.Point(335, 734);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_modify.Size = new System.Drawing.Size(113, 46);
            this.btn_modify.TabIndex = 8;
            this.btn_modify.Text = "   Sửa";
            this.btn_modify.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(26, 734);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Size = new System.Drawing.Size(113, 46);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "   Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(360, 256);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 27);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Còn trống";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(94, 247);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(248, 30);
            this.textBox6.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(622, 130);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 575);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button_editloaiphong);
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
            this.panel3.Location = new System.Drawing.Point(15, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 575);
            this.panel3.TabIndex = 2;
            // 
            // textBox_mota
            // 
            this.textBox_mota.Enabled = false;
            this.textBox_mota.Location = new System.Drawing.Point(65, 290);
            this.textBox_mota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_mota.Multiline = true;
            this.textBox_mota.Name = "textBox_mota";
            this.textBox_mota.Size = new System.Drawing.Size(247, 197);
            this.textBox_mota.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(65, 284);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(247, 30);
            this.textBox4.TabIndex = 2;
            // 
            // textBox_gia
            // 
            this.textBox_gia.Enabled = false;
            this.textBox_gia.Location = new System.Drawing.Point(65, 231);
            this.textBox_gia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_gia.Name = "textBox_gia";
            this.textBox_gia.Size = new System.Drawing.Size(247, 30);
            this.textBox_gia.TabIndex = 2;
            // 
            // textBox_trangthietbi
            // 
            this.textBox_trangthietbi.Enabled = false;
            this.textBox_trangthietbi.Location = new System.Drawing.Point(65, 117);
            this.textBox_trangthietbi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_trangthietbi.Multiline = true;
            this.textBox_trangthietbi.Name = "textBox_trangthietbi";
            this.textBox_trangthietbi.Size = new System.Drawing.Size(247, 100);
            this.textBox_trangthietbi.TabIndex = 2;
            // 
            // textBox_tenloaiphong
            // 
            this.textBox_tenloaiphong.Enabled = false;
            this.textBox_tenloaiphong.Location = new System.Drawing.Point(65, 62);
            this.textBox_tenloaiphong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_tenloaiphong.Name = "textBox_tenloaiphong";
            this.textBox_tenloaiphong.Size = new System.Drawing.Size(247, 30);
            this.textBox_tenloaiphong.TabIndex = 2;
            // 
            // comboBox_maloaiphong
            // 
            this.comboBox_maloaiphong.Enabled = false;
            this.comboBox_maloaiphong.FormattingEnabled = true;
            this.comboBox_maloaiphong.Location = new System.Drawing.Point(65, 11);
            this.comboBox_maloaiphong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_maloaiphong.Name = "comboBox_maloaiphong";
            this.comboBox_maloaiphong.Size = new System.Drawing.Size(247, 31);
            this.comboBox_maloaiphong.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 293);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "label1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.dataGridView_phong);
            this.panel1.Location = new System.Drawing.Point(7, 331);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 374);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_phong
            // 
            this.dataGridView_phong.AllowUserToAddRows = false;
            this.dataGridView_phong.AutoGenerateColumns = false;
            this.dataGridView_phong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhongDataGridViewTextBoxColumn,
            this.tenPhongDataGridViewTextBoxColumn,
            this.tinhTrangPhongDataGridViewCheckBoxColumn,
            this.maLoaiPhongDataGridViewTextBoxColumn});
            this.dataGridView_phong.DataSource = this.phongBindingSource;
            this.dataGridView_phong.Location = new System.Drawing.Point(16, 0);
            this.dataGridView_phong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_phong.Name = "dataGridView_phong";
            this.dataGridView_phong.RowHeadersWidth = 51;
            this.dataGridView_phong.Size = new System.Drawing.Size(646, 374);
            this.dataGridView_phong.TabIndex = 0;
            this.dataGridView_phong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_phong_CellContentClick);
            this.dataGridView_phong.Click += new System.EventHandler(this.dataGridView_phong_Click);
            // 
            // maPhongDataGridViewTextBoxColumn
            // 
            this.maPhongDataGridViewTextBoxColumn.DataPropertyName = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.HeaderText = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhongDataGridViewTextBoxColumn.Name = "maPhongDataGridViewTextBoxColumn";
            this.maPhongDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenPhongDataGridViewTextBoxColumn
            // 
            this.tenPhongDataGridViewTextBoxColumn.DataPropertyName = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.HeaderText = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenPhongDataGridViewTextBoxColumn.Name = "tenPhongDataGridViewTextBoxColumn";
            this.tenPhongDataGridViewTextBoxColumn.Width = 125;
            // 
            // tinhTrangPhongDataGridViewCheckBoxColumn
            // 
            this.tinhTrangPhongDataGridViewCheckBoxColumn.DataPropertyName = "TinhTrangPhong";
            this.tinhTrangPhongDataGridViewCheckBoxColumn.HeaderText = "TinhTrangPhong";
            this.tinhTrangPhongDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.tinhTrangPhongDataGridViewCheckBoxColumn.Name = "tinhTrangPhongDataGridViewCheckBoxColumn";
            this.tinhTrangPhongDataGridViewCheckBoxColumn.Width = 125;
            // 
            // maLoaiPhongDataGridViewTextBoxColumn
            // 
            this.maLoaiPhongDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiPhong";
            this.maLoaiPhongDataGridViewTextBoxColumn.HeaderText = "MaLoaiPhong";
            this.maLoaiPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLoaiPhongDataGridViewTextBoxColumn.Name = "maLoaiPhongDataGridViewTextBoxColumn";
            this.maLoaiPhongDataGridViewTextBoxColumn.Width = 125;
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "Phong";
            this.phongBindingSource.DataSource = this.hotelManagementDataSet1;
            // 
            // hotelManagementDataSet1
            // 
            this.hotelManagementDataSet1.DataSetName = "HotelManagementDataSet1";
            this.hotelManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage_qlloaiphong
            // 
            this.tabPage_qlloaiphong.Controls.Add(this.panel5);
            this.tabPage_qlloaiphong.Location = new System.Drawing.Point(4, 32);
            this.tabPage_qlloaiphong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_qlloaiphong.Name = "tabPage_qlloaiphong";
            this.tabPage_qlloaiphong.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_qlloaiphong.Size = new System.Drawing.Size(999, 796);
            this.tabPage_qlloaiphong.TabIndex = 1;
            this.tabPage_qlloaiphong.Text = "Loại phòng";
            this.tabPage_qlloaiphong.UseVisualStyleBackColor = true;
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_maloai
            // 
            this.comboBox_maloai.FormattingEnabled = true;
            this.comboBox_maloai.Location = new System.Drawing.Point(140, 174);
            this.comboBox_maloai.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_maloai.Name = "comboBox_maloai";
            this.comboBox_maloai.Size = new System.Drawing.Size(294, 31);
            this.comboBox_maloai.TabIndex = 12;
            // 
            // button_editloaiphong
            // 
            this.button_editloaiphong.Image = global::QuanLyHotel.Properties.Resources.edit;
            this.button_editloaiphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_editloaiphong.Location = new System.Drawing.Point(126, 507);
            this.button_editloaiphong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_editloaiphong.Name = "button_editloaiphong";
            this.button_editloaiphong.Padding = new System.Windows.Forms.Padding(4);
            this.button_editloaiphong.Size = new System.Drawing.Size(113, 46);
            this.button_editloaiphong.TabIndex = 9;
            this.button_editloaiphong.Text = "   Sửa";
            this.button_editloaiphong.UseVisualStyleBackColor = true;
            this.button_editloaiphong.Click += new System.EventHandler(this.button_editloaiphong_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(90, 30);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(848, 575);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.button_p2_reload);
            this.panel6.Controls.Add(this.button_p2_xoa);
            this.panel6.Controls.Add(this.button_p2_sua);
            this.panel6.Controls.Add(this.button_p2_them);
            this.panel6.Controls.Add(this.textBox_p2_mota);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.textBox_p2_gia);
            this.panel6.Controls.Add(this.textBox_p2_trangthietbi);
            this.panel6.Controls.Add(this.textBox_p2_tenloai);
            this.panel6.Controls.Add(this.comboBox_p2_loai);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(15, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(814, 575);
            this.panel6.TabIndex = 2;
            // 
            // textBox_p2_mota
            // 
            this.textBox_p2_mota.Location = new System.Drawing.Point(292, 283);
            this.textBox_p2_mota.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_p2_mota.Multiline = true;
            this.textBox_p2_mota.Name = "textBox_p2_mota";
            this.textBox_p2_mota.Size = new System.Drawing.Size(247, 197);
            this.textBox_p2_mota.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 277);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 30);
            this.textBox2.TabIndex = 2;
            // 
            // textBox_p2_gia
            // 
            this.textBox_p2_gia.Location = new System.Drawing.Point(292, 224);
            this.textBox_p2_gia.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_p2_gia.Name = "textBox_p2_gia";
            this.textBox_p2_gia.Size = new System.Drawing.Size(247, 30);
            this.textBox_p2_gia.TabIndex = 2;
            // 
            // textBox_p2_trangthietbi
            // 
            this.textBox_p2_trangthietbi.Location = new System.Drawing.Point(292, 110);
            this.textBox_p2_trangthietbi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_p2_trangthietbi.Multiline = true;
            this.textBox_p2_trangthietbi.Name = "textBox_p2_trangthietbi";
            this.textBox_p2_trangthietbi.Size = new System.Drawing.Size(247, 100);
            this.textBox_p2_trangthietbi.TabIndex = 2;
            // 
            // textBox_p2_tenloai
            // 
            this.textBox_p2_tenloai.Location = new System.Drawing.Point(292, 55);
            this.textBox_p2_tenloai.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_p2_tenloai.Name = "textBox_p2_tenloai";
            this.textBox_p2_tenloai.Size = new System.Drawing.Size(247, 30);
            this.textBox_p2_tenloai.TabIndex = 2;
            // 
            // comboBox_p2_loai
            // 
            this.comboBox_p2_loai.FormattingEnabled = true;
            this.comboBox_p2_loai.Location = new System.Drawing.Point(292, 4);
            this.comboBox_p2_loai.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_p2_loai.Name = "comboBox_p2_loai";
            this.comboBox_p2_loai.Size = new System.Drawing.Size(247, 31);
            this.comboBox_p2_loai.TabIndex = 1;
            this.comboBox_p2_loai.SelectedIndexChanged += new System.EventHandler(this.comboBox_p2_loai_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "label1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 238);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "label1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 118);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "label1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(145, 64);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "label1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(145, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "label14";
            // 
            // button_p2_reload
            // 
            this.button_p2_reload.Image = global::QuanLyHotel.Properties.Resources.loading;
            this.button_p2_reload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_p2_reload.Location = new System.Drawing.Point(255, 507);
            this.button_p2_reload.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_p2_reload.Name = "button_p2_reload";
            this.button_p2_reload.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_p2_reload.Size = new System.Drawing.Size(114, 46);
            this.button_p2_reload.TabIndex = 14;
            this.button_p2_reload.Text = "   Reload";
            this.button_p2_reload.UseVisualStyleBackColor = true;
            this.button_p2_reload.Click += new System.EventHandler(this.button_p2_reload_Click);
            // 
            // button_p2_xoa
            // 
            this.button_p2_xoa.Image = global::QuanLyHotel.Properties.Resources.trash;
            this.button_p2_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_p2_xoa.Location = new System.Drawing.Point(564, 507);
            this.button_p2_xoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_p2_xoa.Name = "button_p2_xoa";
            this.button_p2_xoa.Padding = new System.Windows.Forms.Padding(4);
            this.button_p2_xoa.Size = new System.Drawing.Size(113, 46);
            this.button_p2_xoa.TabIndex = 13;
            this.button_p2_xoa.Text = "   Xóa";
            this.button_p2_xoa.UseVisualStyleBackColor = true;
            this.button_p2_xoa.Click += new System.EventHandler(this.button_p2_xoa_Click);
            // 
            // button_p2_sua
            // 
            this.button_p2_sua.Image = global::QuanLyHotel.Properties.Resources.edit;
            this.button_p2_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_p2_sua.Location = new System.Drawing.Point(410, 507);
            this.button_p2_sua.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_p2_sua.Name = "button_p2_sua";
            this.button_p2_sua.Padding = new System.Windows.Forms.Padding(4);
            this.button_p2_sua.Size = new System.Drawing.Size(113, 46);
            this.button_p2_sua.TabIndex = 12;
            this.button_p2_sua.Text = "   Sửa";
            this.button_p2_sua.UseVisualStyleBackColor = true;
            this.button_p2_sua.Click += new System.EventHandler(this.button_p2_sua_Click);
            // 
            // button_p2_them
            // 
            this.button_p2_them.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_p2_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_p2_them.Location = new System.Drawing.Point(101, 507);
            this.button_p2_them.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_p2_them.Name = "button_p2_them";
            this.button_p2_them.Padding = new System.Windows.Forms.Padding(4);
            this.button_p2_them.Size = new System.Drawing.Size(113, 46);
            this.button_p2_them.TabIndex = 11;
            this.button_p2_them.Text = "   Thêm";
            this.button_p2_them.UseVisualStyleBackColor = true;
            this.button_p2_them.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 832);
            this.Controls.Add(this.tabControl_phong);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPhong";
            this.Text = "FormPhong";
            this.Load += new System.EventHandler(this.FormPhong_Load);
            this.tabControl_phong.ResumeLayout(false);
            this.tabPage_qlphong.ResumeLayout(false);
            this.tabPage_qlphong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet1)).EndInit();
            this.tabPage_qlloaiphong.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_tenphong;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox_stt;
        private System.Windows.Forms.ComboBox comboBox_maloai;
        private System.Windows.Forms.Button button_editloaiphong;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox_p2_mota;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox_p2_gia;
        private System.Windows.Forms.TextBox textBox_p2_trangthietbi;
        private System.Windows.Forms.TextBox textBox_p2_tenloai;
        private System.Windows.Forms.ComboBox comboBox_p2_loai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_p2_reload;
        private System.Windows.Forms.Button button_p2_xoa;
        private System.Windows.Forms.Button button_p2_sua;
        private System.Windows.Forms.Button button_p2_them;
    }
}