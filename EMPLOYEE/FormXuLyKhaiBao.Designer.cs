namespace QuanLyHotel.EMPLOYEE
{
    partial class FormXuLyKhaiBao
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
            this.dataGridView_hoadon = new System.Windows.Forms.DataGridView();
            this.dataGridView_kb = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kb)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_hoadon
            // 
            this.dataGridView_hoadon.AllowUserToAddRows = false;
            this.dataGridView_hoadon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hoadon.Location = new System.Drawing.Point(34, 93);
            this.dataGridView_hoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_hoadon.Name = "dataGridView_hoadon";
            this.dataGridView_hoadon.RowHeadersWidth = 51;
            this.dataGridView_hoadon.RowTemplate.Height = 26;
            this.dataGridView_hoadon.Size = new System.Drawing.Size(559, 413);
            this.dataGridView_hoadon.TabIndex = 3;
            this.dataGridView_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hoadon_CellClick);
            // 
            // dataGridView_kb
            // 
            this.dataGridView_kb.AllowUserToAddRows = false;
            this.dataGridView_kb.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_kb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kb.Location = new System.Drawing.Point(630, 93);
            this.dataGridView_kb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_kb.Name = "dataGridView_kb";
            this.dataGridView_kb.RowHeadersWidth = 51;
            this.dataGridView_kb.RowTemplate.Height = 26;
            this.dataGridView_kb.Size = new System.Drawing.Size(447, 413);
            this.dataGridView_kb.TabIndex = 4;
            // 
            // FormXuLyKhaiBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 642);
            this.Controls.Add(this.dataGridView_kb);
            this.Controls.Add(this.dataGridView_hoadon);
            this.Name = "FormXuLyKhaiBao";
            this.Text = "FormXuLyKhaiBao";
            this.Load += new System.EventHandler(this.FormXuLyKhaiBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_hoadon;
        private System.Windows.Forms.DataGridView dataGridView_kb;
    }
}