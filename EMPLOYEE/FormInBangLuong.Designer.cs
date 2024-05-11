namespace QuanLyHotel.EMPLOYEE
{
    partial class FormInBangLuong
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
         
            this.hotelManagementDataSet1 = new QuanLyHotel.BangLuongDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyHotel.EMPLOYEE.ReportLuong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(755, 644);
            this.reportViewer1.TabIndex = 0;
            // 

            // 
            // hotelManagementDataSet1
            // 
            this.hotelManagementDataSet1.DataSetName = "HotelManagementDataSet";
            this.hotelManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormInBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 644);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInBangLuong";
            this.Text = "FormInBangLuong";
            this.Load += new System.EventHandler(this.FormInBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        private BangLuongDataSet hotelManagementDataSet1;
    }
}