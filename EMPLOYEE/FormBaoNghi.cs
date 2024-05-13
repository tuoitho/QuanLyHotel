using Emgu.CV.ML;
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
    public partial class FormBaoNghi : Form
    {
        public FormBaoNghi()
        {
            InitializeComponent();
        }

        private void FormBaoNghi_Load(object sender, EventArgs e)
        {
            if (Info.role == "admin")
            {
                return;
            }
            int maNV = Info.id;
            DateTime ngay = DateTime.Now;
            dataGridView_cacuatoi.DataSource = EMP.getDSPhanCaByMyNV_Ngay(maNV, ngay);

        }

        private void roundedButton_baonghi_Click(object sender, EventArgs e)
        {
            if (dataGridView_cacuatoi.SelectedRows.Count == 0)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Vui lòng chọn ca làm để báo nghỉ", "Thông báo");
                customMessageBox.ShowDialog();
                return;
            }
            //neu k co row
            if (dataGridView_cacuatoi.Rows.Count == 0)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Không có ca làm nào để báo nghỉ", "Thông báo");
                customMessageBox.ShowDialog();
                return;
            }
            int maNV = Info.id;
            DateTime ngay = DateTime.Now;
            int maCa = Convert.ToInt32(dataGridView_cacuatoi.SelectedRows[0].Cells[0].Value);
            //ko the bao nghi ca thay the

            if (EMP.kiemtraCaThayThe(maCa))
            {
                MessageBox.Show("Không thể báo nghỉ ca thay thế", "Thông báo");
                return;
            }
            try
            {
                EMP.baoNghiCa(maNV, maCa);
                MessageBox.Show("Báo nghỉ thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Báo nghỉ thất bại", "Thông báo");
            }
        }
    }
}
