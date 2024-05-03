using Microsoft.Kiota.Abstractions;
using QuanLyHotel.EMPLOYEE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.FileDialogs;

namespace QuanLyHotel.LamVieic
{
    public partial class FormCaLamViec : Form
    {
        public FormCaLamViec()
        {
            InitializeComponent();
        }

        private void FormCaLamViec_Load(object sender, EventArgs e)
        {
            dataGridView_calamviec.DataSource = EMP.getDSCa();
            textBox_tongnv.Text = EMP.getDSNhanVien().Rows.Count.ToString();
            textBox_tongql.Text = EMP.getDSNVQuanLy().Rows.Count.ToString();
            textBox_tongtt.Text = EMP.getDSNVTiepTan().Rows.Count.ToString();
            textBox_tonglc.Text = EMP.getDSNVLaoCong().Rows.Count.ToString();
            //format
            dataGridView_calamviec.Columns[3].DefaultCellStyle.Format = "HH:mm";
            dataGridView_calamviec.Columns[2].DefaultCellStyle.Format = "HH:mm";
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_pc_Click(object sender, EventArgs e)
        {
            DataTable ca = EMP.getDSCa();
            int soquanly = EMP.getDSNVQuanLy().Rows.Count;
            int sotieptan = EMP.getDSNVTiepTan().Rows.Count;
            int solaocong = EMP.getDSNVLaoCong().Rows.Count;
            int s1 = Convert.ToInt32(ca.Rows[0][4].ToString());
            int s2 = Convert.ToInt32(ca.Rows[0][5].ToString());
            int s3 = Convert.ToInt32(ca.Rows[0][6].ToString());
            int c1 = Convert.ToInt32(ca.Rows[1][4].ToString());
            int c2 = Convert.ToInt32(ca.Rows[1][5].ToString());
            int c3 = Convert.ToInt32(ca.Rows[1][6].ToString());
            int sotuan = Convert.ToInt32(numericUpDown_sotuan.Value);
            DateTime start= dateTimePicker_start.Value;
            PhanCaCongBang phanCa = new PhanCaCongBang(soquanly, sotieptan, solaocong, s1, s2, s3, c1, c2, c3, start,sotuan);
            PhanCaCongBang.ThucHien();
        }

        private void roundedButton_ok_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            DataTable tb = EMP.getAllLichTheoNgay(date);
            dataGridView_lich.DataSource = tb;
        }

        private void tabControl2_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {

            }
        }

        private void roundedButton_chinhsua_Click(object sender, EventArgs e)
        {
            int tongql = Convert.ToInt32(textBox_tongql.Text);
            int tongtt = Convert.ToInt32(textBox_tongtt.Text);
            int tonglc = Convert.ToInt32(textBox_tonglc.Text);
            int tongqltrongngay = 0, tongsotttrongngay = 0, tongsolctrongngay = 0;
            for (int i = 0; i < dataGridView_calamviec.Rows.Count; i++)
            {
                if (dataGridView_calamviec.Rows[i].Cells[4].Value == null || dataGridView_calamviec.Rows[i].Cells[5].Value == null || dataGridView_calamviec.Rows[i].Cells[6].Value == null)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                    return;
                }
                if (Convert.ToInt32(dataGridView_calamviec.Rows[i].Cells[4].Value.ToString()) < 0 || Convert.ToInt32(dataGridView_calamviec.Rows[i].Cells[5].Value.ToString()) < 0 || Convert.ToInt32(dataGridView_calamviec.Rows[i].Cells[6].Value.ToString()) < 0)
                {
                    MessageBox.Show("Số lượng không được âm");
                    return;
                }
                if (Convert.ToInt32(dataGridView_calamviec.Rows[i].Cells[4].Value.ToString()) > tongql || Convert.ToInt32(dataGridView_calamviec.Rows[i].Cells[5].Value.ToString()) > tongtt || Convert.ToInt32(dataGridView_calamviec.Rows[i].Cells[6].Value.ToString()) > tonglc)
                {
                    MessageBox.Show("Số lượng trong 1 ca không được lớn hơn số lượng nhân viên trong hệ thống");
                    return;
                }
                tongqltrongngay += Convert.ToInt32(dataGridView_calamviec.Rows[i].Cells[4].Value.ToString());
                tongsotttrongngay += Convert.ToInt32(dataGridView_calamviec.Rows[i].Cells[5].Value.ToString());
                tongsolctrongngay += Convert.ToInt32(dataGridView_calamviec.Rows[i].Cells[6].Value.ToString());
            }
            if (tongqltrongngay < tongql)
            {
                MessageBox.Show(tongqltrongngay.ToString());
                MessageBox.Show("Số lượng quản lý trong ngày phải lớn hơn hoặc bằng số lượng quản lý trong hệ thống");
                return;
            }
            if (tongsotttrongngay < tongtt)
            {
                MessageBox.Show("Số lượng tiếp tân trong ngày phải lớn hơn hoặc bằng số lượng tiếp tân trong hệ thống");
                return;

            }
            if (tongsolctrongngay < tonglc)
            {
                MessageBox.Show("Số lượng lao công trong ngày phải lớn hơn hoặc bằng số lượng lao công trong hệ thống");
                return;

            }

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("maca", typeof(int));
            dataTable.Columns.Add("ql", typeof(int));
            dataTable.Columns.Add("tt", typeof(int));
            dataTable.Columns.Add("lc", typeof(int));
            for (int i = 0; i < dataGridView_calamviec.Rows.Count; i++)
            {
                DataRow row = dataTable.NewRow();
                row["maca"] = Convert.ToInt32(dataGridView_calamviec.Rows[i].Cells[0].Value.ToString());
                row["ql"] = Convert.ToInt32(dataGridView_calamviec.Rows[i].Cells[4].Value.ToString());
                row["tt"] = Convert.ToInt32(dataGridView_calamviec.Rows[i].Cells[5].Value.ToString());
                row["lc"] = Convert.ToInt32(dataGridView_calamviec.Rows[i].Cells[6].Value.ToString());
                dataTable.Rows.Add(row);

            }
            try
            {
                EMP.updateCa(dataTable);
                MessageBox.Show("Cập nhật thành công");
                dataGridView_calamviec.DataSource = EMP.getDSCa();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
