using QuanLyHotel.BILL;
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
            dataGridView_kb.DataSource = KH.getDSKhaiBaoDayDu(maHD);
            


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
            int maHD = Convert.ToInt32(dataGridView_hoadon.CurrentRow.Cells[0].Value);
            DataTable dt = KH.getDSKhaiBaoDayDu(maHD);
            dataGridView_kb.DataSource = null;
            dataGridView_kb.Rows.Clear();
            dataGridView_kb.Columns.Clear();
            dataGridView_kb.Columns.Add("Mã DV", "Mã DV");
            dataGridView_kb.Columns.Add("Số lượng nhân viên cập nhật", "Số lượng NV đã khai báo");
            dataGridView_kb.Columns.Add("Số lượng khách hàng khai báo", "Số lượng KH đã khai báo");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView_kb.Rows.Add();
                dataGridView_kb.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                dataGridView_kb.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                dataGridView_kb.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();

            }
            //dataGridView_kb.DataSource = KH.getDSKhaiBaoDayDu(maHD);
            //dataGridView_kb.Columns[2].ValueType = typeof(String);
            //dataGridView_kb.Columns[1].ValueType = typeof(String);
            for (int i = 0; i < dataGridView_kb.Rows.Count; i++)
            {
                if (dataGridView_kb.Rows[i].Cells[1].Value == DBNull.Value  ||dataGridView_kb.Rows[i].Cells[1].Value == "" || dataGridView_kb.Rows[i].Cells[1].Value ==null)
                    dataGridView_kb.Rows[i].Cells[1].Value = "Chưa khai báo";
                if (dataGridView_kb.Rows[i].Cells[2].Value == DBNull.Value|| dataGridView_kb.Rows[i].Cells[2].Value == "" || dataGridView_kb.Rows[i].Cells[2].Value ==null)
                    dataGridView_kb.Rows[i].Cells[2].Value = "Chưa khai báo";
                //if (Convert.ToInt32(dataGridView_kb.Rows[i].Cells[1].Value == DBNull.Value ? "0" : dataGridView_kb.Rows[i].Cells[1].Value)
                //    != Convert.ToInt32(dataGridView_kb.Rows[i].Cells[2].Value == DBNull.Value ? 0 : dataGridView_kb.Rows[i].Cells[2].Value))
                //{
                //    dataGridView_kb.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                //}
                if (dataGridView_kb.Rows[i].Cells[1].Value.ToString() != dataGridView_kb.Rows[i].Cells[2].Value.ToString())
                {
                    dataGridView_kb.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }
    }
}
