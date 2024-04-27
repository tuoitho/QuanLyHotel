using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.BILL
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            
            string inp= textBox_inputkhachhang.Text;
            dataGridView_hoadon.DataSource = HD.getDSHoaDonKH(inp);

        }
    }
}
