namespace QuanLyHotel.EMPLOYEE
{
    partial class FormThemCaBoSung
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
            this.dateTimePicker_ngay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_s = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_e = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_loainv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker_ngay
            // 
            this.dateTimePicker_ngay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_ngay.Font = new System.Drawing.Font("Tahoma", 14F);
            this.dateTimePicker_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngay.Location = new System.Drawing.Point(436, 42);
            this.dateTimePicker_ngay.Name = "dateTimePicker_ngay";
            this.dateTimePicker_ngay.Size = new System.Drawing.Size(141, 30);
            this.dateTimePicker_ngay.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(241, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Chọn ngày:";
            // 
            // dateTimePicker_s
            // 
            this.dateTimePicker_s.CustomFormat = "HH:mm";
            this.dateTimePicker_s.Font = new System.Drawing.Font("Tahoma", 14F);
            this.dateTimePicker_s.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_s.Location = new System.Drawing.Point(436, 142);
            this.dateTimePicker_s.Name = "dateTimePicker_s";
            this.dateTimePicker_s.Size = new System.Drawing.Size(141, 30);
            this.dateTimePicker_s.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(182, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Chọn giờ  bắt đầu:";
            // 
            // dateTimePicker_e
            // 
            this.dateTimePicker_e.CustomFormat = "HH:mm";
            this.dateTimePicker_e.Font = new System.Drawing.Font("Tahoma", 14F);
            this.dateTimePicker_e.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_e.Location = new System.Drawing.Point(436, 215);
            this.dateTimePicker_e.Name = "dateTimePicker_e";
            this.dateTimePicker_e.Size = new System.Drawing.Size(141, 30);
            this.dateTimePicker_e.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(182, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Chọn giờ kết thúc:";
            // 
            // comboBox_loainv
            // 
            this.comboBox_loainv.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBox_loainv.FormattingEnabled = true;
            this.comboBox_loainv.Location = new System.Drawing.Point(436, 290);
            this.comboBox_loainv.Name = "comboBox_loainv";
            this.comboBox_loainv.Size = new System.Drawing.Size(141, 27);
            this.comboBox_loainv.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(183, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Chọn loại nhân viên:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(316, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 98);
            this.button2.TabIndex = 33;
            this.button2.Text = "Thêm ca bổ sung";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormThemCaBoSung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(898, 564);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_loainv);
            this.Controls.Add(this.dateTimePicker_e);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_s);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_ngay);
            this.Controls.Add(this.label1);
            this.Name = "FormThemCaBoSung";
            this.Text = "FormThemCaBoSung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_ngay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_s;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_e;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_loainv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}