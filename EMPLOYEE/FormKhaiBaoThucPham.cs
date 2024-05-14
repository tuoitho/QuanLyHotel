using QuanLyHotel.THUETRA;
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
    public partial class FormKhaiBaoThucPham : Form
    {
        public FormKhaiBaoThucPham()
        {
            InitializeComponent();
        }

        private void FormKhaiBaoThucPham_Load(object sender, EventArgs e)
        {
            dataGridView_phongdenhan.DataSource = TT.getDSPhongCanKhaiBao();
        }

        private void dataGridView_phongdenhan_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_phongdenhan.Rows.Count == 0) return;
            int mahd = Convert.ToInt32(dataGridView_phongdenhan.CurrentRow.Cells[0].Value.ToString());
            int maphong = Convert.ToInt32(dataGridView_phongdenhan.CurrentRow.Cells[1].Value.ToString());
            FormKhaiBaoThucPhamDialog f = new FormKhaiBaoThucPhamDialog(mahd,maphong);
            f.ShowDialog();
        }
    }
}
