namespace QuanLyHotel.EMPLOYEE
{
    partial class FormKhaiBaoThucPham
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
            this.dataGridView_phongdenhan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phongdenhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.dataGridView_phongdenhan);
            this.panel1.Location = new System.Drawing.Point(21, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 447);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView_phongdenhan
            // 
            this.dataGridView_phongdenhan.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView_phongdenhan.AllowUserToAddRows = false;
            this.dataGridView_phongdenhan.AllowUserToDeleteRows = false;
            this.dataGridView_phongdenhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_phongdenhan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_phongdenhan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_phongdenhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_phongdenhan.Location = new System.Drawing.Point(3, 0);
            this.dataGridView_phongdenhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_phongdenhan.MultiSelect = false;
            this.dataGridView_phongdenhan.Name = "dataGridView_phongdenhan";
            this.dataGridView_phongdenhan.ReadOnly = true;
            this.dataGridView_phongdenhan.RowHeadersVisible = false;
            this.dataGridView_phongdenhan.RowHeadersWidth = 51;
            this.dataGridView_phongdenhan.RowTemplate.Height = 26;
            this.dataGridView_phongdenhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_phongdenhan.Size = new System.Drawing.Size(953, 448);
            this.dataGridView_phongdenhan.TabIndex = 13;
            this.dataGridView_phongdenhan.DoubleClick += new System.EventHandler(this.dataGridView_phongdenhan_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh sách cần khai báo (click  đúp để khai báo thực phẩm)";
            // 
            // FormKhaiBaoThucPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormKhaiBaoThucPham";
            this.Text = "FormKhaiBaoThucPham";
            this.Load += new System.EventHandler(this.FormKhaiBaoThucPham_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phongdenhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_phongdenhan;
        private System.Windows.Forms.Label label1;
    }
}