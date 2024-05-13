namespace QuanLyHotel
{
    partial class FormTrangChu
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
            this.textBox_solan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_solan
            // 
            this.textBox_solan.AutoSize = true;
            this.textBox_solan.Font = new System.Drawing.Font("Tahoma", 43F);
            this.textBox_solan.ForeColor = System.Drawing.Color.White;
            this.textBox_solan.Location = new System.Drawing.Point(135, 65);
            this.textBox_solan.Name = "textBox_solan";
            this.textBox_solan.Size = new System.Drawing.Size(500, 70);
            this.textBox_solan.TabIndex = 15;
            this.textBox_solan.Text = "Chức năng nhanh:";
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_solan);
            this.Name = "FormTrangChu";
            this.Text = "FormTrangChu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textBox_solan;
    }
}