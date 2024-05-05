namespace QuanLyHotel.LamVieic
{
    partial class FormCaLamViec
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
            this.button_phanca = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_calamviec = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_ca = new System.Windows.Forms.TabPage();
            this.numericUpDown_sotuan = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.textBox_tonglc = new System.Windows.Forms.TextBox();
            this.textBox_tongtt = new System.Windows.Forms.TextBox();
            this.textBox_tongql = new System.Windows.Forms.TextBox();
            this.textBox_tongnv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_lich = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_c3 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_c2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_c1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.roundedButton_chinhsua = new QuanLyHotel.RoundedButton();
            this.roundedButton_co = new QuanLyHotel.RoundedButton();
            this.roundedButton_ci = new QuanLyHotel.RoundedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_calamviec)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage_ca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sotuan)).BeginInit();
            this.tabPage_lich.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_c3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_c2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_c1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_phanca
            // 
            this.button_phanca.Location = new System.Drawing.Point(95, 501);
            this.button_phanca.Name = "button_phanca";
            this.button_phanca.Size = new System.Drawing.Size(207, 51);
            this.button_phanca.TabIndex = 19;
            this.button_phanca.Text = "Phân Ca";
            this.button_phanca.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.dataGridView_calamviec);
            this.panel1.Location = new System.Drawing.Point(44, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 448);
            this.panel1.TabIndex = 18;
            // 
            // dataGridView_calamviec
            // 
            this.dataGridView_calamviec.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView_calamviec.AllowUserToAddRows = false;
            this.dataGridView_calamviec.AllowUserToDeleteRows = false;
            this.dataGridView_calamviec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_calamviec.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_calamviec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_calamviec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_calamviec.Location = new System.Drawing.Point(3, 0);
            this.dataGridView_calamviec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_calamviec.MultiSelect = false;
            this.dataGridView_calamviec.Name = "dataGridView_calamviec";
            this.dataGridView_calamviec.RowHeadersVisible = false;
            this.dataGridView_calamviec.RowHeadersWidth = 51;
            this.dataGridView_calamviec.RowTemplate.Height = 26;
            this.dataGridView_calamviec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_calamviec.Size = new System.Drawing.Size(530, 448);
            this.dataGridView_calamviec.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 51);
            this.button1.TabIndex = 19;
            this.button1.Text = "Phân Ca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_pc_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_ca);
            this.tabControl.Controls.Add(this.tabPage_lich);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1094, 741);
            this.tabControl.TabIndex = 20;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPage_ca
            // 
            this.tabPage_ca.Controls.Add(this.numericUpDown_sotuan);
            this.tabPage_ca.Controls.Add(this.dateTimePicker_start);
            this.tabPage_ca.Controls.Add(this.textBox_tonglc);
            this.tabPage_ca.Controls.Add(this.textBox_tongtt);
            this.tabPage_ca.Controls.Add(this.textBox_tongql);
            this.tabPage_ca.Controls.Add(this.textBox_tongnv);
            this.tabPage_ca.Controls.Add(this.label2);
            this.tabPage_ca.Controls.Add(this.label1);
            this.tabPage_ca.Controls.Add(this.label7);
            this.tabPage_ca.Controls.Add(this.label6);
            this.tabPage_ca.Controls.Add(this.label5);
            this.tabPage_ca.Controls.Add(this.label4);
            this.tabPage_ca.Controls.Add(this.roundedButton_chinhsua);
            this.tabPage_ca.Controls.Add(this.button1);
            this.tabPage_ca.Controls.Add(this.panel1);
            this.tabPage_ca.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ca.Name = "tabPage_ca";
            this.tabPage_ca.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ca.Size = new System.Drawing.Size(1086, 715);
            this.tabPage_ca.TabIndex = 0;
            this.tabPage_ca.Text = "Ca";
            this.tabPage_ca.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_sotuan
            // 
            this.numericUpDown_sotuan.Location = new System.Drawing.Point(713, 390);
            this.numericUpDown_sotuan.Name = "numericUpDown_sotuan";
            this.numericUpDown_sotuan.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_sotuan.TabIndex = 25;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_start.Location = new System.Drawing.Point(713, 348);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_start.TabIndex = 24;
            // 
            // textBox_tonglc
            // 
            this.textBox_tonglc.Enabled = false;
            this.textBox_tonglc.Location = new System.Drawing.Point(767, 175);
            this.textBox_tonglc.Name = "textBox_tonglc";
            this.textBox_tonglc.Size = new System.Drawing.Size(100, 20);
            this.textBox_tonglc.TabIndex = 23;
            // 
            // textBox_tongtt
            // 
            this.textBox_tongtt.Enabled = false;
            this.textBox_tongtt.Location = new System.Drawing.Point(767, 139);
            this.textBox_tongtt.Name = "textBox_tongtt";
            this.textBox_tongtt.Size = new System.Drawing.Size(100, 20);
            this.textBox_tongtt.TabIndex = 23;
            // 
            // textBox_tongql
            // 
            this.textBox_tongql.Enabled = false;
            this.textBox_tongql.Location = new System.Drawing.Point(767, 100);
            this.textBox_tongql.Name = "textBox_tongql";
            this.textBox_tongql.Size = new System.Drawing.Size(100, 20);
            this.textBox_tongql.TabIndex = 23;
            // 
            // textBox_tongnv
            // 
            this.textBox_tongnv.Enabled = false;
            this.textBox_tongnv.Location = new System.Drawing.Point(767, 65);
            this.textBox_tongnv.Name = "textBox_tongnv";
            this.textBox_tongnv.Size = new System.Drawing.Size(100, 20);
            this.textBox_tongnv.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Chọn số tuần:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Chọn ngày bắt đầu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(608, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tổng số lao công";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(605, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tổng số tiếp tân";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tổng số quản ly";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tổng số NV:";
            // 
            // tabPage_lich
            // 
            this.tabPage_lich.Controls.Add(this.label9);
            this.tabPage_lich.Controls.Add(this.label8);
            this.tabPage_lich.Controls.Add(this.label3);
            this.tabPage_lich.Controls.Add(this.panel4);
            this.tabPage_lich.Controls.Add(this.panel2);
            this.tabPage_lich.Controls.Add(this.dateTimePicker1);
            this.tabPage_lich.Controls.Add(this.panel3);
            this.tabPage_lich.Controls.Add(this.roundedButton_co);
            this.tabPage_lich.Controls.Add(this.roundedButton_ci);
            this.tabPage_lich.Location = new System.Drawing.Point(4, 22);
            this.tabPage_lich.Name = "tabPage_lich";
            this.tabPage_lich.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_lich.Size = new System.Drawing.Size(1086, 715);
            this.tabPage_lich.TabIndex = 1;
            this.tabPage_lich.Text = "Lịch";
            this.tabPage_lich.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panel4.Controls.Add(this.dataGridView_c3);
            this.panel4.Location = new System.Drawing.Point(91, 479);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(686, 180);
            this.panel4.TabIndex = 22;
            // 
            // dataGridView_c3
            // 
            this.dataGridView_c3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView_c3.AllowUserToAddRows = false;
            this.dataGridView_c3.AllowUserToDeleteRows = false;
            this.dataGridView_c3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_c3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_c3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_c3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_c3.Location = new System.Drawing.Point(3, -2);
            this.dataGridView_c3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_c3.MultiSelect = false;
            this.dataGridView_c3.Name = "dataGridView_c3";
            this.dataGridView_c3.ReadOnly = true;
            this.dataGridView_c3.RowHeadersVisible = false;
            this.dataGridView_c3.RowHeadersWidth = 51;
            this.dataGridView_c3.RowTemplate.Height = 26;
            this.dataGridView_c3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_c3.Size = new System.Drawing.Size(683, 182);
            this.dataGridView_c3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.dataGridView_c2);
            this.panel2.Location = new System.Drawing.Point(91, 261);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 180);
            this.panel2.TabIndex = 21;
            // 
            // dataGridView_c2
            // 
            this.dataGridView_c2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView_c2.AllowUserToAddRows = false;
            this.dataGridView_c2.AllowUserToDeleteRows = false;
            this.dataGridView_c2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_c2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_c2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_c2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_c2.Location = new System.Drawing.Point(3, -2);
            this.dataGridView_c2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_c2.MultiSelect = false;
            this.dataGridView_c2.Name = "dataGridView_c2";
            this.dataGridView_c2.ReadOnly = true;
            this.dataGridView_c2.RowHeadersVisible = false;
            this.dataGridView_c2.RowHeadersWidth = 51;
            this.dataGridView_c2.RowTemplate.Height = 26;
            this.dataGridView_c2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_c2.Size = new System.Drawing.Size(683, 182);
            this.dataGridView_c2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.dataGridView_c1);
            this.panel3.Location = new System.Drawing.Point(91, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 180);
            this.panel3.TabIndex = 18;
            // 
            // dataGridView_c1
            // 
            this.dataGridView_c1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView_c1.AllowUserToAddRows = false;
            this.dataGridView_c1.AllowUserToDeleteRows = false;
            this.dataGridView_c1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_c1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_c1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_c1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_c1.Location = new System.Drawing.Point(3, -2);
            this.dataGridView_c1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_c1.MultiSelect = false;
            this.dataGridView_c1.Name = "dataGridView_c1";
            this.dataGridView_c1.ReadOnly = true;
            this.dataGridView_c1.RowHeadersVisible = false;
            this.dataGridView_c1.RowHeadersWidth = 51;
            this.dataGridView_c1.RowTemplate.Height = 26;
            this.dataGridView_c1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_c1.Size = new System.Drawing.Size(683, 182);
            this.dataGridView_c1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ca 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ca 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 564);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ca 3";
            // 
            // roundedButton_chinhsua
            // 
            this.roundedButton_chinhsua.Location = new System.Drawing.Point(189, 471);
            this.roundedButton_chinhsua.Name = "roundedButton_chinhsua";
            this.roundedButton_chinhsua.Size = new System.Drawing.Size(175, 54);
            this.roundedButton_chinhsua.TabIndex = 20;
            this.roundedButton_chinhsua.Text = "Sữa ca";
            this.roundedButton_chinhsua.UseVisualStyleBackColor = true;
            this.roundedButton_chinhsua.Click += new System.EventHandler(this.roundedButton_chinhsua_Click);
            // 
            // roundedButton_co
            // 
            this.roundedButton_co.BackColor = System.Drawing.Color.RosyBrown;
            this.roundedButton_co.Location = new System.Drawing.Point(820, 107);
            this.roundedButton_co.Name = "roundedButton_co";
            this.roundedButton_co.Size = new System.Drawing.Size(140, 44);
            this.roundedButton_co.TabIndex = 23;
            this.roundedButton_co.Text = "Check Out";
            this.roundedButton_co.UseVisualStyleBackColor = false;
            this.roundedButton_co.Click += new System.EventHandler(this.roundedButton_co_Click);
            // 
            // roundedButton_ci
            // 
            this.roundedButton_ci.BackColor = System.Drawing.Color.RosyBrown;
            this.roundedButton_ci.Location = new System.Drawing.Point(820, 45);
            this.roundedButton_ci.Name = "roundedButton_ci";
            this.roundedButton_ci.Size = new System.Drawing.Size(140, 44);
            this.roundedButton_ci.TabIndex = 23;
            this.roundedButton_ci.Text = "Check In";
            this.roundedButton_ci.UseVisualStyleBackColor = false;
            this.roundedButton_ci.Click += new System.EventHandler(this.roundedButton_ci_Click);
            // 
            // FormCaLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 741);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.button_phanca);
            this.Name = "FormCaLamViec";
            this.Text = "FormCaLamViec";
            this.Load += new System.EventHandler(this.FormCaLamViec_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_calamviec)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage_ca.ResumeLayout(false);
            this.tabPage_ca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sotuan)).EndInit();
            this.tabPage_lich.ResumeLayout(false);
            this.tabPage_lich.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_c3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_c2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_c1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_phanca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_calamviec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_ca;
        private System.Windows.Forms.TabPage tabPage_lich;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView_c1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private RoundedButton roundedButton_chinhsua;
        private System.Windows.Forms.TextBox textBox_tonglc;
        private System.Windows.Forms.TextBox textBox_tongtt;
        private System.Windows.Forms.TextBox textBox_tongql;
        private System.Windows.Forms.TextBox textBox_tongnv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_sotuan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RoundedButton roundedButton_co;
        private RoundedButton roundedButton_ci;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_c3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_c2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}