using QuanLyHotel.ACCOUNT;
using QuanLyHotel.EMPLOYEE;
using QuanLyHotel.KHACHHANG;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            radioButton_admin.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            try
            {
                DataTable acc=ACC.getAcc(username, password);
                if (acc.Rows.Count > 0)
                {
                    string role = acc.Rows[0]["role"].ToString();
                    
                    Info.role = role;

                    if (role == "admin")
                    {
                        if (radioButton_user.Checked)
                        {
                            MessageBox.Show("Bạn là admin, vui lòng chọn admin để tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (groupBox1.Enabled == true)
                            if (radioButton_emp.Checked)
                            {
                                MessageBox.Show("Bạn là admin và vào form của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Info.form = "employee";
                            }
                        if (groupBox1.Enabled == true)
                            if (radioButton_cus.Checked)
                            {
                                MessageBox.Show("Bạn là admin và vào form của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Info.form = "customer";
                            }
                        Info.id=Info.chucvu = -1;
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (role == "employee")
                    {
                        if (radioButton_admin.Checked)
                        {
                            MessageBox.Show("Bạn là nhân viên, vui lòng chọn user để tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
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
                        if (radioButton_admin.Checked)
                        {
                            MessageBox.Show("Bạn là khách hàng, vui lòng chọn user để tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        int makh = Convert.ToInt32(ACC.getMaKHByMaTK(Convert.ToInt32(acc.Rows[0]["matk"].ToString())));
                        Info.id = makh;
                        Info.chucvu = -1;
                        Info.form = "customer";
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_admin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_admin.Checked)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }
    }
}
