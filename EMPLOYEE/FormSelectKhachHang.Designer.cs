namespace QuanLyHotel.EMPLOYEE
{
    partial class FormSelectKhachHang
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
            this.dataGridView_kh = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.dataGridView_kh);
            this.panel1.Location = new System.Drawing.Point(160, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 448);
            this.panel1.TabIndex = 19;
            // 
            // dataGridView_kh
            // 
            this.dataGridView_kh.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView_kh.AllowUserToAddRows = false;
            this.dataGridView_kh.AllowUserToDeleteRows = false;
            this.dataGridView_kh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_kh.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_kh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kh.Location = new System.Drawing.Point(3, 0);
            this.dataGridView_kh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_kh.MultiSelect = false;
            this.dataGridView_kh.Name = "dataGridView_kh";
            this.dataGridView_kh.ReadOnly = true;
            this.dataGridView_kh.RowHeadersVisible = false;
            this.dataGridView_kh.RowHeadersWidth = 51;
            this.dataGridView_kh.RowTemplate.Height = 50;
            this.dataGridView_kh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_kh.Size = new System.Drawing.Size(754, 448);
            this.dataGridView_kh.TabIndex = 13;
            // 
            // FormSelectKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 569);
            this.Controls.Add(this.panel1);
            this.Name = "FormSelectKhachHang";
            this.Text = "FormSelectKhachHang";
            this.Load += new System.EventHandler(this.FormSelectKhachHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.DataGridView dataGridView_kh;
    }
}