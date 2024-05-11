namespace QuanLyHotel.Riengbiet
{
    partial class FormBaoCaoDoanhthu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_xembd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 421);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_xembd
            // 
            this.button_xembd.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_xembd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xembd.Location = new System.Drawing.Point(323, 471);
            this.button_xembd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_xembd.Name = "button_xembd";
            this.button_xembd.Padding = new System.Windows.Forms.Padding(3);
            this.button_xembd.Size = new System.Drawing.Size(221, 43);
            this.button_xembd.TabIndex = 17;
            this.button_xembd.Text = "Hiện Biểu Đồ";
            this.button_xembd.UseVisualStyleBackColor = true;
            this.button_xembd.Click += new System.EventHandler(this.button_xembd_Click);
            // 
            // FormBaoCaoDoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 525);
            this.Controls.Add(this.button_xembd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormBaoCaoDoanhthu";
            this.Text = "FormBaoCaoDoanhthu";
            this.Load += new System.EventHandler(this.FormBaoCaoDoanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_xembd;
    }
}