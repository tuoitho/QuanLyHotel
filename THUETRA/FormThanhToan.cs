using Newtonsoft.Json;
using QuanLyHotel.BILL;
using QuanLyHotel.DICHVU;
using QuanLyHotel.KHACHHANG;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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
            textBox_sotienthucpham.Text = DV.getTongTienThucPhamByMaHD(mahoadon).ToString();
            double sotienthucpham= Convert.ToDouble(textBox_sotienthucpham.Text);
            textBox_sotiengiamgia.Text=sotiengiamgia.ToString();
            textBox_sotienhoadoncantra.Text = (Convert.ToDouble(txtTongTien.Text) - sotiengiamgia+ sotienthucpham).ToString();


            button_print.Enabled=(textBox_tttt.Text=="Đã thanh toán");
            button_hoanthanh.Enabled = (textBox_tttt.Text != "Đã thanh toán");
            dataGridView_dv.DataSource = DV.getDSDichVuByMaHD(mahoadon);


        }
        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            loadData(mahoadon);
            loadDatabank();
        }

        private void loadDatabank()
        {
            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);

                cb_nganhang.DataSource = listBankData.data;   // list banks
                cb_nganhang.DisplayMember = "custom_name";
                cb_nganhang.ValueMember = "bin";
                cb_nganhang.Text = listBankData.data.FirstOrDefault().bin;
                cb_template.SelectedIndex = 0;
            }
        }

        private void button_hoanthanh_Click(object sender, EventArgs e)
        {
            try
            {
                TT.InsertThanhToan(mahoadon, DateTime.Now, Convert.ToDouble(textBox_tongtienhd.Text), Convert.ToDouble(textBox_sotiengiamgia.Text), Convert.ToDouble(textBox_sotienhoadoncantra.Text));
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

        private void button_taoqr_Click(object sender, EventArgs e)
        {
            try
            {
                var apiRequest = new ApiRequest();
                apiRequest.acqId = Convert.ToInt32(cb_nganhang.SelectedValue.ToString());
                apiRequest.accountNo = txtSTK.Text;
                apiRequest.accountName = txtTenTaiKhoan.Text;
                apiRequest.amount = Convert.ToInt32(txtSoTien.Text);
                apiRequest.format = "text";
                apiRequest.template = cb_template.Text;
                var jsonRequest = JsonConvert.SerializeObject(apiRequest);
                // use restsharp for request api.
                var client = new RestClient("https://api.vietqr.io/v2/generate");
                var request = new RestRequest();

                request.Method = Method.POST;
                request.AddHeader("Accept", "application/json");

                request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

                var response = client.Execute(request);
                var content = response.Content;
                var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);


                var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
                pictureBox1.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
    }
}
