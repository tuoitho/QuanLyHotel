using System.Windows.Forms;

namespace QuanLyHotel.EMPLOYEE
{
    partial class FormMain
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_dangkythuetra = new QuanLyHotel.RoundedButton();
            this.button_dichvu = new QuanLyHotel.RoundedButton();
            this.button_phong = new QuanLyHotel.RoundedButton();
            this.button_bill = new QuanLyHotel.RoundedButton();
            this.btn_dangxuat = new QuanLyHotel.RoundedButton();
            this.button_account = new QuanLyHotel.RoundedButton();
            this.button_khachhang = new QuanLyHotel.RoundedButton();
            this.button_nv = new QuanLyHotel.RoundedButton();
            this.button_trangchu = new QuanLyHotel.RoundedButton();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.roundedButton1 = new QuanLyHotel.RoundedButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTiltle = new System.Windows.Forms.Label();
            this.panel_childForm = new System.Windows.Forms.Panel();
            this.roundedButton2 = new QuanLyHotel.RoundedButton();
            this.panel_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.White;
            this.panel_menu.Controls.Add(this.roundedButton2);
            this.panel_menu.Controls.Add(this.button_dangkythuetra);
            this.panel_menu.Controls.Add(this.button_dichvu);
            this.panel_menu.Controls.Add(this.button_phong);
            this.panel_menu.Controls.Add(this.button_bill);
            this.panel_menu.Controls.Add(this.btn_dangxuat);
            this.panel_menu.Controls.Add(this.button_account);
            this.panel_menu.Controls.Add(this.button_khachhang);
            this.panel_menu.Controls.Add(this.button_nv);
            this.panel_menu.Controls.Add(this.button_trangchu);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_menu.MaximumSize = new System.Drawing.Size(225, 1649);
            this.panel_menu.MinimumSize = new System.Drawing.Size(58, 649);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(225, 844);
            this.panel_menu.TabIndex = 0;
            // 
            // button_dangkythuetra
            // 
            this.button_dangkythuetra.BackColor = System.Drawing.Color.Transparent;
            this.button_dangkythuetra.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_dangkythuetra.FlatAppearance.BorderSize = 0;
            this.button_dangkythuetra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dangkythuetra.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangkythuetra.ForeColor = System.Drawing.Color.Black;
            this.button_dangkythuetra.Image = global::QuanLyHotel.Properties.Resources.service32;
            this.button_dangkythuetra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dangkythuetra.Location = new System.Drawing.Point(0, 414);
            this.button_dangkythuetra.Margin = new System.Windows.Forms.Padding(2);
            this.button_dangkythuetra.Name = "button_dangkythuetra";
            this.button_dangkythuetra.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.button_dangkythuetra.Size = new System.Drawing.Size(225, 49);
            this.button_dangkythuetra.TabIndex = 16;
            this.button_dangkythuetra.Text = "  Đăng ký, thuê, trả";
            this.button_dangkythuetra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dangkythuetra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_dangkythuetra.UseVisualStyleBackColor = false;
            this.button_dangkythuetra.Click += new System.EventHandler(this.button_dangkythuetra_Click);
            // 
            // button_dichvu
            // 
            this.button_dichvu.BackColor = System.Drawing.Color.Transparent;
            this.button_dichvu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_dichvu.FlatAppearance.BorderSize = 0;
            this.button_dichvu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dichvu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dichvu.ForeColor = System.Drawing.Color.Black;
            this.button_dichvu.Image = global::QuanLyHotel.Properties.Resources.service32;
            this.button_dichvu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dichvu.Location = new System.Drawing.Point(0, 365);
            this.button_dichvu.Margin = new System.Windows.Forms.Padding(2);
            this.button_dichvu.Name = "button_dichvu";
            this.button_dichvu.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.button_dichvu.Size = new System.Drawing.Size(225, 49);
            this.button_dichvu.TabIndex = 14;
            this.button_dichvu.Text = "  Dịch Vụ";
            this.button_dichvu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dichvu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_dichvu.UseVisualStyleBackColor = false;
            this.button_dichvu.Click += new System.EventHandler(this.button_dichvu_Click);
            // 
            // button_phong
            // 
            this.button_phong.BackColor = System.Drawing.Color.Transparent;
            this.button_phong.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_phong.FlatAppearance.BorderSize = 0;
            this.button_phong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_phong.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_phong.ForeColor = System.Drawing.Color.Black;
            this.button_phong.Image = global::QuanLyHotel.Properties.Resources.room32;
            this.button_phong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_phong.Location = new System.Drawing.Point(0, 316);
            this.button_phong.Margin = new System.Windows.Forms.Padding(2);
            this.button_phong.Name = "button_phong";
            this.button_phong.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.button_phong.Size = new System.Drawing.Size(225, 49);
            this.button_phong.TabIndex = 13;
            this.button_phong.Text = "  Phòng";
            this.button_phong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_phong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_phong.UseVisualStyleBackColor = false;
            this.button_phong.Click += new System.EventHandler(this.button_phong_Click);
            // 
            // button_bill
            // 
            this.button_bill.BackColor = System.Drawing.Color.Transparent;
            this.button_bill.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_bill.FlatAppearance.BorderSize = 0;
            this.button_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bill.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bill.ForeColor = System.Drawing.Color.Black;
            this.button_bill.Image = global::QuanLyHotel.Properties.Resources.bill32;
            this.button_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_bill.Location = new System.Drawing.Point(0, 267);
            this.button_bill.Margin = new System.Windows.Forms.Padding(2);
            this.button_bill.Name = "button_bill";
            this.button_bill.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.button_bill.Size = new System.Drawing.Size(225, 49);
            this.button_bill.TabIndex = 12;
            this.button_bill.Text = "  Hoá Đơn";
            this.button_bill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_bill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_bill.UseVisualStyleBackColor = false;
            this.button_bill.Click += new System.EventHandler(this.button_bill_Click);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.Color.White;
            this.btn_dangxuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangxuat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_dangxuat.ForeColor = System.Drawing.Color.Black;
            this.btn_dangxuat.Image = global::QuanLyHotel.Properties.Resources.logout;
            this.btn_dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat.Location = new System.Drawing.Point(0, 791);
            this.btn_dangxuat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Padding = new System.Windows.Forms.Padding(8, 0, 20, 0);
            this.btn_dangxuat.Size = new System.Drawing.Size(225, 53);
            this.btn_dangxuat.TabIndex = 8;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            // 
            // button_account
            // 
            this.button_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_account.FlatAppearance.BorderSize = 0;
            this.button_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_account.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_account.ForeColor = System.Drawing.Color.Black;
            this.button_account.Image = global::QuanLyHotel.Properties.Resources.userden;
            this.button_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_account.Location = new System.Drawing.Point(0, 218);
            this.button_account.Margin = new System.Windows.Forms.Padding(2);
            this.button_account.Name = "button_account";
            this.button_account.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.button_account.Size = new System.Drawing.Size(225, 49);
            this.button_account.TabIndex = 7;
            this.button_account.Text = "  Quản lý tài khoản";
            this.button_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_account.UseVisualStyleBackColor = true;
            this.button_account.Click += new System.EventHandler(this.button_account_Click);
            // 
            // button_khachhang
            // 
            this.button_khachhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_khachhang.FlatAppearance.BorderSize = 0;
            this.button_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_khachhang.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_khachhang.ForeColor = System.Drawing.Color.Black;
            this.button_khachhang.Image = global::QuanLyHotel.Properties.Resources.khachhangden;
            this.button_khachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_khachhang.Location = new System.Drawing.Point(0, 169);
            this.button_khachhang.Margin = new System.Windows.Forms.Padding(2);
            this.button_khachhang.Name = "button_khachhang";
            this.button_khachhang.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.button_khachhang.Size = new System.Drawing.Size(225, 49);
            this.button_khachhang.TabIndex = 5;
            this.button_khachhang.Text = "  Khách hàng";
            this.button_khachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_khachhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_khachhang.UseVisualStyleBackColor = true;
            this.button_khachhang.Click += new System.EventHandler(this.button_khachhang_Click);
            // 
            // button_nv
            // 
            this.button_nv.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_nv.FlatAppearance.BorderSize = 0;
            this.button_nv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nv.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nv.ForeColor = System.Drawing.Color.Black;
            this.button_nv.Image = global::QuanLyHotel.Properties.Resources.employeeden;
            this.button_nv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nv.Location = new System.Drawing.Point(0, 120);
            this.button_nv.Margin = new System.Windows.Forms.Padding(2);
            this.button_nv.Name = "button_nv";
            this.button_nv.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.button_nv.Size = new System.Drawing.Size(225, 49);
            this.button_nv.TabIndex = 3;
            this.button_nv.Text = "  Nhân viên";
            this.button_nv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_nv.UseVisualStyleBackColor = true;
            this.button_nv.Click += new System.EventHandler(this.button_nv_Click);
            // 
            // button_trangchu
            // 
            this.button_trangchu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_trangchu.FlatAppearance.BorderSize = 0;
            this.button_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trangchu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_trangchu.ForeColor = System.Drawing.Color.Black;
            this.button_trangchu.Image = global::QuanLyHotel.Properties.Resources.home3;
            this.button_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_trangchu.Location = new System.Drawing.Point(0, 74);
            this.button_trangchu.Margin = new System.Windows.Forms.Padding(2);
            this.button_trangchu.Name = "button_trangchu";
            this.button_trangchu.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.button_trangchu.Size = new System.Drawing.Size(225, 46);
            this.button_trangchu.TabIndex = 1;
            this.button_trangchu.Text = "  Trang chủ";
            this.button_trangchu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_trangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_trangchu.UseVisualStyleBackColor = true;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_logo.Controls.Add(this.roundedButton1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(2);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(225, 74);
            this.panel_logo.TabIndex = 0;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.Transparent;
            this.roundedButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.Black;
            this.roundedButton1.Image = global::QuanLyHotel.Properties.Resources.menu1;
            this.roundedButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton1.Location = new System.Drawing.Point(0, 30);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roundedButton1.Size = new System.Drawing.Size(225, 44);
            this.roundedButton1.TabIndex = 12;
            this.roundedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTitleBar.Controls.Add(this.lblTiltle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitleBar.Location = new System.Drawing.Point(225, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1152, 70);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.TabStop = true;
            // 
            // lblTiltle
            // 
            this.lblTiltle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiltle.ForeColor = System.Drawing.Color.White;
            this.lblTiltle.Location = new System.Drawing.Point(65, 7);
            this.lblTiltle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiltle.Name = "lblTiltle";
            this.lblTiltle.Size = new System.Drawing.Size(885, 44);
            this.lblTiltle.TabIndex = 0;
            this.lblTiltle.Text = "Home";
            this.lblTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_childForm
            // 
            this.panel_childForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_childForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_childForm.Location = new System.Drawing.Point(225, 70);
            this.panel_childForm.Margin = new System.Windows.Forms.Padding(2);
            this.panel_childForm.Name = "panel_childForm";
            this.panel_childForm.Size = new System.Drawing.Size(1152, 774);
            this.panel_childForm.TabIndex = 2;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.Transparent;
            this.roundedButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton2.ForeColor = System.Drawing.Color.Black;
            this.roundedButton2.Image = global::QuanLyHotel.Properties.Resources.service32;
            this.roundedButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton2.Location = new System.Drawing.Point(0, 463);
            this.roundedButton2.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roundedButton2.Size = new System.Drawing.Size(225, 49);
            this.roundedButton2.TabIndex = 17;
            this.roundedButton2.Text = "  Ca, lịch làm việ";
            this.roundedButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1377, 844);
            this.Controls.Add(this.panel_childForm);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel_menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTiltle;
        private System.Windows.Forms.Panel panel_childForm;
        private RoundedButton button_nv;
        private RoundedButton button_khachhang;
        private RoundedButton button_trangchu;
        private RoundedButton button_account;
        private RoundedButton btn_dangxuat;
        private Panel panel_logo;
        private RoundedButton roundedButton1;
        private RoundedButton button_phong;
        private RoundedButton button_bill;
        private RoundedButton button_dichvu;
        private RoundedButton button_dangkythuetra;
        private RoundedButton roundedButton2;
    }
}