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
            this.btn_delete = new System.Windows.Forms.Button();
            this.button_choose = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(277, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiến trình";
            this.label1.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.axWindowsMediaPlayer1.CausesValidation = false;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 34);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Padding = new System.Windows.Forms.Padding(10);
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(835, 505);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btn_delete.Image = global::QuanLyHotel.Properties.Resources.trash;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(428, 544);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(3);
            this.btn_delete.Size = new System.Drawing.Size(154, 45);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "   Gỡ xuống";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button_choose
            // 
            this.button_choose.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.button_choose.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_choose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_choose.Location = new System.Drawing.Point(12, 545);
            this.button_choose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_choose.Name = "button_choose";
            this.button_choose.Padding = new System.Windows.Forms.Padding(3);
            this.button_choose.Size = new System.Drawing.Size(259, 44);
            this.button_choose.TabIndex = 11;
            this.button_choose.Text = "   Choose and Preview";
            this.button_choose.UseVisualStyleBackColor = true;
            this.button_choose.Click += new System.EventHandler(this.button_choose_Click);
            // 
            // button_upload
            // 
            this.button_upload.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.button_upload.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_upload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_upload.Location = new System.Drawing.Point(12, 604);
            this.button_upload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_upload.Name = "button_upload";
            this.button_upload.Padding = new System.Windows.Forms.Padding(3);
            this.button_upload.Size = new System.Drawing.Size(259, 42);
            this.button_upload.TabIndex = 11;
            this.button_upload.Text = "   Upload to server ";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(227, -5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Video giới thiệu phòng";
            // 
            // FormChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(857, 740);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.button_choose);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.Name = "FormChiTietPhong";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormChiTietPhong_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button_choose;
        private System.Windows.Forms.Button button_upload;
        protected internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}