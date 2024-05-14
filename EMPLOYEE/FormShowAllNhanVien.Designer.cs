namespace QuanLyHotel.EMPLOYEE
{
    partial class FormShowAllNhanVien
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
            this.dataGridView_employee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_employee
            // 
            this.dataGridView_employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_employee.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_employee.Name = "dataGridView_employee";
            this.dataGridView_employee.RowHeadersWidth = 51;
            this.dataGridView_employee.RowTemplate.Height = 26;
            this.dataGridView_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_employee.Size = new System.Drawing.Size(1128, 499);
            this.dataGridView_employee.TabIndex = 7;
            // 
            // FormShowAllNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 499);
            this.Controls.Add(this.dataGridView_employee);
            this.Name = "FormShowAllNhanVien";
            this.Text = "FormShowAllNhanVien";
            this.Load += new System.EventHandler(this.FormShowAllNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_employee;
    }
}