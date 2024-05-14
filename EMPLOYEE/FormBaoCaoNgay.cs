using Newtonsoft.Json.Bson;
using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.EMPLOYEE
{
    public partial class FormBaoCaoNgay : Form
    {
        List<int> listMaNVTT = new List<int>();
        List<int> listMaNVLC = new List<int>();
        Dictionary<int, int> sogiolamviec;

        public FormBaoCaoNgay()
        {
            InitializeComponent();

        }

        private void FormBaoCaoNgay_Load(object sender, EventArgs e)
        {
            if (EMP.isDaTinhToanLuong(DateTime.Now.AddDays(-1)))
            {
                //MessageBox.Show("Đã tính toán lương cho ngày hôm qua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_baocao.DataSource = EMP.getDSLuongNgayTheoNgay();
                EMP.xoaLuongNgay(DateTime.Now.AddDays(-1));
                
                //return;
            }
            //MessageBox.Show("Đang tính toán lương cho ngày hôm qua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DateTime dateTime = DateTime.Now.AddDays(-1);
            //sogiolamviec = EMP.getDictSoGioLamViecTheoNgay(dateTime);
            sogiolamviec = EMP.getDictSoGioLamViecCaChinh_CaBoSungTheoNgay(dateTime);
            //MessageBox.Show(sogiolamviec.Count.ToString());
            DataTable dsTT = EMP.getDSNVTiepTan();
            foreach (DataRow row in dsTT.Rows)
            {
                listMaNVTT.Add(Convert.ToInt32(row["MaNV"]));
            }
            DataTable dsLC = EMP.getDSNVLaoCong();
            foreach (DataRow row in dsLC.Rows)
            {
                listMaNVLC.Add(Convert.ToInt32(row["MaNV"]));
            }

            foreach(int x in listMaNVTT)
            {
                double luongcachinh = 0, tienphatcachinh = 0;
                if (sogiolamviec.ContainsKey(x))
                {
                    luongcachinh = sogiolamviec[x] * 60000;
                    if (sogiolamviec[x] < 8)
                    {
                        tienphatcachinh = (sogiolamviec[x] - 8) * 120000;
                    }
                    DateTime date = DateTime.Now.AddDays(-1);
                    int manv = x;
                    EMP.insertHinhPhat(manv, date, tienphatcachinh);
                    EMP.capnhattienthuongphat(manv, date);
                    double tienphat = EMP.getTienThuongPhat(manv, date);
                    double luongnv = luongcachinh + tienphat;
                    EMP.insertLuongNV(manv, date, luongnv);
                }
            }

            foreach (int x in listMaNVLC)
            {
                double luongcachinh = 0,tienphatcachinh=0;
                if (sogiolamviec.ContainsKey(x))
                {
                    luongcachinh = sogiolamviec[x] * 40000;
                    if (sogiolamviec[x] < 8)
                    {
                        tienphatcachinh = (sogiolamviec[x]-8) * 80000;
                    }
                    DateTime date= DateTime.Now.AddDays(-1);
                    int manv = x;
                    EMP.insertHinhPhat(manv, date, tienphatcachinh);
                    EMP.capnhattienthuongphat(manv, date);
                    double tienphat = EMP.getTienThuongPhat(manv, date);
                    double luongnv = luongcachinh + tienphat;
                    EMP.insertLuongNV(manv, date, luongnv);
                }

            }

            dataGridView_baocao.DataSource = EMP.getDSLuongNgayTheoNgay();
        }

        private void dataGridView_baocao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int manv = Convert.ToInt32(dataGridView_baocao.CurrentRow.Cells[0].Value);
            DateTime ngay = Convert.ToDateTime(dataGridView_baocao.CurrentRow.Cells[2].Value);
            dataGridView_chitietca.DataSource= EMP.getDSChiTietCaDaLam(manv,ngay);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable bangluong = new DataTable();
            bangluong.Columns.Add("MaNV", typeof(int));
            bangluong.Columns.Add("HoTen", typeof(string));
            bangluong.Columns.Add("Ngay", typeof(DateTime));
            bangluong.Columns.Add("Luong", typeof(double));

            //MyDB myDB = new MyDB();
            //myDB.OpenConnection();
            //using (SqlCommand cmd = new SqlCommand("SELECT Luong.MaNV,Nhanvien.hoten FROM Luong join nhanvien on Luong.MaNV=Nhanvien.MaNV WHERE Ngay=@ngay", myDB.GetConnection))
            //{
            //    cmd.Parameters.AddWithValue("@ngay", DateTime.Now.AddDays(-1));
            //    using (SqlDataReader reader = cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            bangluong.Rows.Add(reader.GetInt32(0), reader.GetString(1));
            //        }
            //    }
            //}
            //myDB.CloseConnection();
            //lấy từ datagridview
            foreach (DataGridViewRow row in dataGridView_baocao.Rows)
            {
                bangluong.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value);
            }
            FormInBangLuong formInBangLuong = new FormInBangLuong(bangluong);
            formInBangLuong.ShowDialog();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_baocao_Click(object sender, EventArgs e)
        {

        }
    }
}
