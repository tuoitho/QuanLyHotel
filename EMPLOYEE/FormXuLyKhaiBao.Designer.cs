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
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kb)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_hoadon
            // 
            this.dataGridView_hoadon.AllowUserToAddRows = false;
            this.dataGridView_hoadon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hoadon.Location = new System.Drawing.Point(44, 70);
            this.dataGridView_hoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_hoadon.Name = "dataGridView_hoadon";
            this.dataGridView_hoadon.RowHeadersWidth = 51;
            this.dataGridView_hoadon.RowTemplate.Height = 26;
            this.dataGridView_hoadon.Size = new System.Drawing.Size(559, 413);
            this.dataGridView_hoadon.TabIndex = 3;
            this.dataGridView_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hoadon_CellClick);
            this.dataGridView_hoadon.Click += new System.EventHandler(this.dataGridView_hoadon_CellClick);
            // 
            // dataGridView_kb
            // 
            this.dataGridView_kb.AllowUserToAddRows = false;
            this.dataGridView_kb.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_kb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kb.Location = new System.Drawing.Point(630, 70);
            this.dataGridView_kb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_kb.Name = "dataGridView_kb";
            this.dataGridView_kb.RowHeadersWidth = 51;
            this.dataGridView_kb.RowTemplate.Height = 26;
            this.dataGridView_kb.Size = new System.Drawing.Size(447, 413);
            this.dataGridView_kb.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(748, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 70);
            this.button2.TabIndex = 34;
            this.button2.Text = "Phạt Tiền Nhân Viên";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormXuLyKhaiBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 565);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
    }
}