using QuanLyHotel.BILL;
using QuanLyHotel.DICHVU;
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

namespace QuanLyHotel.KHACHHANG
{
    public partial class FormKhaiBao : Form
    {
        public FormKhaiBao()
        {
            InitializeComponent();
        }
        private int mahd;
        public FormKhaiBao(int mahd):this()
        {
            this.mahd = mahd;
        }
        bool dakhaibao = false;
        private void FormKhaiBao_Load(object sender, EventArgs e)
        {
            textBox_mahd.Text = mahd.ToString();



            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button_f5_Click(object sender, EventArgs e)
        {
        }

        private void roundedButton_kb_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(numericUpDown1.Value);
            int s2 = Convert.ToInt32(numericUpDown2.Value);
            int s3 = Convert.ToInt32(numericUpDown3.Value);
            int s4 = Convert.ToInt32(numericUpDown4.Value);
            try
            {
                HD.insertKhaiBao(mahd, 1, s1, false);
                HD.insertKhaiBao(mahd, 2, s2, false);
                HD.insertKhaiBao(mahd, 3, s3, false);
                HD.insertKhaiBao(mahd, 4, s4, false);
                MessageBox.Show("Khai báo thành công, chúc mừng bạn đã nhận được 1 Mã Giảm Giá ");
                KH.addMaGiamGia(Info.id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
