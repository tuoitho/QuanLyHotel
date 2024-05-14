namespace QuanLyHotel.EMPLOYEE
{
    partial class FormBaoNghi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_cacuatoi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedButton_baonghi = new QuanLyHotel.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cacuatoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_cacuatoi
            // 
            this.dataGridView_cacuatoi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView_cacuatoi.AllowUserToAddRows = false;
            this.dataGridView_cacuatoi.AllowUserToDeleteRows = false;
            this.dataGridView_cacuatoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_cacuatoi.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_cacuatoi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_cacuatoi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_cacuatoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_cacuatoi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_cacuatoi.Location = new System.Drawing.Point(35, 112);
            this.dataGridView_cacuatoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_cacuatoi.MultiSelect = false;
            this.dataGridView_cacuatoi.Name = "dataGridView_cacuatoi";
            this.dataGridView_cacuatoi.ReadOnly = true;
            this.dataGridView_cacuatoi.RowHeadersVisible = false;
            this.dataGridView_cacuatoi.RowHeadersWidth = 51;
            this.dataGridView_cacuatoi.RowTemplate.Height = 26;
            this.dataGridView_cacuatoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cacuatoi.Size = new System.Drawing.Size(997, 322);
            this.dataGridView_cacuatoi.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 17F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(313, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "DANH SÁCH CA CỦA TÔI TRONG NGÀY";
            // 
            // roundedButton_baonghi
            // 
            this.roundedButton_baonghi.BackColor = System.Drawing.Color.RosyBrown;
            this.roundedButton_baonghi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.roundedButton_baonghi.Location = new System.Drawing.Point(462, 457);
            this.roundedButton_baonghi.Name = "roundedButton_baonghi";
            this.roundedButton_baonghi.Size = new System.Drawing.Size(140, 44);
            this.roundedButton_baonghi.TabIndex = 26;
            this.roundedButton_baonghi.Text = "Báo nghỉ";
            this.roundedButton_baonghi.UseVisualStyleBackColor = false;
            this.roundedButton_baonghi.Click += new System.EventHandler(this.roundedButton_baonghi_Click);
            // 
            // FormBaoNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1133, 545);
            this.Controls.Add(this.roundedButton_baonghi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_cacuatoi);
            this.Name = "FormBaoNghi";
            this.Text = "FormBaoNghi";
            this.Load += new System.EventHandler(this.FormBaoNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cacuatoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_cacuatoi;
        private System.Windows.Forms.Label label3;
        private RoundedButton roundedButton_baonghi;
    }
}