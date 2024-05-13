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
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblExpectedArrival = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dtpExpectedArrival = new System.Windows.Forms.DateTimePicker();
            this.lblExpectedDeparture = new System.Windows.Forms.Label();
            this.dtpExpectedDeparture = new System.Windows.Forms.DateTimePicker();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.roundedButton_selectroom = new QuanLyHotel.RoundedButton();
            this.roundedButton_selet = new QuanLyHotel.RoundedButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.roundedButton_selectroom);
            this.panel2.Controls.Add(this.roundedButton_selet);
            this.panel2.Controls.Add(this.tb_mapdk);
            this.panel2.Controls.Add(this.cboRoom);
            this.panel2.Controls.Add(this.lblRoom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.cboCustomer);
            this.panel2.Controls.Add(this.lblExpectedArrival);
            this.panel2.Controls.Add(this.lblCustomer);
            this.panel2.Controls.Add(this.dtpExpectedArrival);
            this.panel2.Controls.Add(this.lblExpectedDeparture);
            this.panel2.Controls.Add(this.dtpExpectedDeparture);
            this.panel2.Controls.Add(this.txtDepositAmount);
            this.panel2.Controls.Add(this.lblDepositAmount);
            this.panel2.Location = new System.Drawing.Point(185, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 454);
            this.panel2.TabIndex = 18;
            // 
            // tb_mapdk
            // 
            this.tb_mapdk.Enabled = false;
            this.tb_mapdk.Location = new System.Drawing.Point(151, 61);
            this.tb_mapdk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_mapdk.Name = "tb_mapdk";
            this.tb_mapdk.Size = new System.Drawing.Size(189, 20);
            this.tb_mapdk.TabIndex = 5;
            // 
            // cboRoom
            // 
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.Enabled = false;
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(151, 266);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(56, 21);
            this.cboRoom.TabIndex = 11;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(27, 266);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(37, 13);
            this.lblRoom.TabIndex = 10;
            this.lblRoom.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã PĐK";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.Enabled = false;
            this.cboCustomer.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(151, 225);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(56, 24);
            this.cboCustomer.TabIndex = 9;
            // 
            // lblExpectedArrival
            // 
            this.lblExpectedArrival.AutoSize = true;
            this.lblExpectedArrival.Location = new System.Drawing.Point(27, 93);
            this.lblExpectedArrival.Name = "lblExpectedArrival";
            this.lblExpectedArrival.Size = new System.Drawing.Size(67, 13);
            this.lblExpectedArrival.TabIndex = 0;
            this.lblExpectedArrival.Text = "Dự Kiến Đến";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(27, 225);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(64, 13);
            this.lblCustomer.TabIndex = 8;
            this.lblCustomer.Text = "Khách Hàng";
            // 
            // dtpExpectedArrival
            // 
            this.dtpExpectedArrival.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dtpExpectedArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpectedArrival.Location = new System.Drawing.Point(151, 93);
            this.dtpExpectedArrival.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpExpectedArrival.Name = "dtpExpectedArrival";
            this.dtpExpectedArrival.Size = new System.Drawing.Size(189, 20);
            this.dtpExpectedArrival.TabIndex = 1;
            // 
            // lblExpectedDeparture
            // 
            this.lblExpectedDeparture.AutoSize = true;
            this.lblExpectedDeparture.Location = new System.Drawing.Point(27, 134);
            this.lblExpectedDeparture.Name = "lblExpectedDeparture";
            this.lblExpectedDeparture.Size = new System.Drawing.Size(57, 13);
            this.lblExpectedDeparture.TabIndex = 2;
            this.lblExpectedDeparture.Text = "Dự Kiến Đi";
            // 
            // dtpExpectedDeparture
            // 
            this.dtpExpectedDeparture.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dtpExpectedDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpectedDeparture.Location = new System.Drawing.Point(151, 134);
            this.dtpExpectedDeparture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpExpectedDeparture.Name = "dtpExpectedDeparture";
            this.dtpExpectedDeparture.Size = new System.Drawing.Size(189, 20);
            this.dtpExpectedDeparture.TabIndex = 3;
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(151, 175);
            this.txtDepositAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(189, 20);
            this.txtDepositAmount.TabIndex = 5;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Location = new System.Drawing.Point(27, 175);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(69, 13);
            this.lblDepositAmount.TabIndex = 4;
            this.lblDepositAmount.Text = "Tiền Đặt Cọc";
            // 
            // button_add
            // 
            this.button_add.Image = global::QuanLyHotel.Properties.Resources.plus;
            this.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_add.Location = new System.Drawing.Point(105, 331);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Padding = new System.Windows.Forms.Padding(3);
            this.button_add.Size = new System.Drawing.Size(150, 37);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "   Thêm";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // roundedButton_selectroom
            // 
            this.roundedButton_selectroom.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.roundedButton_selectroom.Font = new System.Drawing.Font("Tahoma", 12F);
            this.roundedButton_selectroom.Location = new System.Drawing.Point(213, 259);
            this.roundedButton_selectroom.Name = "roundedButton_selectroom";
            this.roundedButton_selectroom.Size = new System.Drawing.Size(127, 28);
            this.roundedButton_selectroom.TabIndex = 12;
            this.roundedButton_selectroom.Text = "Select Room...";
            this.roundedButton_selectroom.UseVisualStyleBackColor = false;
            this.roundedButton_selectroom.Click += new System.EventHandler(this.roundedButton_selectroom_Click);
            // 
            // roundedButton_selet
            // 
            this.roundedButton_selet.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.roundedButton_selet.Font = new System.Drawing.Font("Tahoma", 12F);
            this.roundedButton_selet.Location = new System.Drawing.Point(213, 218);
            this.roundedButton_selet.Name = "roundedButton_selet";
            this.roundedButton_selet.Size = new System.Drawing.Size(127, 28);
            this.roundedButton_selet.TabIndex = 12;
            this.roundedButton_selet.Text = "Select KH...";
            this.roundedButton_selet.UseVisualStyleBackColor = false;
            this.roundedButton_selet.Click += new System.EventHandler(this.roundedButton_selet_Click);
            // 
            // FormThemMoiPDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(722, 557);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblExpectedDeparture;
        private System.Windows.Forms.DateTimePicker dtpExpectedDeparture;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Label lblDepositAmount;
        private RoundedButton roundedButton_selet;
        private RoundedButton roundedButton_selectroom;
    }
}