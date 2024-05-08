namespace QuanLyHotel.DICHVU
{
    partial class FormQuanLyDichVu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_maldv = new System.Windows.Forms.ComboBox();
            this.textBox_tenldv = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_tendv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_dangkidv = new System.Windows.Forms.Button();
            this.comboBox_dv = new System.Windows.Forms.ComboBox();
            this.comboBox_loaidv = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_giadv = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox_tenldv);
            this.panel1.Controls.Add(this.comboBox_maldv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(81, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 467);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại dv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại Dịch Vụ";
            // 
            // comboBox_maldv
            // 
            this.comboBox_maldv.FormattingEnabled = true;
            this.comboBox_maldv.Location = new System.Drawing.Point(134, 87);
            this.comboBox_maldv.Name = "comboBox_maldv";
            this.comboBox_maldv.Size = new System.Drawing.Size(121, 21);
            this.comboBox_maldv.TabIndex = 1;
            this.comboBox_maldv.SelectedValueChanged += new System.EventHandler(this.comboBox_maldv_SelectedValueChanged);
            // 
            // textBox_tenldv
            // 
            this.textBox_tenldv.Location = new System.Drawing.Point(134, 148);
            this.textBox_tenldv.Name = "textBox_tenldv";
            this.textBox_tenldv.Size = new System.Drawing.Size(121, 20);
            this.textBox_tenldv.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_modify);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btn_dangkidv);
            this.panel2.Controls.Add(this.comboBox_dv);
            this.panel2.Controls.Add(this.comboBox_loaidv);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox_giadv);
            this.panel2.Controls.Add(this.textBox_tendv);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(562, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 467);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox_tendv
            // 
            this.textBox_tendv.Location = new System.Drawing.Point(157, 181);
            this.textBox_tendv.Name = "textBox_tendv";
            this.textBox_tendv.Size = new System.Drawing.Size(151, 20);
            this.textBox_tendv.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Dịch Vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Chọn Loại Dịch Vụ";
            // 
            // btn_dangkidv
            // 
            this.btn_dangkidv.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.btn_dangkidv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangkidv.Location = new System.Drawing.Point(116, 464);
            this.btn_dangkidv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dangkidv.Name = "btn_dangkidv";
            this.btn_dangkidv.Padding = new System.Windows.Forms.Padding(3);
            this.btn_dangkidv.Size = new System.Drawing.Size(152, 37);
            this.btn_dangkidv.TabIndex = 20;
            this.btn_dangkidv.Text = "Đăng Kí Dịch Vụ";
            this.btn_dangkidv.UseVisualStyleBackColor = true;
            // 
            // comboBox_dv
            // 
            this.comboBox_dv.FormattingEnabled = true;
            this.comboBox_dv.Location = new System.Drawing.Point(157, 133);
            this.comboBox_dv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_dv.Name = "comboBox_dv";
            this.comboBox_dv.Size = new System.Drawing.Size(151, 21);
            this.comboBox_dv.TabIndex = 21;
            this.comboBox_dv.SelectedIndexChanged += new System.EventHandler(this.comboBox_dv_SelectedIndexChanged);
            this.comboBox_dv.SelectionChangeCommitted += new System.EventHandler(this.comboBox_dv_SelectionChangeCommitted);
            // 
            // comboBox_loaidv
            // 
            this.comboBox_loaidv.FormattingEnabled = true;
            this.comboBox_loaidv.Location = new System.Drawing.Point(157, 87);
            this.comboBox_loaidv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_loaidv.Name = "comboBox_loaidv";
            this.comboBox_loaidv.Size = new System.Drawing.Size(151, 21);
            this.comboBox_loaidv.TabIndex = 22;
            this.comboBox_loaidv.SelectedIndexChanged += new System.EventHandler(this.comboBox_loaidv_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Chọn Dịch vụ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Giá Dịch Vụ";
            // 
            // textBox_giadv
            // 
            this.textBox_giadv.Location = new System.Drawing.Point(157, 226);
            this.textBox_giadv.Name = "textBox_giadv";
            this.textBox_giadv.Size = new System.Drawing.Size(151, 20);
            this.textBox_giadv.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(16, 318);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(3);
            this.btn_add.Size = new System.Drawing.Size(97, 37);
            this.btn_add.TabIndex = 23;
            this.btn_add.Text = "   Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Image = global::QuanLyHotel.Properties.Resources.edit;
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.Location = new System.Drawing.Point(157, 318);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Padding = new System.Windows.Forms.Padding(3);
            this.btn_modify.Size = new System.Drawing.Size(97, 37);
            this.btn_modify.TabIndex = 24;
            this.btn_modify.Text = "   Sửa";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::QuanLyHotel.Properties.Resources.trash;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(293, 318);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(3);
            this.btn_delete.Size = new System.Drawing.Size(103, 37);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "   Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(25, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 26;
            this.button1.Text = "   Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::QuanLyHotel.Properties.Resources.edit;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(144, 327);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3);
            this.button2.Size = new System.Drawing.Size(97, 37);
            this.button2.TabIndex = 27;
            this.button2.Text = "   Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::QuanLyHotel.Properties.Resources.trash;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(280, 327);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(3);
            this.button3.Size = new System.Drawing.Size(103, 37);
            this.button3.TabIndex = 28;
            this.button3.Text = "   Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormQuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 735);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormQuanLyDichVu";
            this.Text = "FormQuanLyDichVu";
            this.Load += new System.EventHandler(this.FormQuanLyDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_tenldv;
        private System.Windows.Forms.ComboBox comboBox_maldv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_tendv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_dangkidv;
        private System.Windows.Forms.ComboBox comboBox_dv;
        private System.Windows.Forms.ComboBox comboBox_loaidv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_giadv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_delete;
    }
}