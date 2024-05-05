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
        void apdunghinhphat()
        {
            //so gio lam viec cua nhan vien tiep tan
            foreach (int manv in listMaNVTT)
            {
                if (sogiolamviec.ContainsKey(manv))
                {
                    DateTime dateTime = DateTime.Now.AddDays(-1);
                    EMP.insertHinhPhat(manv, dateTime, (sogiolamviec[manv] - 8) * 120000);
                }
            }

        }
        public FormBaoCaoNgay()
        {
            InitializeComponent();
            DateTime dateTime = DateTime.Now.AddDays(-1);
            sogiolamviec = EMP.getDictSoGioLamViecTheoNgay(dateTime);
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

            Dictionary<int, double> luong = new Dictionary<int, double>();
            DataTable luongngay = EMP.getDSLuongNgayTheoMaNVTT_Ngay();
            foreach (DataRow row in luongngay.Rows)
            {
                int manv = Convert.ToInt32(row["MaNV"]);
                DateTime ngay = Convert.ToDateTime(row["Ngay"]);
                double tienluong = 0;
                if (row["LuongNgay"] != DBNull.Value)
                {
                    tienluong = Convert.ToDouble(row["LuongNgay"]);
                }
                double tienphat = 0;
                if (sogiolamviec.ContainsKey(manv))
                {
                    tienphat = (sogiolamviec[manv] - 8) * 120000;
                }

                double luongnv = tienluong + tienphat;
                MessageBox.Show("MaNV: " + manv + " - Ngay: " + ngay + " - Luong: " + tienluong+" " +tienphat + "luong ngay" + luongnv);
                luong.Add(manv, luongnv);
                EMP.insertLuongNV(manv, ngay, luongnv);

            }
        }

        private void FormBaoCaoNgay_Load(object sender, EventArgs e)
        {

        }

    }
}
