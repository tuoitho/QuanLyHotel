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
    public partial class FormCaLamViecNhanVienDuoiCap : Form
    {

        public FormCaLamViecNhanVienDuoiCap()
        {
            InitializeComponent();
        }



        private void FormCaLamViecNhanVienDuoiCap_Load(object sender, EventArgs e)
        {

            DateTime date = dateTimePicker1.Value;
            DataTable tb = EMP.getAllLichTheoNgayByMaCa(date, 1);
            dataGridView_c1.DataSource = tb;
            DataTable tb2 = EMP.getAllLichTheoNgayByMaCa(date, 2);
            dataGridView_c2.DataSource = tb2;


            dataGridView_c1.Columns[3].Visible = false;
            dataGridView_c2.Columns[3].Visible = false;
            dataGridView_c1.Columns[0].HeaderText = dataGridView_c2.Columns[0].HeaderText = "Mã PC";
            dataGridView_c1.Columns[1].HeaderText = dataGridView_c2.Columns[1].HeaderText = "Mã Ca";
            dataGridView_c1.Columns[2].HeaderText = dataGridView_c2.Columns[2].HeaderText = "Mã NV";
            dataGridView_c1.Columns[4].HeaderText = dataGridView_c2.Columns[4].HeaderText = "Check in";
            dataGridView_c1.Columns[5].HeaderText = dataGridView_c2.Columns[5].HeaderText = "Check out";
            dataGridView_c1.Columns[6].HeaderText = dataGridView_c2.Columns[6].HeaderText = "Ghi Chú";
            dataGridView_c1.Columns[7].HeaderText = dataGridView_c2.Columns[7].HeaderText = "Start";
            dataGridView_c1.Columns[8].HeaderText = dataGridView_c2.Columns[8].HeaderText = "End";
            //ko chon dong nao
            dataGridView_c1.ClearSelection();
            dataGridView_c2.ClearSelection();

        }

        private void roundedButton_baonghi_Click(object sender, EventArgs e)
        {
            if (Info.role == "admin")
            {

                int mapc = 0;
                int manv = 0;
                if (dataGridView_c1.SelectedRows.Count > 0)
                {
                    //DataGridViewRow row = dataGridView_c1.SelectedRows[0];
                    //int id = Convert.ToInt32(row.Cells[0].Value);
                    //int maCa = Convert.ToInt32(row.Cells[1].Value);
                    //EMP.baoNghiCa(id, maCa);
                    mapc = Convert.ToInt32(dataGridView_c1.SelectedRows[0].Cells[0].Value);
                    manv = Convert.ToInt32(dataGridView_c1.SelectedRows[0].Cells[2].Value);
                }
                else if (dataGridView_c2.SelectedRows.Count > 0)
                {
                    //DataGridViewRow row = dataGridView_c2.SelectedRows[0];
                    //int id = Convert.ToInt32(row.Cells[0].Value);
                    //int maCa = Convert.ToInt32(row.Cells[1].Value);
                    //EMP.baoNghiCa(id, maCa);
                    mapc = Convert.ToInt32(dataGridView_c2.SelectedRows[0].Cells[0].Value);
                    manv = Convert.ToInt32(dataGridView_c2.SelectedRows[0].Cells[2].Value);
                }
                else
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Vui lòng chọn ca làm để báo nghỉ", "Thông báo");
                    customMessageBox.ShowDialog();
                    return;
                }
                //MessageBox.Show(mapc+" "+ manv);
                try
                {
                    EMP.baoNghiCa(manv, mapc);
                    MessageBox.Show("Báo nghỉ thành công cho nhân viên", "Thông báo");
                    DateTime date = dateTimePicker1.Value;
                    DataTable tb = EMP.getAllLichTheoNgayByMaCa(date, 1);
                    dataGridView_c1.DataSource = tb;
                    DataTable tb2 = EMP.getAllLichTheoNgayByMaCa(date, 2);
                    dataGridView_c2.DataSource = tb2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                int mapc = 0;
                int manv = 0;
                if (dataGridView_c1.SelectedRows.Count > 0)
                {
                    //DataGridViewRow row = dataGridView_c1.SelectedRows[0];
                    //int id = Convert.ToInt32(row.Cells[0].Value);
                    //int maCa = Convert.ToInt32(row.Cells[1].Value);
                    //EMP.baoNghiCa(id, maCa);
                    mapc = Convert.ToInt32(dataGridView_c1.SelectedRows[0].Cells[0].Value);
                    manv = Convert.ToInt32(dataGridView_c1.SelectedRows[0].Cells[2].Value);
                }
                else if (dataGridView_c2.SelectedRows.Count > 0)
                {
                    //DataGridViewRow row = dataGridView_c2.SelectedRows[0];
                    //int id = Convert.ToInt32(row.Cells[0].Value);
                    //int maCa = Convert.ToInt32(row.Cells[1].Value);
                    //EMP.baoNghiCa(id, maCa);
                    mapc = Convert.ToInt32(dataGridView_c2.SelectedRows[0].Cells[0].Value);
                    manv = Convert.ToInt32(dataGridView_c2.SelectedRows[0].Cells[2].Value);
                }
                else
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Vui lòng chọn ca làm để báo nghỉ", "Thông báo");
                    customMessageBox.ShowDialog();
                    return;
                }
                //MessageBox.Show(mapc+" "+ manv);
                //kiem tra ma nhan vien co do minh quan ly ko
                if (EMP.kiemTraThuocQuyenQuanLy(Info.id, manv) == false)
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Không thể báo nghỉ cho nhân viên không do mình quản lý", "Thông báo");
                    customMessageBox.ShowDialog();
                    return;
                }
                try
                {
                    EMP.baoNghiCa(manv, mapc);
                    MessageBox.Show("Báo nghỉ thành công cho nhân viên", "Thông báo");
                    DateTime date = dateTimePicker1.Value;
                    DataTable tb = EMP.getAllLichTheoNgayByMaCa(date, 1);
                    dataGridView_c1.DataSource = tb;
                    DataTable tb2 = EMP.getAllLichTheoNgayByMaCa(date, 2);
                    dataGridView_c2.DataSource = tb2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView_c1_Click(object sender, EventArgs e)
        {
            dataGridView_c2.ClearSelection();
        }

        private void dataGridView_c2_Click(object sender, EventArgs e)
        {
            dataGridView_c1.ClearSelection();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            DataTable tb = EMP.getAllLichTheoNgayByMaCa(date, 1);
            dataGridView_c1.DataSource = tb;
            DataTable tb2 = EMP.getAllLichTheoNgayByMaCa(date, 2);
            dataGridView_c2.DataSource = tb2;
        }
    }
}
