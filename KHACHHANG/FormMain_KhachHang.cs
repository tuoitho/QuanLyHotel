using QuanLyHotel.BILL;
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
            label_xc.Text = "Xin chào, " + KH.getNameByID(makh);
            dataGridView_lsdk.DataSource= TT.getLichSuPDKHoanThanh(makh);
          
        }

        private void button_khaibao_Click(object sender, EventArgs e)
        {
            //if hoa don da thanh toan thi k dc khai bao
            if (TT.isHoaDonDaThanhToan(Convert.ToInt32(txtMaHoaDon.Text)))
            {
                MessageBox.Show("Hóa đơn đã thanh toán rồi, bạn ko đc khai báo");
                return;
            }
            //neu da khai bao thi khong duoc khai bao nua

            if (TT.isKHDaKhaiBao(Convert.ToInt32(txtMaHoaDon.Text)))
            {
                MessageBox.Show("Đã khai báo rồi");
                return;
            }
            int mahd = KH.getMaHoaDonHienTaiByMaKH(Info.id);
            FormKhaiBao formKhaiBao = new FormKhaiBao(mahd);
            formKhaiBao.ShowDialog();
        }

        private void button_f5_Click(object sender, EventArgs e)
        {
            int makh = Info.id;
            dataGridView_mgg.DataSource = KH.getMaGiamGia(makh);


        }

        private void dataGridView_lsdk_Click(object sender, EventArgs e)
        {
            if (dataGridView_lsdk.Rows.Count == 0) return;
            int mapdk = Convert.ToInt32(dataGridView_lsdk.CurrentRow.Cells[0].Value.ToString());
            int mahd=Convert.ToInt32( TT.getMaHoaDonbyMaPDK(mapdk));
            DataTable tbHD = TT.getThongTinHoaDonTuMaHD(mahd);
            textBox_maph.Text = tbHD.Rows[0]["maphong"].ToString();
            txtMaHoaDon.Text = mahd.ToString();
            txt_tiencoc.Text = tbHD.Rows[0][3].ToString();
            txt_tienphong.Text = tbHD.Rows[0][4].ToString();
            txt_tiendv.Text = tbHD.Rows[0][5].ToString();
        }
    }
}
