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
                    MessageBox.Show("Login Success");
                    string role = acc.Rows[0]["role"].ToString();
                    if (role == "admin")
                    {
                        Info.role = "admin";
                        Info.id=Info.chucvu = -1;
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (role == "nhanvien")
                    {
                        //lay ma nhan vien la ky tu so trong username bo 2 ki tu dau
                        int manv=Convert.ToInt32(username.Substring(2));
                        Info.role = "nhanvien";
                        Info.id = manv;
                        //get chucvu tu ma nhan vien
                        int cv = EMP.getChucVu(manv);
                        Info.chucvu = cv;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        int makh=Convert.ToInt32(username.Substring(2));
                        Info.role = "khachhang";
                        Info.id = makh;
                        Info.chucvu = -1;
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
    }
}
