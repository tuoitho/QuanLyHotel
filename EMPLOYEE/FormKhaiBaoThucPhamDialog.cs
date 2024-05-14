using QuanLyHotel.BILL;
using QuanLyHotel.DICHVU;
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
    public partial class FormKhaiBaoThucPhamDialog : Form
    {
        private int mahd,maphong;

        public FormKhaiBaoThucPhamDialog()
        {
            InitializeComponent();
        }

        private void FormKhaiBaoThucPhamDialog_Load(object sender, EventArgs e)
        {
            textBox1.Text = mahd.ToString();
            textBox2.Text = maphong.ToString();
            roundedButton_kb.Enabled = !HD.checkLaoCongDaKBThucPham(mahd);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            int sl1=Convert.ToInt32(numericUpDown1.Value);
            int sl2 = Convert.ToInt32(numericUpDown2.Value);
            int sl3 = Convert.ToInt32(numericUpDown3.Value);
            int sl4 = Convert.ToInt32(numericUpDown4.Value);
            try
            {
                HD.insertKhaiBao(mahd, 1, sl1, true);
                HD.insertKhaiBao(mahd, 2, sl2, true);
                HD.insertKhaiBao(mahd, 3, sl3, true);
                HD.insertKhaiBao(mahd, 4, sl4, true);
                MessageBox.Show("Khai báo thực phẩm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FormKhaiBaoThucPhamDialog(int v, int maphong) :this()
        {
            this.mahd = v;
            this.maphong = maphong;
        }
    }
}
