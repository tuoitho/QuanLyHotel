using QuanLyHotel.ACCOUNT;
using QuanLyHotel.EMPLOYEE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            radioButton_emp.Checked = true;

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            //chon mac dinh vao textBox_username
            textBox_username.Select();
        }
        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            try
            {
                DataTable acc = ACC.getAcc(username, password);
                if (acc.Rows.Count > 0)
                {
                    string role = acc.Rows[0]["role"].ToString();

                    Info.role = role;

                    if (role == "admin")
                    {
                        CustomMessageBox customMessageBox = new CustomMessageBox("Đăng nhập thành công\nBạn là Admin", "Thông báo");
                        customMessageBox.Icon = SystemIcons.Information;
                        customMessageBox.ShowDialog();

                        if (radioButton_emp.Checked)
                        {
                            Info.form = "employee";
                        }
                        else
                        {
                            Info.form = "customer";
                        }
                        Info.id = Info.chucvu = -1;
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (role == "employee")
                    {
                        if (radioButton_emp.Checked)
                        {
                            CustomMessageBox customMessageBox = new CustomMessageBox("Đăng nhập thành công\nBạn là Nhân viên", "Thông báo");
                            customMessageBox.Icon = SystemIcons.Information;

                            customMessageBox.ShowDialog();
                            int manv = Convert.ToInt32(ACC.getMaNVByMaTK(Convert.ToInt32(acc.Rows[0]["matk"].ToString())));
                            Info.id = manv;
                            //get chucvu tu ma nhan vien
                            int cv = EMP.getChucVu(manv);
                            Info.chucvu = cv;
                            Info.form = "employee";
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Sai tk or mk");
                        }
                    }
                    else
                    {
                        if (radioButton_cus.Checked)
                        {
                            CustomMessageBox customMessageBox = new CustomMessageBox("Đăng nhập thành công\nBạn là Khách Hàng", "Thông báo");
                            customMessageBox.Icon = SystemIcons.Information;
                            customMessageBox.ShowDialog();
                            int makh = Convert.ToInt32(ACC.getMaKHByMaTK(Convert.ToInt32(acc.Rows[0]["matk"].ToString())));
                            Info.id = makh;
                            Info.chucvu = -1;
                            Info.form = "customer";
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            CustomMessageBox customMessageBox = new CustomMessageBox("Sai tk or mk", "Thông báo");
                            customMessageBox.Icon = SystemIcons.Information;
                            customMessageBox.ShowDialog();
                        }
                    }
                }
                else
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Sai tk or mk", "Thông báo");
                    customMessageBox.Icon = SystemIcons.Information;
                    customMessageBox.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();
        }
    }
    class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, string caption)
        {
            // Thiết lập các thuộc tính cho cửa sổ
            this.Text = caption;
            this.Size = new Size(600, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Tạo Label để hiển thị nội dung thông báo
            Label label = new Label();
            label.Text = message;
            label.AutoSize = true;
            label.Location = new Point(20, 20);
            this.Controls.Add(label);

            // Tạo nút OK để đóng cửa sổ
            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(200, 130);
            okButton.Size = new Size(100, 50);
            okButton.Font = new Font(okButton.Font.FontFamily, 20, FontStyle.Bold);
            okButton.BackColor = Color.Yellow;
            this.Controls.Add(okButton);

            // Tăng kích thước chữ của Label
            label.Font = new Font(label.Font.FontFamily, 25, FontStyle.Bold); // Thay đổi kích thước chữ ở đây
            label.ForeColor = Color.Red;
            //chu dam


            // Cài đặt sự kiện khi nhấn Enter cũng đóng cửa sổ
            this.AcceptButton = okButton;
        }
    }
}
