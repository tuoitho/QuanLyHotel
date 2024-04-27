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
    public partial class FormMain_KhachHang : Form
    {
        public FormMain_KhachHang()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_KhachHang_Load(object sender, EventArgs e)
        {
            dataGridView_mgg.DataSource = KH.getMaGiamGia();
        }
    }
}
