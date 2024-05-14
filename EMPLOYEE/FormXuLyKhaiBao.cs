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

namespace QuanLyHotel.EMPLOYEE
{
    public partial class FormXuLyKhaiBao : Form
    {
        public FormXuLyKhaiBao()
        {
            InitializeComponent();
        }
        private int maHD;
        public FormXuLyKhaiBao(int mahd)
        {
            InitializeComponent();
            this.maHD = mahd;
            //dataGridView_kb.DataSource = KH.getDSKhaiBaoDayDu(maHD);
            


        }

        private void FormXuLyKhaiBao_Load(object sender, EventArgs e)
        {
            dataGridView_hoadon.DataSource = HD.getDSHoaDonKH("");
            for (int i = 0; i < dataGridView_kb.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGridView_kb.Rows[i].Cells[1].Value == DBNull.Value ? 0 : dataGridView_kb.Rows[i].Cells[1].Value)
                    != Convert.ToInt32(dataGridView_kb.Rows[i].Cells[2].Value == DBNull.Value ? 0 : dataGridView_kb.Rows[i].Cells[2].Value))
                {
                    dataGridView_kb.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void dataGridView_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vipham = false;
            int maHD = Convert.ToInt32(dataGridView_hoadon.CurrentRow.Cells[0].Value);
            DataTable dtLaoCongKB=DV.getDSLCKhaiBao(maHD);
            DataTable dtKhachHangKB = DV.getDSKHKhaiBao(maHD);
            //DataTable dt = KH.getDSKhaiBaoDayDu(maHD);
            dataGridView_kb.DataSource = null;
            dataGridView_kb.Rows.Clear();
            dataGridView_kb.Columns.Clear();
            dataGridView_kb.DataSource = dtLaoCongKB;
            dataGridView_kb.Columns.Add("slkhkb", "Số Lượng Khách Hàng Khai Báo");
            if (dtLaoCongKB.Rows.Count == 0)
            {
                MessageBox.Show("Hóa đơn này chưa có lao công khai báo");
                return;
            }
            for (int i = 0; i < dataGridView_kb.Rows.Count; i++)
            {
                dataGridView_kb.Rows[i].Cells[4].Value = dtKhachHangKB.Rows.Count==0?"Chưa khai báo":dtKhachHangKB.Rows[i][3];
            }
            for (int i = 0; i < dataGridView_kb.Rows.Count; i++)
            {
                if (dataGridView_kb.Rows[i].Cells[3].Value == DBNull.Value  ||dataGridView_kb.Rows[i].Cells[3].Value == "" || dataGridView_kb.Rows[i].Cells[3].Value ==null)
                    dataGridView_kb.Rows[i].Cells[3].Value = "Chưa khai báo";
                if (dataGridView_kb.Rows[i].Cells[4].Value == DBNull.Value|| dataGridView_kb.Rows[i].Cells[4].Value == "" || dataGridView_kb.Rows[i].Cells[4].Value ==null)
                    dataGridView_kb.Rows[i].Cells[4].Value = "Chưa khai báo";

                if (dataGridView_kb.Rows[i].Cells[3].Value.ToString() != dataGridView_kb.Rows[i].Cells[4].Value.ToString())
                {
                    vipham = true;
                    dataGridView_kb.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        bool vipham = false;
        private void dataGridView_hoadon_CellClick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //lay ma hoa don hien tai
            if (!vipham)
            {
                MessageBox.Show("Không có vi phạm, bạn không được vô cớ phạt");
                return;
            }
            int mahd = Convert.ToInt32(dataGridView_hoadon.CurrentRow.Cells[0].Value);
            int maph = Convert.ToInt32(dataGridView_hoadon.CurrentRow.Cells[9].Value);
            FormPhatTien formPhatTien = new FormPhatTien(mahd,maph);
            formPhatTien.ShowDialog();
        }
    }
}
