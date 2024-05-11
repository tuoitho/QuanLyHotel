using QuanLyHotel.ACCOUNT;
using QuanLyHotel.BILL;
using QuanLyHotel.DICHVU;
using QuanLyHotel.KHACHHANG;
using QuanLyHotel.LamVieic;
using QuanLyHotel.PHONG;
using QuanLyHotel.Riengbiet;
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
            if (Info.role == "employee")
            {

                if (Info.chucvu == 1)
                {
                    button_account.Visible = false;
                }
                else
                if (Info.chucvu == 2)
                {
                    button_nv.Visible = false;
                    button_account.Visible = false;
                }
                else if (Info.chucvu == 3)
                {
                    button_nv.Visible = false;
                    button_account.Visible = false;
                    button_bill.Visible = false;
                    button_phong.Visible = false;
                }
            }
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
            FormHoaDon formHoaDon = new FormHoaDon();
            OpenChildForm(formHoaDon, sender);
            lblTiltle.Text = "Hóa đơn";
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

        private void button_account_Click(object sender, EventArgs e)
        {
            FormAccount formAccount = new FormAccount();
            OpenChildForm(formAccount, sender);
            lblTiltle.Text = "Tài khoản";
        }

        private void button_khachhang_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            OpenChildForm(formKhachHang, sender);
            lblTiltle.Text = "Khách hàng";
        }

        private void button_lich_Click(object sender, EventArgs e)
        {

        }

        private void button_qlthanhtoan_Click(object sender, EventArgs e)
        {

        }

        private void button_dichvu_Click(object sender, EventArgs e)
        {
            FormQuanLyDichVu formDichVu = new FormQuanLyDichVu();
            OpenChildForm(formDichVu, sender);

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            FormCaLamViec formCaLamViec = new FormCaLamViec();
            OpenChildForm(formCaLamViec, sender);
            lblTiltle.Text = "Ca làm việc";
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            FormBaoCaoDoanhthu formBaoCaoDoanhthu = new FormBaoCaoDoanhthu();
            OpenChildForm(formBaoCaoDoanhthu, sender);
            lblTiltle.Text = "Báo cáo doanh thu";
        }
    }
}
