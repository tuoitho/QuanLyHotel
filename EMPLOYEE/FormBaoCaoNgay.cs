using Newtonsoft.Json.Bson;
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
                MessageBox.Show("Đã tính toán lương cho ngày hôm qua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_baocao.DataSource = EMP.getDSLuongNgayTheoNgay();
                return;
            }
            MessageBox.Show("Đang tính toán lương cho ngày hôm qua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DateTime dateTime = DateTime.Now.AddDays(-1);
            //sogiolamviec = EMP.getDictSoGioLamViecTheoNgay(dateTime);
            sogiolamviec = EMP.getDictSoGioLamViecCaChinhTheoNgay(dateTime);
            MessageBox.Show(sogiolamviec.Count.ToString());
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
    }
}
