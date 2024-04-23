namespace QuanLyHotel.PHONG
{
    partial class FormChiTietPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button_choose = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 559);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(167, 31);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(487, 345);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // btn_modify
            // 
            this.btn_modify.Image = global::QuanLyHotel.Properties.Resources.edit;
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.Location = new System.Drawing.Point(309, 606);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Padding = new System.Windows.Forms.Padding(4);
            this.btn_modify.Size = new System.Drawing.Size(152, 46);
            this.btn_modify.TabIndex = 12;
            this.btn_modify.Text = "   Thay Đổi";
            this.btn_modify.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::QuanLyHotel.Properties.Resources.trash;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(484, 606);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(4);
            this.btn_delete.Size = new System.Drawing.Size(113, 46);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "   Gỡ";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button_choose
            // 
            this.button_choose.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_choose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_choose.Location = new System.Drawing.Point(195, 487);
            this.button_choose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_choose.Name = "button_choose";
            this.button_choose.Padding = new System.Windows.Forms.Padding(4);
            this.button_choose.Size = new System.Drawing.Size(259, 46);
            this.button_choose.TabIndex = 11;
            this.button_choose.Text = "   Choose & Preview";
            this.button_choose.UseVisualStyleBackColor = true;
            this.button_choose.Click += new System.EventHandler(this.button_choose_Click);
            // 
            // button_upload
            // 
            this.button_upload.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_upload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_upload.Location = new System.Drawing.Point(484, 487);
            this.button_upload.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_upload.Name = "button_upload";
            this.button_upload.Padding = new System.Windows.Forms.Padding(4);
            this.button_upload.Size = new System.Drawing.Size(279, 46);
            this.button_upload.TabIndex = 11;
            this.button_upload.Text = "   Upload to server ";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // FormChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 714);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.button_choose);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChiTietPhong";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormChiTietPhong_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button_choose;
        private System.Windows.Forms.Button button_upload;
        protected internal System.Windows.Forms.Label label1;
    }
}