using QuanLyHotel.BILL;
using QuanLyHotel.DICHVU;
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

namespace QuanLyHotel.THUETRA
{
    public partial class FormThanhToan : Form
    {
        private int mahoadon;

        public FormThanhToan()
        {
            InitializeComponent();
            dataGridView_dv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView_dv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //auto fill width
            dataGridView_dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_dv.DefaultCellStyle.SelectionBackColor = Color.Purple;

        }

        public FormThanhToan(int mahoadon):this()
        {
            this.mahoadon = mahoadon;
        }
        int magiamgia = -1;
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
            DataTable thongtinngayvaora=TT.getPPKTuMaHD(mahoadon);

            dateTimePicker_vao.Value = Convert.ToDateTime(thongtinngayvaora.Rows[0]["DuKienDen"].ToString());
            dateTimePicker_ra.Value = DateTime.Now;
            //trang thai thanh toan
            textBox_tttt.Text =  HD.getStatus(mahoadon);
            textBox_tongtienhd.Text = txtTongTien.Text;
            DataTable dsmgg=KH.getMaGiamGiaChuaSuDungByMaKH(textBox_makh.Text);
            double sotiengiamgia = 0;
            if (dsmgg.Rows.Count > 0)
            {
                magiamgia = Convert.ToInt32(dsmgg.Rows[0]["MaGiamGia"].ToString());
                sotiengiamgia = Convert.ToDouble(dsmgg.Rows[0]["SoTien"].ToString());
            }
            textBox_sotiengiamgia.Text=sotiengiamgia.ToString();
            textBox_sotiencantra.Text = (Convert.ToDouble(txtTongTien.Text) - sotiengiamgia).ToString();


            button_print.Enabled=(textBox_tttt.Text=="Đã thanh toán");
            button_hoanthanh.Enabled = (textBox_tttt.Text != "Đã thanh toán");
            dataGridView_dv.DataSource = DV.getDSDichVuByMaHD(mahoadon);

        }
        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            loadData(mahoadon);
        }

        private void button_hoanthanh_Click(object sender, EventArgs e)
        {
            try
            {
                TT.InsertThanhToan(mahoadon, DateTime.Now, Convert.ToDouble(textBox_tongtienhd.Text), Convert.ToDouble(textBox_sotiengiamgia.Text), Convert.ToDouble(textBox_sotiencantra.Text));
                if (magiamgia != -1)
                    try
                    {

                        KH.updateMaGiamGiaDaSuDung(magiamgia);
                    }
                                        catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                
                MessageBox.Show("Thanh toán thành công", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_tttt.Text = HD.getStatus(mahoadon);
                button_print.Enabled = true;
                button_hoanthanh.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
