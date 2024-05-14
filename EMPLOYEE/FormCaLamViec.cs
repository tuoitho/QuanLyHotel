using Microsoft.Kiota.Abstractions;
using QuanLyHotel.EMPLOYEE;
using QuanLyHotel.THUETRA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyHotel.LamVieic
{
    public partial class FormCaLamViec : Form
    {
        public FormCaLamViec()
        {
            InitializeComponent();
            if (Info.role == "employee" && Info.chucvu == 1 || Info.role == "admin")
                linkLabel_showall.Enabled = true;
            else linkLabel_showall.Enabled = false;

        }
        private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
        private string kinhdo;
        private string vido;
        bool ondinh = false;
        void loadToado()
        {
            watcher = new GeoCoordinateWatcher();
            watcher.StatusChanged += Watcher_StatusChanged;
            watcher.Start();

        }
        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {


            try
            {
                if (e.Status == GeoPositionStatus.Ready)
                {
                    if (watcher.Position.Location.IsUnknown)
                    {
                        vido = "0";
                        kinhdo = "0";
                    }
                    else
                    {
                        vido = watcher.Position.Location.Latitude.ToString();
                        kinhdo = watcher.Position.Location.Longitude.ToString();
                        ondinh = true;
                    }
                }
                else
                {
                    vido = "0";
                    kinhdo = "0";
                }
            }
            catch (Exception ex)
            {
            }
            if (ondinh)
            {
                watcher.Stop();

                label_vd.Text = " Vĩ độ: " + vido;
                label_kd.Text = " Kinh độ: " + kinhdo;
                double lat = double.Parse(vido);
                double lon = double.Parse(kinhdo);
                double lat1 = 10.851362;
                double lon1 = 106.772571;

                double R = 6371;
                double dLat = (lat1 - lat) * (Math.PI / 180);
                double dLon = (lon1 - lon) * (Math.PI / 180);
                double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(lat * (Math.PI / 180)) * Math.Cos(lat1 * (Math.PI / 180)) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
                double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
                double distance = R * c;
                label_kc.Text = distance.ToString();

            }

        }
        bool kiemtrabankinh()
        {

            //o trong ban kinh 1km
            if (Convert.ToDouble(label_kc.Text) <= 1)
            {
                return true;

            }
            return false;
        }
        private void FormCaLamViec_Load(object sender, EventArgs e)
        {

            loadToado();
            dataGridView_calamviec.DataSource = EMP.getDSCa();
            textBox_tongnv.Text = EMP.getDSNhanVien().Rows.Count.ToString();
            textBox_tongql.Text = EMP.getDSNVQuanLy().Rows.Count.ToString();
            textBox_tongtt.Text = EMP.getDSNVTiepTan().Rows.Count.ToString();
            textBox_tonglc.Text = EMP.getDSNVLaoCong().Rows.Count.ToString();
            //format
            dataGridView_calamviec.Columns[3].DefaultCellStyle.Format = "HH:mm";
            dataGridView_calamviec.Columns[2].DefaultCellStyle.Format = "HH:mm";
            if (Info.role == "employee" && Info.chucvu != 1 || Info.role != "admin" && Info.role != "employee")
            {
                //hide tabpage
                tabControl.TabPages.Remove(tabPage_ca);

            }
            int mapchientai = EMP.getMaPCHienTaiByMaNV(Info.id);
            if (mapchientai == -1)
            {
                roundedButton_ci.Enabled = false;
                roundedButton_co.Enabled = false;
            }
            else
            {
                roundedButton_ci.Enabled = !EMP.kiemtracheckInPC(Info.id, mapchientai);
                roundedButton_co.Enabled = !EMP.kiemtracheckOutPC(Info.id, mapchientai);
            }

            //ko dc chọn 4 cột đầu
            for (int i = 0; i < dataGridView_calamviec.Columns.Count; i++)
            {
                if (i < 4)
                {
                    dataGridView_calamviec.Columns[i].ReadOnly = true;
                    dataGridView_calamviec.Columns[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
            DateTime date = dateTimePicker1.Value;
            DateTime giohientai = DateTime.Now;

            if (giohientai.Hour >= 0 && giohientai.Hour <= 6)
            {
                date = date.AddDays(-1);
            }
            DataTable tbCabosung = EMP.getAllDSCaBoSung(date);
            dataGridView_cabs.DataSource = tbCabosung;

        }

        private void reload()
        {

            if (Info.role == "employee")
            {
                int manv = Info.id;
                DateTime date = dateTimePicker1.Value;
                DataTable tb = EMP.getAllLichTheoNgayByMaNV_MaCa(date, manv, 1);
                dataGridView_c1.DataSource = tb;
                DataTable tb2 = EMP.getAllLichTheoNgayByMaNV_MaCa(date, manv, 2);
                dataGridView_c2.DataSource = tb2;
                //get ds bao nghi theo loại nhân viên của tôi
                int chucvu = Info.chucvu;
                DateTime giohientai = DateTime.Now;
                //neu sau 0h-6h thi lay ngay hom truoc
                if (giohientai.Hour >= 0 && giohientai.Hour <= 6)
                {
                    date = date.AddDays(-1);
                }

                DataTable tbBaonghi = EMP.getAllDSBaoNghi(date, chucvu);
                dataGridView_cabaonghi.DataSource = tbBaonghi;
                //DataTable tbCabosung=EMP.getAllDSCaBoSung(date, chucvu);
                DataTable tbCabosung = EMP.getAllDSCaBoSung(date);
                dataGridView_cabs.DataSource = tbCabosung;

            }
            if (Info.role == "admin")
            {
                DateTime date = dateTimePicker1.Value;
                DataTable tb = EMP.getAllLichTheoNgayByMaCa(date, 1);
                dataGridView_c1.DataSource = tb;
                DataTable tb2 = EMP.getAllLichTheoNgayByMaCa(date, 2);
                dataGridView_c2.DataSource = tb2;

                //get ds bao nghi cua all
                DateTime giohientai = DateTime.Now;
                //neu sau 0h-6h thi lay ngay hom truoc
                if (giohientai.Hour >= 0 && giohientai.Hour <= 6)
                {
                    date = date.AddDays(-1);
                }

                DataTable tbBaonghi = EMP.getAllDSBaoNghi(date);
                dataGridView_cabaonghi.DataSource = tbBaonghi;
                DataTable dscabs = EMP.getAllDSCaBoSung(date, Info.chucvu);
                dataGridView_cabs.DataSource = dscabs;
                dataGridView_cabs.Refresh();


            }
            int mapchientai = EMP.getMaPCHienTaiByMaNV(Info.id);
            if (mapchientai == -1)
            {
                roundedButton_ci.Enabled = false;
                roundedButton_co.Enabled = false;
            }
            else
            {
                roundedButton_ci.Enabled = !EMP.kiemtracheckInPC(Info.id, mapchientai);
                roundedButton_co.Enabled = !EMP.kiemtracheckOutPC(Info.id, mapchientai);
            }
            //hide column 3
            dataGridView_c1.Columns[3].Visible = false;
            dataGridView_c2.Columns[3].Visible = false;
            dataGridView_c1.Columns[0].HeaderText = "Mã Phân Ca";
            dataGridView_c2.Columns[0].HeaderText = "Mã Phân Ca";
            dataGridView_c1.Columns[1].HeaderText = dataGridView_c2.Columns[1].HeaderText = dataGridView_cabaonghi.Columns[1].HeaderText = "Mã Ca";
            dataGridView_c1.Columns[2].HeaderText = dataGridView_c2.Columns[2].HeaderText = dataGridView_cabaonghi.Columns[2].HeaderText = "Mã NV";
            dataGridView_c1.Columns[4].HeaderText = dataGridView_c2.Columns[4].HeaderText = dataGridView_cabaonghi.Columns[4].HeaderText = "Check in";
            dataGridView_c1.Columns[5].HeaderText = dataGridView_c2.Columns[5].HeaderText = dataGridView_cabaonghi.Columns[5].HeaderText = "Check out";
            dataGridView_c1.Columns[6].HeaderText = dataGridView_c2.Columns[6].HeaderText = dataGridView_cabaonghi.Columns[6].HeaderText = "Ghi Chú";
            dataGridView_c1.Columns[7].HeaderText = dataGridView_c2.Columns[7].HeaderText = dataGridView_cabaonghi.Columns[7].HeaderText = "Start";
            dataGridView_c1.Columns[8].HeaderText = dataGridView_c2.Columns[8].HeaderText = dataGridView_cabaonghi.Columns[8].HeaderText = "End";

        }
        int rowca1 = 1000000;
        int rowca2 = 1000000;
        int rowcabs = 1000000;
        int rowcanghi = 1000000;
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
            DateTime start = dateTimePicker_start.Value;

            PHANCA_CHINHTHUC pc = new PHANCA_CHINHTHUC(soquanly, sotieptan, solaocong, s1, s2, s3, c1, c2, c3, start);
            PHANCA_CHINHTHUC.ThucHien();
        }

        private void roundedButton_ok_Click(object sender, EventArgs e)
        {


        }

        private void tabControl2_Selecting(object sender, TabControlCancelEventArgs e)
        {


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

        private void roundedButton_ci_Click(object sender, EventArgs e)
        {
            if (Info.role != "employee") return;
            int manv = Info.id;
            int mapchientai = EMP.getMaPCHienTaiByMaNV(manv);
            if (mapchientai == -1)
            {
                MessageBox.Show("Bạn không có ca làm việc hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (!kiemtrabankinh())
                {
                    MessageBox.Show("Bạn không ở trong bán kính bàn việc 1km", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                EMP.checkInPC(manv, mapchientai);
                MessageBox.Show("Check in thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
            catch
            {
                MessageBox.Show("Check in thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void roundedButton_co_Click(object sender, EventArgs e)
        {
            if (Info.role != "employee") return;
            int manv = Info.id;
            int mapchientai = EMP.getMaPCHienTaiByMaNV(manv);
            if (mapchientai == -1)
            {
                MessageBox.Show("Bạn không có ca làm việc hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (!kiemtrabankinh())
                {
                    MessageBox.Show("Bạn không ở trong bán kính bàn việc 1km", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                EMP.checkOutPC(manv, mapchientai);
                MessageBox.Show("Check out thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
            catch
            {
                MessageBox.Show("Check out thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (Info.role == "employee")
            {
                int manv = Info.id;
                DateTime date = dateTimePicker1.Value;
                DataTable tb = EMP.getAllLichTheoNgayByMaNV_MaCa(date, manv, 1);
                dataGridView_c1.DataSource = tb;
                DataTable tb2 = EMP.getAllLichTheoNgayByMaNV_MaCa(date, manv, 2);
                dataGridView_c2.DataSource = tb2;


            }
            if (Info.role == "admin")
            {
                DateTime date = dateTimePicker1.Value;
                DataTable tb = EMP.getAllLichTheoNgayByMaCa(date, 1);
                dataGridView_c1.DataSource = tb;
                DataTable tb2 = EMP.getAllLichTheoNgayByMaCa(date, 2);
                dataGridView_c2.DataSource = tb2;


            }
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage_lich)
            {
                reload();
                int mapchientai = EMP.getMaPCHienTaiByMaNV(Info.id);
                if (mapchientai == -1)
                {
                    roundedButton_ci.Enabled = false;
                    roundedButton_co.Enabled = false;
                }
                else
                {
                    roundedButton_ci.Enabled = !EMP.kiemtracheckInPC(Info.id, mapchientai);
                    roundedButton_co.Enabled = !EMP.kiemtracheckOutPC(Info.id, mapchientai);
                }

            }
        }

        private void roundedButton_thaythe_Click(object sender, EventArgs e)
        {
            if (Info.role != "employee") return;
            if (dataGridView_cabaonghi.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn báo nghỉ cần thay thế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //int mapc = Convert.ToInt32(dataGridView_cabaonghi.CurrentRow.Cells[0].Value.ToString());
            int mapc = Convert.ToInt32(dataGridView_cabaonghi.Rows[rowcanghi].Cells[0].Value.ToString());

            int manv = Info.id;
            //neu bi trung lich thi k dc thay the
            if (EMP.kiemtraTrungLich(mapc, manv))
            {
                MessageBox.Show("Không thể thay thế ca báo nghỉ trùng lịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                EMP.thayThePhanCa(mapc, manv);
                MessageBox.Show("Thay thế thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thay thế thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void roundedButton_baonghi_Click(object sender, EventArgs e)
        {
            //bao nghi ca hien tai cuar toi
            //if (Info.role != "employee") return;
            //int manv = Info.id;
            //int mapchientai = EMP.getMaPCHienTaiByMaNV(manv);
            ////neu la ca thay the thi không được báo nghỉ
            //if (EMP.kiemtraCaThayThe(mapchientai))
            //{
            //    MessageBox.Show("Không thể báo nghỉ ca thay thế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //if (mapchientai == -1)
            //{
            //    MessageBox.Show("Bạn không có ca làm việc hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //try
            //{
            //    EMP.baoNghiCa(manv, mapchientai);
            //    MessageBox.Show("Báo nghỉ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch
            //{
            //    MessageBox.Show("Báo nghỉ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            FormBaoNghi formBaoNghi = new FormBaoNghi();
            formBaoNghi.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reload();
            if (dataGridView_c1.Rows.Count > rowca1)
            {
                dataGridView_c1.Rows[rowca1].Selected = true;
                //click vao dong rowca1


            }
            if (dataGridView_c2.Rows.Count > rowca2)
            {
                dataGridView_c2.Rows[rowca2].Selected = true;
            }
            if (dataGridView_cabaonghi.Rows.Count > rowcanghi)
            {
                dataGridView_cabaonghi.Rows[rowcanghi].Selected = true;
            }
            if (dataGridView_cabs.Rows.Count > rowcabs)
            {
                dataGridView_cabs.Rows[rowcabs].Selected = true;
                //ckicj vao dong rowcabs
            }
        }

        private void button_xembc_Click(object sender, EventArgs e)
        {
            FormBaoCaoNgay formBaoCaoNgay = new FormBaoCaoNgay();
            formBaoCaoNgay.ShowDialog();
        }



        private void dataGridView_c2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView_c1_Click(object sender, EventArgs e)
        {
            //neu click vao khoang trong
            if (dataGridView_c1.CurrentRow == null)
            {
                return;
            }
            rowca1 = dataGridView_c1.CurrentRow.Index;
        }
        private void dataGridView_c2_Click(object sender, EventArgs e)
        {
            //neu click vao khoang trong
            if (dataGridView_c2.CurrentRow == null)
            {
                return;
            }
            rowca2 = dataGridView_c2.CurrentRow.Index;
        }

        private void dataGridView_cabaonghi_Click(object sender, EventArgs e)
        {
            //neu click vao khoang trong
            if (dataGridView_cabaonghi.CurrentRow == null)
            {
                return;
            }
            rowcanghi = dataGridView_cabaonghi.CurrentRow.Index;
        }

        private void tabPage_lich_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            FormDiemDanhKhuonMat formDiemDanhKhuonMat = new FormDiemDanhKhuonMat();
            formDiemDanhKhuonMat.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormThemCaBoSung formThemCaBoSung = new FormThemCaBoSung();
            formThemCaBoSung.ShowDialog();
        }

        private void roundedButton_dangky_Click(object sender, EventArgs e)
        {
            if (dataGridView_cabs.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn ca bổ sung để đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int mapc = Convert.ToInt32(dataGridView_cabs.Rows[rowcabs].Cells[0].Value.ToString());
            int manv = Info.id;
            int machucvu = Info.chucvu;
            //neu ko cùng loại nhân viên thì ko cho đăng ký
            string ssghichu = "";
            if (machucvu == 2)
            {
                ssghichu = "Ca bổ sung tiếp tân";
            }
            else if (machucvu == 3)
            {
                ssghichu = "Ca bổ sung lao công";
            }
            if (ssghichu != dataGridView_cabs.Rows[rowcabs].Cells[6].Value.ToString())
            {
                MessageBox.Show("Không thể đăng ký vì bạn không phải loại nhân viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //neu bi trung lich thi k dc thay the
            if (EMP.kiemtraTrungLich(mapc, manv))
            {
                MessageBox.Show("Không thể đăng kí vì bạn bị trùng lịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                EMP.dangKyCaBoSung(mapc, manv);
                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLabel_showall_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataGridView_cabs_Click(object sender, EventArgs e)
        {
            //neu click vao khoang trong
            if (dataGridView_cabs.CurrentRow == null)
            {
                return;
            }
            rowcabs = dataGridView_cabs.CurrentRow.Index;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage_lich)
            {
                timer1.Start();


            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
