using Microsoft.Kiota.Abstractions;
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

namespace QuanLyHotel.Riengbiet
{
    public partial class FormBaoCaoDoanhthu : Form
    {
        MyDB mydb = new MyDB();
        double getTienCoc(DateTime d)
        {
            double res = 0;
            DataTable dt = new DataTable();
           using (SqlCommand cmd = new SqlCommand("select isnull(sum(TienDatCoc),0) TienCoc from PhieuDangKy where NgayTao=@d;\r\n", mydb.GetConnection))
            {
                cmd.Parameters.Add("@d", SqlDbType.Date).Value = d;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            res = double.Parse(dt.Rows[0][0].ToString());
            return res;
        }
        double getTienThanhToan(DateTime d)
        {
            double res = 0;
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("select isnull(sum(SoTien),0) TienHoaDon from ThanhToan where cast(NgayThanhToan as date)=@d;", mydb.GetConnection))
            {
                cmd.Parameters.Add("@d", SqlDbType.Date).Value = d;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            res = double.Parse(dt.Rows[0][0].ToString());
            return res;
        }
        double getTienLuongNV(DateTime d)
        {
            double res = 0;
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("select ISNULL(SUM(TienLuong),0) TienLuongNV from Luong where Ngay=@d;", mydb.GetConnection))
            {
                cmd.Parameters.Add("@d", SqlDbType.Date).Value = d;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            res = double.Parse(dt.Rows[0][0].ToString());
            return res;
        }
        public FormBaoCaoDoanhthu()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void FormBaoCaoDoanhthu_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("ngay", typeof(DateTime));
            dt.Columns.Add("tiencoc", typeof(double));
            dt.Columns.Add("tienthanhtoanhoadon", typeof(double));
            dt.Columns.Add("tienluongnv", typeof(double));
            for (DateTime d = DateTime.Now.AddDays(-8); d <= DateTime.Now.AddDays(-1); d = d.AddDays(1))
            {
                dt.Rows.Add(d, getTienCoc(d), getTienThanhToan(d), getTienLuongNV(d));

            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Ngày";
            dataGridView1.Columns[1].HeaderText = "Tiền cọc từ PĐK";
            dataGridView1.Columns[2].HeaderText = "Tiền thanh toán hoá đơn";
            dataGridView1.Columns[3].HeaderText = "Tiền lương NV";
            dataGridView1.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void button_xembd_Click(object sender, EventArgs e)
        {
            //lay tu dategrid dua vao table
            FormBieuDoDoanhThu f = new FormBieuDoDoanhThu(dt);
            f.Show();

        }
    }
}
