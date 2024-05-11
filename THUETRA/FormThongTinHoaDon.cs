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
    public partial class FormThongTinHoaDon : Form
    {
        bool isLoaded=false;
        public FormThongTinHoaDon()
        {
            InitializeComponent();
            comboBox_loaidv.DataSource = DV.getDSLoaiDichVu();
            comboBox_loaidv.DisplayMember = "TenLDV";
            comboBox_loaidv.ValueMember = "MaLDV";
            comboBox_dv.DisplayMember = "TenDV";
            comboBox_dv.ValueMember = "MaDV";
            isLoaded=true;
        }
        public FormThongTinHoaDon(int mahoadon):this()
        {
            loadData(mahoadon);
        }

        private void loadData(int mahoadon)
        {
            DataTable thongtinhoadondaydu = TT.getThongTinHoaDonTuMaHD(mahoadon);
            txtMaHoaDon.Text = thongtinhoadondaydu.Rows[0]["MaHD"].ToString();
            txtTenHoaDon.Text = thongtinhoadondaydu.Rows[0]["TenHD"].ToString();
            txtTongTien.Text = thongtinhoadondaydu.Rows[0]["TongTien"].ToString();
            txt_tiencoc.Text = thongtinhoadondaydu.Rows[0]["TienCoc"].ToString();
            txt_tiendv.Text = thongtinhoadondaydu.Rows[0]["TienDichVu"].ToString();
            txt_tienphong.Text = thongtinhoadondaydu.Rows[0]["TienPhong"].ToString();
            textBox_makh.Text = thongtinhoadondaydu.Rows[0]["MaKH"].ToString();
            textBox_tenkh.Text = thongtinhoadondaydu.Rows[0]["HoTen"].ToString();
            textBox_sdt.Text = thongtinhoadondaydu.Rows[0]["SDT"].ToString();
            textBox_cmnd.Text = thongtinhoadondaydu.Rows[0]["CCCD"].ToString();
            textBox_quoctich.Text = thongtinhoadondaydu.Rows[0]["QuocTich"].ToString();
            textBox_maphong.Text = thongtinhoadondaydu.Rows[0]["MaPhong"].ToString();
            textBox_tenphong.Text = thongtinhoadondaydu.Rows[0]["TenPhong"].ToString();
            textBox_giaphong.Text = thongtinhoadondaydu.Rows[0]["GiaPhong"].ToString();
            textBox_tthd.Text = thongtinhoadondaydu.Rows[0]["TrangThaiHoaDon"].ToString();
            if (textBox_tthd.Text == "Đã thanh toán")
            {
                btn_dangkidv.Enabled = false;
                button_traphong.Enabled = false;
                label_ngaythanhtoan.Visible = true;
                dateTimePicker_ngaythanhtoan.Visible = true;
                dateTimePicker_ngaythanhtoan.Value = Convert.ToDateTime(thongtinhoadondaydu.Rows[0]["NgayThanhToan"].ToString());
            }
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
           
            int mhd = Convert.ToInt32(txtMaHoaDon.Text);
            dataGridView_dv.DataSource = DV.getDSDichVuByMaHD(mhd);
            dataGridView_dv.DefaultCellStyle.SelectionBackColor = Color.Purple;

        }



        private void btn_dangkidv_Click(object sender, EventArgs e)
        {
            if (numericUpDown_sldv.Value == 0)
            {
                MessageBox.Show("Số lượng dịch vụ phải lớn hơn 0", "Đăng ký dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox_dv.SelectedValue == null)
            {
                
                MessageBox.Show("Loại dv ko có dịch vụ nào, hãy chọn loại dịch vụ khác", "Đăng ký dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox_dv.SelectedValue.ToString()=="")
            {
                MessageBox.Show("Loại dv ko có dịch vụ nào, hãy chọn loại dịch vụ khác", "Đăng ký dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int madv = Convert.ToInt32( comboBox_dv.SelectedValue.ToString());
            int mhd = Convert.ToInt32(txtMaHoaDon.Text);
            int sl = Convert.ToInt32(numericUpDown_sldv.Value);
            double gia = Convert.ToDouble(textBox_giadv.Text);
            try
            {
                DV.themChiTietHDDV(madv, mhd, sl, gia);
                MessageBox.Show("Đăng ký dịch vụ thành công", "Đăng ký dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
                loadData(mhd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đăng ký dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void reload()
        {
            dataGridView_dv.DataSource = DV.getDSDichVuByMaHD(Convert.ToInt32(txtMaHoaDon.Text));
            //txtTongTien= dv.getTongTienHoaDon(txtMaHoaDon.Text);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox_loaidv_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            if (DV.getDSDichVu(Convert.ToInt32(comboBox_loaidv.SelectedValue.ToString())) != null)
                comboBox_dv.DataSource = DV.getDSDichVu(Convert.ToInt32(comboBox_loaidv.SelectedValue.ToString()));
            else return;
                comboBox_dv.SelectedIndex = -1;

        }

        private void comboBox_loaidv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_dv_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            if (comboBox_dv.SelectedValue == null   ) return;
            int madv = Convert.ToInt32(comboBox_dv.SelectedValue.ToString());
            double dv = DV.getGiaDV(madv);
            textBox_giadv.Text = dv.ToString();

        }

        private void comboBox_dv_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormThanhToan ftt = new FormThanhToan(Convert.ToInt32(txtMaHoaDon.Text));
            ftt.ShowDialog();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
