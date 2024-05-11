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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(123, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(985, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // roundedButton_tuchoi
            // 
            this.roundedButton_tuchoi.Location = new System.Drawing.Point(515, 549);
            this.roundedButton_tuchoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedButton_tuchoi.Name = "roundedButton_tuchoi";
            this.roundedButton_tuchoi.Size = new System.Drawing.Size(205, 66);
            this.roundedButton_tuchoi.TabIndex = 1;
            this.roundedButton_tuchoi.Text = "Từ chối";
            this.roundedButton_tuchoi.UseVisualStyleBackColor = true;
            this.roundedButton_tuchoi.Click += new System.EventHandler(this.roundedButton_tuchoi_Click);
            // 
            // roundedButton_duyet
            // 
            this.roundedButton_duyet.Location = new System.Drawing.Point(261, 549);
            this.roundedButton_duyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedButton_duyet.Name = "roundedButton_duyet";
            this.roundedButton_duyet.Size = new System.Drawing.Size(205, 66);
            this.roundedButton_duyet.TabIndex = 1;
            this.roundedButton_duyet.Text = "Duyệt";
            this.roundedButton_duyet.UseVisualStyleBackColor = true;
            this.roundedButton_duyet.Click += new System.EventHandler(this.roundedButton_duyet_Click);
            // 
            // roundedButton_xoa
            // 
            this.roundedButton_xoa.Location = new System.Drawing.Point(764, 549);
            this.roundedButton_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedButton_xoa.Name = "roundedButton_xoa";
            this.roundedButton_xoa.Size = new System.Drawing.Size(205, 66);
            this.roundedButton_xoa.TabIndex = 1;
            this.roundedButton_xoa.Text = "Xoá";
            this.roundedButton_xoa.UseVisualStyleBackColor = true;
            this.roundedButton_xoa.Click += new System.EventHandler(this.roundedButton_xoa_Click);
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 652);
            this.Controls.Add(this.roundedButton_xoa);
            this.Controls.Add(this.roundedButton_tuchoi);
            this.Controls.Add(this.roundedButton_duyet);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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