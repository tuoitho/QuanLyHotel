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
            int makh = Info.id;
            dataGridView_mgg.DataSource = KH.getMaGiamGia(makh);
            //lay thong tin phong da thue
            DataTable phong = KH.getPhongDaThue(makh);
            label_xc.Text = "Xin chào, khách hàng " + KH.getNameByID(makh);
            textBox_maph.Text = phong.Rows[0][0].ToString();
            dateTimePicker_ngayvao.Text = phong.Rows[0][1].ToString();
            dateTimePicker_ngaydi.Text = phong.Rows[0][2].ToString();
        }

        private void button_khaibao_Click(object sender, EventArgs e)
        {
            int mahd = KH.getMaHoaDonHienTaiByMaKH(Info.id);
            FormKhaiBao formKhaiBao = new FormKhaiBao(mahd);
            formKhaiBao.ShowDialog();
        }

        private void button_f5_Click(object sender, EventArgs e)
        {
            int makh = Info.id;
            dataGridView_mgg.DataSource = KH.getMaGiamGia(makh);

        }
    }
}
