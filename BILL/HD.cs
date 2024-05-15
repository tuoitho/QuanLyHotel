using QuanLyHotel.PHONG;
using QuanLyHotel.Resources;
using QuanLyHotel.THUETRA;
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
            string query = "select HoaDon.* from HoaDon join KhachHang on HoaDon.makh=KhachHang.makh where concat(HoaDon.makh, hoten, cccd,sdt) like @inp";
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

        internal static string getTrangThaiHDByMaKH(int v)
        {
            using (SqlCommand cmd = new SqlCommand("select TrangThai from HoaDon where MaKH=@makh", mydb.GetConnection))
            {
                cmd.Parameters.Add("@makh", SqlDbType.Int).Value = v;
                mydb.OpenConnection();
                string trangthai = cmd.ExecuteScalar().ToString();
                mydb.CloseConnection();
                return trangthai;
            }
        }

        internal static DataTable getDSHoaDonByMaKH(int makh)
        {
            using (SqlCommand cmd = new SqlCommand("select * from HoaDon where MaKH=@makh", mydb.GetConnection))
            {
                cmd.Parameters.Add("@makh", SqlDbType.Int).Value = makh;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        internal static void insertKhaiBao(int mahd, int v1, int sl2, bool v2,int maphong)
        {
            using (SqlCommand cmd = new SqlCommand("insert into KhaiBaoThucPham values(@mahd,@matp,@soluong,@isLaoCong)", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mahd", SqlDbType.Int).Value = mahd;
                cmd.Parameters.Add("@matp", SqlDbType.Int).Value = v1;
                cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = sl2;
                cmd.Parameters.Add("@isLaoCong", SqlDbType.Bit).Value = v2;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
            //dong thoi giam so luong thuc pham trong phong tung ung
            using (SqlCommand cmd = new SqlCommand("  update Phong_SoLuongThucPham set SoLuong =SoLuong- @sl where MaPhong = @maph and MaTP = @matp", mydb.GetConnection))
            {
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = sl2;
                cmd.Parameters.Add("@maph", SqlDbType.Int).Value = maphong;
                cmd.Parameters.Add("@matp", SqlDbType.Int).Value = v1;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }
        internal static void insertKhaiBao(int mahd, int v1, int sl2, bool v2)
        {
            using (SqlCommand cmd = new SqlCommand("insert into KhaiBaoThucPham values(@mahd,@matp,@soluong,@isLaoCong)", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mahd", SqlDbType.Int).Value = mahd;
                cmd.Parameters.Add("@matp", SqlDbType.Int).Value = v1;
                cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = sl2;
                cmd.Parameters.Add("@isLaoCong", SqlDbType.Bit).Value = v2;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
            
        }

        internal static bool checkLaoCongDaKBThucPham(int mahd)
        {
            SqlCommand sqlCommand = new SqlCommand("select Count(*) from KHAIBAOTHUCPHAM where KHAIBAOTHUCPHAM.mahd=@mahd and isLaocong=1", mydb.GetConnection);
            mydb.OpenConnection();
            sqlCommand.Parameters.Add("@mahd", SqlDbType.Int).Value = mahd;
            int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
            mydb.CloseConnection();
            return count > 0;

        }

        internal static int getMaNVLCPhuTrachByMaHD(int mahd)
        {
            using (SqlCommand cmd = new SqlCommand("select MaNV from [PhanCongPhong] where maHD=@mahd", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mahd", SqlDbType.Int).Value = mahd;
                mydb.OpenConnection();
                int manv = Convert.ToInt32(cmd.ExecuteScalar());
                mydb.CloseConnection();
                return manv;
            }

        }
    }
}