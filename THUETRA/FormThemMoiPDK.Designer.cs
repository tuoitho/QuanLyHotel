namespace QuanLyHotel.THUETRA
{
    partial class FormThemMoiPDK
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_mapdk = new System.Windows.Forms.TextBox();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblExpectedArrival = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dtpExpectedArrival = new System.Windows.Forms.DateTimePicker();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.lblExpectedDeparture = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.dtpExpectedDeparture = new System.Windows.Forms.DateTimePicker();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tb_mapdk);
            this.panel2.Controls.Add(this.cboRoom);
            this.panel2.Controls.Add(this.lblRoom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.cboCustomer);
            this.panel2.Controls.Add(this.lblExpectedArrival);
            this.panel2.Controls.Add(this.lblCustomer);
            this.panel2.Controls.Add(this.dtpExpectedArrival);
            this.panel2.Controls.Add(this.cboEmployee);
            this.panel2.Controls.Add(this.lblExpectedDeparture);
            this.panel2.Controls.Add(this.lblEmployee);
            this.panel2.Controls.Add(this.dtpExpectedDeparture);
            this.panel2.Controls.Add(this.txtDepositAmount);
            this.panel2.Controls.Add(this.lblDepositAmount);
            this.panel2.Location = new System.Drawing.Point(216, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 541);
            this.panel2.TabIndex = 18;
            // 
            // tb_mapdk
            // 
            this.tb_mapdk.Enabled = false;
            this.tb_mapdk.Location = new System.Drawing.Point(176, 75);
            this.tb_mapdk.Name = "tb_mapdk";
            this.tb_mapdk.Size = new System.Drawing.Size(220, 24);
            this.tb_mapdk.TabIndex = 5;
            // 
            // cboRoom
            // 
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(176, 365);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(176, 24);
            this.cboRoom.TabIndex = 11;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(32, 365);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(48, 17);
            this.lblRoom.TabIndex = 10;
            this.lblRoom.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã PĐK";
            // 
            // button_add
            // 
            this.button_add.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_add.Location = new System.Drawing.Point(123, 445);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_add.Name = "button_add";
            this.button_add.Padding = new System.Windows.Forms.Padding(4);
            this.button_add.Size = new System.Drawing.Size(175, 46);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "   Thêm";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(176, 315);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(176, 24);
            this.cboCustomer.TabIndex = 9;
            // 
            // lblExpectedArrival
            // 
            this.lblExpectedArrival.AutoSize = true;
            this.lblExpectedArrival.Location = new System.Drawing.Point(32, 115);
            this.lblExpectedArrival.Name = "lblExpectedArrival";
            this.lblExpectedArrival.Size = new System.Drawing.Size(85, 17);
            this.lblExpectedArrival.TabIndex = 0;
            this.lblExpectedArrival.Text = "Dự Kiến Đến";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(32, 315);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(82, 17);
            this.lblCustomer.TabIndex = 8;
            this.lblCustomer.Text = "Khách Hàng";
            // 
            // dtpExpectedArrival
            // 
            this.dtpExpectedArrival.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpExpectedArrival.Location = new System.Drawing.Point(176, 115);
            this.dtpExpectedArrival.Name = "dtpExpectedArrival";
            this.dtpExpectedArrival.Size = new System.Drawing.Size(220, 24);
            this.dtpExpectedArrival.TabIndex = 1;
            // 
            // cboEmployee
            // 
            this.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(176, 265);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(176, 24);
            this.cboEmployee.TabIndex = 7;
            // 
            // lblExpectedDeparture
            // 
            this.lblExpectedDeparture.AutoSize = true;
            this.lblExpectedDeparture.Location = new System.Drawing.Point(32, 165);
            this.lblExpectedDeparture.Name = "lblExpectedDeparture";
            this.lblExpectedDeparture.Size = new System.Drawing.Size(72, 17);
            this.lblExpectedDeparture.TabIndex = 2;
            this.lblExpectedDeparture.Text = "Dự Kiến Đi";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(32, 265);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(69, 17);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Nhân Viên";
            // 
            // dtpExpectedDeparture
            // 
            this.dtpExpectedDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpExpectedDeparture.Location = new System.Drawing.Point(176, 165);
            this.dtpExpectedDeparture.Name = "dtpExpectedDeparture";
            this.dtpExpectedDeparture.Size = new System.Drawing.Size(220, 24);
            this.dtpExpectedDeparture.TabIndex = 3;
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(176, 215);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(220, 24);
            this.txtDepositAmount.TabIndex = 5;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Location = new System.Drawing.Point(32, 215);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(87, 17);
            this.lblDepositAmount.TabIndex = 4;
            this.lblDepositAmount.Text = "Tiền Đặt Cọc";
            // 
            // FormThemMoiPDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(842, 686);
            this.Controls.Add(this.panel2);
            this.Name = "FormThemMoiPDK";
            this.Text = "FormThemMoiPDK";
            this.Load += new System.EventHandler(this.FormThemMoiPDK_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_mapdk;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label lblExpectedArrival;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DateTimePicker dtpExpectedArrival;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.Label lblExpectedDeparture;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.DateTimePicker dtpExpectedDeparture;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Label lblDepositAmount;
    }
}