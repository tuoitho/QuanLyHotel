namespace QuanLyHotel.ACCOUNT
{
    partial class FormAccount
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roundedButton_tuchoi = new QuanLyHotel.RoundedButton();
            this.roundedButton_duyet = new QuanLyHotel.RoundedButton();
            this.roundedButton_xoa = new QuanLyHotel.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(143, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 536);
            this.dataGridView1.TabIndex = 0;
            // 
            // roundedButton_tuchoi
            // 
            this.roundedButton_tuchoi.Location = new System.Drawing.Point(601, 676);
            this.roundedButton_tuchoi.Name = "roundedButton_tuchoi";
            this.roundedButton_tuchoi.Size = new System.Drawing.Size(239, 81);
            this.roundedButton_tuchoi.TabIndex = 1;
            this.roundedButton_tuchoi.Text = "Từ chối";
            this.roundedButton_tuchoi.UseVisualStyleBackColor = true;
            this.roundedButton_tuchoi.Click += new System.EventHandler(this.roundedButton_tuchoi_Click);
            // 
            // roundedButton_duyet
            // 
            this.roundedButton_duyet.Location = new System.Drawing.Point(304, 676);
            this.roundedButton_duyet.Name = "roundedButton_duyet";
            this.roundedButton_duyet.Size = new System.Drawing.Size(239, 81);
            this.roundedButton_duyet.TabIndex = 1;
            this.roundedButton_duyet.Text = "Duyệt";
            this.roundedButton_duyet.UseVisualStyleBackColor = true;
            this.roundedButton_duyet.Click += new System.EventHandler(this.roundedButton_duyet_Click);
            // 
            // roundedButton_xoa
            // 
            this.roundedButton_xoa.Location = new System.Drawing.Point(891, 676);
            this.roundedButton_xoa.Name = "roundedButton_xoa";
            this.roundedButton_xoa.Size = new System.Drawing.Size(239, 81);
            this.roundedButton_xoa.TabIndex = 1;
            this.roundedButton_xoa.Text = "Xoá";
            this.roundedButton_xoa.UseVisualStyleBackColor = true;
            this.roundedButton_xoa.Click += new System.EventHandler(this.roundedButton_xoa_Click);
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 802);
            this.Controls.Add(this.roundedButton_xoa);
            this.Controls.Add(this.roundedButton_tuchoi);
            this.Controls.Add(this.roundedButton_duyet);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAccount";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RoundedButton roundedButton_duyet;
        private RoundedButton roundedButton_tuchoi;
        private RoundedButton roundedButton_xoa;
    }
}