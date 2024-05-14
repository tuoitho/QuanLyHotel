using QuanLyHotel.ACCOUNT;
using QuanLyHotel.BILL;
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
    public partial class FormPhatTien : Form
    {
        private int mahd,maph;

        public FormPhatTien()
        {
            InitializeComponent();
        }

        public FormPhatTien(int mahd,int maph):this()
        {
            this.mahd = mahd;
            this.maph = maph;
        }

        private void roundedButton_showall_Click(object sender, EventArgs e)
        {
            double tienphat= 0;
            try
            {
                tienphat = Convert.ToDouble(textBox_sotien.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số tiền phạt không hợp lệ");
                return;
            }
            //kiem tra da phat hom nay
            if (EMP.isDaPhatTienHomNay(Convert.ToInt32(textBox_manv.Text)))
            {
                if (MessageBox.Show("Nhân viên này đã bị phạt hôm nay, bạn có muốn tiếp tục phạt không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            int manv = Convert.ToInt32(textBox_manv.Text);
            try
            {
                EMP.insertHinhPhat(manv, DateTime.Now, tienphat);
                MessageBox.Show("Phạt tiền thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormPhatTien_Load(object sender, EventArgs e)
        {
            textBox1.Text = mahd.ToString();
            textBox2.Text = maph.ToString();
            textBox_manv.Text = HD.getMaNVLCPhuTrachByMaHD(mahd).ToString();
            int manv= Convert.ToInt32(textBox_manv.Text);
            textBox_tennv.Text = EMP.getTenNVByMaNV(manv);
        }
    }
}
