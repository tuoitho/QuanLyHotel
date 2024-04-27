using QuanLyHotel.BILL;
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
    public partial class FormTraPhong : Form
    {
        public FormTraPhong()
        {
            InitializeComponent();
            dataGridView_hoadon.DefaultCellStyle.SelectionBackColor = Color.Purple;

        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            int makh=Convert.ToInt32(textBox_kh.Text);
            dataGridView_hoadon.DataSource = HD.TimKiemHoaDon(makh);

        }

        private void dataGridView_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int mahoadon = Convert.ToInt32(dataGridView_hoadon.CurrentRow.Cells[0].Value);
            FormThanhToan f = new FormThanhToan(mahoadon);
            f.ShowDialog();
        }

        private void FormTraPhong_Load(object sender, EventArgs e)
        {

        }
    }
}
