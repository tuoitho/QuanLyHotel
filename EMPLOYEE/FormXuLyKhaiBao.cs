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
            dataGridView_kb.DataSource = KH.getDSKhaiBaoDayDu(maHD);
            for (int i = 0; i < dataGridView_kb.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGridView_kb.Rows[i].Cells[1].Value == DBNull.Value ? 0 : dataGridView_kb.Rows[i].Cells[1].Value)
                    != Convert.ToInt32(dataGridView_kb.Rows[i].Cells[2].Value == DBNull.Value ? 0 : dataGridView_kb.Rows[i].Cells[2].Value))
                {
                    dataGridView_kb.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }
    }
}
