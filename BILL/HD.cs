using QuanLyHotel.Resources;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyHotel.BILL
{
    internal class HD
    {
        static MyDB mydb = new MyDB();
        internal static DataTable getDSHoaDonKH(string inp)
        {
            //tim theo ma hoa don, ma khach hang, ten khach hang
            string query = "select * from HoaDon join KhachHang on HoaDon.makh=KhachHang.makh where concat(HoaDon.makh, hoten, cccd,sdt) like @inp";
            {
                SqlCommand command = new SqlCommand(query, mydb.GetConnection);
                command.Parameters.Add("@inp", SqlDbType.NVarChar).Value = "%" + inp + "%";
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        public static DataTable TimKiemHoaDon(int makh)
        {
            string query = "select * from HoaDon where makh=@makh";
            {
                SqlCommand command = new SqlCommand(query, mydb.GetConnection);
                command.Parameters.Add("@makh", SqlDbType.Int).Value = makh;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        internal static string getStatus(int mahoadon)
        {
            using (SqlCommand cmd = new SqlCommand("select TrangThai from HoaDon where MaHoaDon=@mahd", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mahd", SqlDbType.Int).Value = mahoadon;
                mydb.OpenConnection();
                string trangthai = cmd.ExecuteScalar().ToString();
                mydb.CloseConnection();
                return trangthai;
            }
        }
    }
}