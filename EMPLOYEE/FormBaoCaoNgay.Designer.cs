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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_baocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chitietca)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_baocao
            // 
            this.dataGridView_baocao.AllowUserToAddRows = false;
            this.dataGridView_baocao.AllowUserToDeleteRows = false;
            this.dataGridView_baocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_baocao.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_baocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_baocao.Location = new System.Drawing.Point(48, 57);
            this.dataGridView_baocao.Name = "dataGridView_baocao";
            this.dataGridView_baocao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_baocao.Size = new System.Drawing.Size(541, 445);
            this.dataGridView_baocao.TabIndex = 0;
            this.dataGridView_baocao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_baocao_CellClick);
            this.dataGridView_baocao.Click += new System.EventHandler(this.dataGridView_baocao_Click);
            // 
            // dataGridView_chitietca
            // 
            this.dataGridView_chitietca.AllowUserToAddRows = false;
            this.dataGridView_chitietca.AllowUserToDeleteRows = false;
            this.dataGridView_chitietca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_chitietca.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_chitietca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_chitietca.Location = new System.Drawing.Point(641, 57);
            this.dataGridView_chitietca.Name = "dataGridView_chitietca";
            this.dataGridView_chitietca.Size = new System.Drawing.Size(439, 445);
            this.dataGridView_chitietca.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.button1.Location = new System.Drawing.Point(466, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 51);
            this.button1.TabIndex = 20;
            this.button1.Text = "In bảng lương";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBaoCaoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 585);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}