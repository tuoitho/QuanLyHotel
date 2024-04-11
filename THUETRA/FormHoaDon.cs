using QuanLyHotel.DICHVU;
using QuanLyHotel.EMPLOYEE;
using QuanLyHotel.KHACHHANG;
using QuanLyHotel.PHONG;
using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.THUETRA
{
    public partial class FormHoaDon : Form
    {
        TT tt = new TT();
        KH kh = new KH();
        EMP emp = new EMP();
        PH ph = new PH();
        DV dv = new DV();
        public FormHoaDon()
        {
            InitializeComponent();
            comboBox_loaidv.DataSource = dv.getDSLoaiDichVu();
            comboBox_loaidv.DisplayMember = "TenLDV";
            comboBox_loaidv.ValueMember = "MaLDV";
            comboBox_dv.DisplayMember = "TenDV";
            comboBox_dv.ValueMember = "MaDV";
            
        }
        public FormHoaDon(string maphieudk):this()
        {
            DataTable thongtinhoadondaydu = tt.getThongTinHoaDonTuMaPDK(maphieudk);
            txtMaHoaDon.Text = thongtinhoadondaydu.Rows[0]["MaHD"].ToString();
            txtTenHoaDon.Text = thongtinhoadondaydu.Rows[0]["TenHD"].ToString();
            txtTongTien.Text = thongtinhoadondaydu.Rows[0]["TongTien"].ToString();
            textBox_makh.Text = thongtinhoadondaydu.Rows[0]["MaKH"].ToString();
            textBox_tenkh.Text = thongtinhoadondaydu.Rows[0]["HoTen"].ToString();
            textBox_sdt.Text = thongtinhoadondaydu.Rows[0]["SDT"].ToString();
            textBox_cmnd.Text = thongtinhoadondaydu.Rows[0]["CCCD"].ToString();
            textBox_quoctich.Text = thongtinhoadondaydu.Rows[0]["QuocTich"].ToString();
            textBox_maphong.Text = thongtinhoadondaydu.Rows[0]["MaPhong"].ToString();
            textBox_tenphong.Text = thongtinhoadondaydu.Rows[0]["TenPhong"].ToString();
            textBox_giaphong.Text = thongtinhoadondaydu.Rows[0]["GiaPhong"].ToString();
        }


        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            string mhd = txtMaHoaDon.Text;
            dataGridView_dv.DataSource = dv.getDSDichVuByMaHD(mhd);
        }

        private void comboBox_loaidv_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox_dv.DataSource = dv.getDSDichVu(comboBox_loaidv.SelectedValue.ToString());
            //comboBox_dv.DisplayMember = "TenDV";
            //comboBox_dv.ValueMember = "MaDV";
        }

        private void comboBox_loaidv_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox_dv_SelectedValueChanged(object sender, EventArgs e)
        {
            string madv = comboBox_dv.SelectedValue.ToString();
            double dv = this.dv.getGiaDV(madv);
            textBox_giadv.Text = dv.ToString();
        }

        private void btn_dangkidv_Click(object sender, EventArgs e)
        {
            if (numericUpDown_sldv.Value == 0)
            {
                MessageBox.Show("Số lượng dịch vụ phải lớn hơn 0", "Đăng ký dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string madv = comboBox_dv.SelectedValue.ToString();
            string mhd = txtMaHoaDon.Text;
            int sl = Convert.ToInt32(numericUpDown_sldv.Value);
            double gia = Convert.ToDouble(textBox_giadv.Text);
            try
            {
                dv.themChiTietHDDV(madv, mhd, sl, gia);
                MessageBox.Show("Đăng ký dịch vụ thành công", "Đăng ký dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đăng ký dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void reload()
        {
            dataGridView_dv.DataSource = dv.getDSDichVuByMaHD(txtMaHoaDon.Text);
            //txtTongTien= dv.getTongTienHoaDon(txtMaHoaDon.Text);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
