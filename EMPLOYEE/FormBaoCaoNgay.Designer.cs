namespace QuanLyHotel.EMPLOYEE
{
    partial class FormBaoCaoNgay
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
            this.dataGridView_baocao = new System.Windows.Forms.DataGridView();
            this.dataGridView_chitietca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_baocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chitietca)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_baocao
            // 
            this.dataGridView_baocao.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_baocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_baocao.Location = new System.Drawing.Point(67, 71);
            this.dataGridView_baocao.Name = "dataGridView_baocao";
            this.dataGridView_baocao.Size = new System.Drawing.Size(486, 445);
            this.dataGridView_baocao.TabIndex = 0;
            this.dataGridView_baocao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_baocao_CellClick);
            // 
            // dataGridView_chitietca
            // 
            this.dataGridView_chitietca.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_chitietca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_chitietca.Location = new System.Drawing.Point(655, 71);
            this.dataGridView_chitietca.Name = "dataGridView_chitietca";
            this.dataGridView_chitietca.Size = new System.Drawing.Size(334, 445);
            this.dataGridView_chitietca.TabIndex = 0;
            // 
            // FormBaoCaoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 585);
            this.Controls.Add(this.dataGridView_chitietca);
            this.Controls.Add(this.dataGridView_baocao);
            this.Name = "FormBaoCaoNgay";
            this.Text = "FormBaoCaoNgay";
            this.Load += new System.EventHandler(this.FormBaoCaoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_baocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chitietca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_baocao;
        private System.Windows.Forms.DataGridView dataGridView_chitietca;
    }
}