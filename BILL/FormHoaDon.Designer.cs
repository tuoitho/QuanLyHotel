namespace QuanLyHotel.BILL
{
    partial class FormHoaDon
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
            this.tabControl_hoadon = new System.Windows.Forms.TabControl();
            this.tabPage_qlhoadon = new System.Windows.Forms.TabPage();
            this.tabPage_thanhtoan = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl_hoadon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_hoadon
            // 
            this.tabControl_hoadon.Controls.Add(this.tabPage_qlhoadon);
            this.tabControl_hoadon.Controls.Add(this.tabPage_thanhtoan);
            this.tabControl_hoadon.Controls.Add(this.tabPage1);
            this.tabControl_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_hoadon.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_hoadon.Location = new System.Drawing.Point(0, 0);
            this.tabControl_hoadon.Name = "tabControl_hoadon";
            this.tabControl_hoadon.SelectedIndex = 0;
            this.tabControl_hoadon.Size = new System.Drawing.Size(800, 450);
            this.tabControl_hoadon.TabIndex = 0;
            // 
            // tabPage_qlhoadon
            // 
            this.tabPage_qlhoadon.Location = new System.Drawing.Point(4, 25);
            this.tabPage_qlhoadon.Name = "tabPage_qlhoadon";
            this.tabPage_qlhoadon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_qlhoadon.Size = new System.Drawing.Size(792, 421);
            this.tabPage_qlhoadon.TabIndex = 0;
            this.tabPage_qlhoadon.Text = "Quản lí hoá đơn";
            this.tabPage_qlhoadon.UseVisualStyleBackColor = true;
            // 
            // tabPage_thanhtoan
            // 
            this.tabPage_thanhtoan.Location = new System.Drawing.Point(4, 31);
            this.tabPage_thanhtoan.Name = "tabPage_thanhtoan";
            this.tabPage_thanhtoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_thanhtoan.Size = new System.Drawing.Size(792, 415);
            this.tabPage_thanhtoan.TabIndex = 1;
            this.tabPage_thanhtoan.Text = "Thanh toán";
            this.tabPage_thanhtoan.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 415);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Thống kê";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_hoadon);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.tabControl_hoadon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_hoadon;
        private System.Windows.Forms.TabPage tabPage_qlhoadon;
        private System.Windows.Forms.TabPage tabPage_thanhtoan;
        private System.Windows.Forms.TabPage tabPage1;
    }
}