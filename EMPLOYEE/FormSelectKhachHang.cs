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
    public partial class FormSelectKhachHang : Form
    {
        public FormSelectKhachHang()
        {
            InitializeComponent();
        }

        private void FormSelectKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView_kh.DefaultCellStyle.SelectionBackColor = Color.Purple;
            dataGridView_kh.AllowUserToAddRows = false;
            //dataGridView_kh.DataSource = KH.getDSKhachHang();

        }
    }
}
