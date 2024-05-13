namespace QuanLyHotel.EMPLOYEE
{
    partial class FormSelectPhong
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
            this.dataGridView_phong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_phong
            // 
            this.dataGridView_phong.AllowUserToAddRows = false;
            this.dataGridView_phong.AllowUserToDeleteRows = false;
            this.dataGridView_phong.AllowUserToResizeColumns = false;
            this.dataGridView_phong.AllowUserToResizeRows = false;
            this.dataGridView_phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_phong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_phong.Location = new System.Drawing.Point(69, 54);
            this.dataGridView_phong.Name = "dataGridView_phong";
            this.dataGridView_phong.ReadOnly = true;
            this.dataGridView_phong.RowHeadersVisible = false;
            this.dataGridView_phong.RowHeadersWidth = 51;
            this.dataGridView_phong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_phong.Size = new System.Drawing.Size(739, 407);
            this.dataGridView_phong.TabIndex = 1;
            // 
            // FormSelectPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 518);
            this.Controls.Add(this.dataGridView_phong);
            this.Name = "FormSelectPhong";
            this.Text = "FormSelectPhong";
            this.Load += new System.EventHandler(this.FormSelectPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView_phong;
    }
}