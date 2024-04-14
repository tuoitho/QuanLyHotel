using QuanLyHotel.PHONG;
using QuanLyHotel.THUETRA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.EMPLOYEE
{
    public partial class FormMain : Form
    {
        private Form activeForm;
        private Button currentButton;

        public FormMain()
        {
            InitializeComponent();
        }

        private void button_nv_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            OpenChildForm(formNhanVien, sender);
            lblTiltle.Text = "Nhân viên";
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_childForm.Controls.Add(childForm);
            this.panel_childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTiltle.Text = childForm.Text;

        }
        private void ActivateButton(object btnSender)
        {

            Color color = Color.FromArgb(0, 108, 225);
            if (btnSender != null)
            {

                if (currentButton != (RoundedButton)btnSender)
                {

                    currentButton = (RoundedButton)btnSender;
                    DisableButton();
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitleBar.BackColor = color;
                    panel_logo.BackColor = Color.Transparent;
                }
            }
        }
        private void DisableButton()
        {
                        foreach (Control previousBtn in panel_menu.Controls)
            {
                if (previousBtn.GetType() == typeof(RoundedButton))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

        }
        bool isCollapsed = false;
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                panel_menu.Size = panel_menu.MinimumSize;
                foreach (Control bt in panel_menu.Controls)
                {
                    if (bt.GetType() == typeof(RoundedButton))
                    {
                        bt.Text = "";
                    }
                }
                isCollapsed = true;
            }
            else
            {
                panel_menu.Size = panel_menu.MaximumSize;
                isCollapsed = false;
                button_lich.Text = "  Lịch làm việc";
                btn_dangxuat.Text = "Đăng xuất";
                button_account.Text = "  Quản lý tài khoản";
                button_khachhang.Text = "  Khách hàng";
                button_nv.Text = "  Nhân viên";
                button_trangchu.Text = "  Trang chủ";
                button_phong.Text = "  Phòng";
                button_dichvu.Text = "  Dịch vụ";
                btn_dangxuat.Text = "  Đăng xuất";
                button_bill.Text = "  Hoá đơn";

            }

        }

        private void button_bill_Click(object sender, EventArgs e)
        {

        }

        private void button_phong_Click(object sender, EventArgs e)
        {
            FormPhong formPhong = new FormPhong();
            OpenChildForm(formPhong, sender);
            lblTiltle.Text = "Phòng";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button_dangkythuetra_Click(object sender, EventArgs e)
        {
            FormPhieuDangKy formPhieuDangKy = new FormPhieuDangKy();
            OpenChildForm(formPhieuDangKy, sender);
            lblTiltle.Text = "Phiếu đăng ký";
        }
    }
}
