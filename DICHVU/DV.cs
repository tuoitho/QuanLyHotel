using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHotel.DICHVU
{
    public class DV
    {
        static MyDB mydb = new MyDB();
        public static DataTable getDSDichVu()
        {
            using (SqlCommand cmd = new SqlCommand("select * from DichVu", mydb.GetConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                mydb.OpenConnection();
                adapter.Fill(table);
                mydb.CloseConnection();
                return table;
            }
        }

        public static DataTable getDSLoaiDichVu()
        {
            using (SqlCommand cmd = new SqlCommand("select * from LoaiDichVu", mydb.GetConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                mydb.OpenConnection();
                adapter.Fill(table);
                mydb.CloseConnection();
                return table;
            }
        }

        public static DataTable getDSDichVu(int text)
        {
            using (SqlCommand cmd = new SqlCommand("select * from DichVu where MaLDV=@maldv", mydb.GetConnection))
            {
                cmd.Parameters.Add("@maldv", SqlDbType.Int).Value = text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                mydb.OpenConnection();
                adapter.Fill(table);
                mydb.CloseConnection();
                return table;
            }
        }

        public static double getGiaDV(int madv)
        {
            using (SqlCommand cmd = new SqlCommand("select GiaDV from DichVu where MaDV=@madv", mydb.GetConnection))
            {
                cmd.Parameters.Add("@madv", SqlDbType.Int).Value = madv;
                mydb.OpenConnection();
                double gia = Convert.ToDouble(cmd.ExecuteScalar());
                mydb.CloseConnection();
                return gia;
            }
        }

        public static void themChiTietHDDV(int madv, int mhd, int sl, double gia)
        {
            //kiem tra xem dich vu da co trong hoa don chua, neu co thi tang so luong, neu chua thi them moi
            SqlCommand cmd = new SqlCommand("select count(*) from ChiTietHoaDonDichVu where MaHoaDon=@mhd and MaDichVu=@madv", mydb.GetConnection);
            cmd.Parameters.Add("@mhd", SqlDbType.Int).Value = mhd;
            cmd.Parameters.Add("@madv", SqlDbType.Int).Value = madv;
            mydb.OpenConnection();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
            {
                cmd = new SqlCommand("insert into ChiTietHoaDonDichVu(MaHoaDon,MaDichVu,SoLuong,Gia) values (@mhd,@madv,@sl,@gia)", mydb.GetConnection);
                cmd.Parameters.Add("@mhd", SqlDbType.Int).Value = mhd;
                cmd.Parameters.Add("@madv", SqlDbType.Int).Value = madv;
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = sl;
                cmd.Parameters.Add("@gia", SqlDbType.Money).Value = gia;
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SqlCommand("update ChiTietHoaDonDichVu set SoLuong=SoLuong+@sl where MaHoaDon=@mhd and MaDichVu=@madv", mydb.GetConnection);
                cmd.Parameters.Add("@mhd", SqlDbType.Int).Value = mhd;
                cmd.Parameters.Add("@madv", SqlDbType.Int).Value = madv;
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = sl;
                cmd.ExecuteNonQuery();
            }
            mydb.CloseConnection();


        }

        public static DataTable getDSDichVuByMaHD(int mhd)
        {
            using (SqlCommand cmd = new SqlCommand("select MaDichVu as [Mã Dịch Vụ],TenDV [Tên DV],SoLuong SL,Gia as [Tổng Tiền DV] from ChiTietHoaDonDichVu ct left join DichVu dv on ct.MaDichVu=dv.MaDV where MaHoaDon=@mhd", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mhd", SqlDbType.Int).Value = mhd;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                mydb.OpenConnection();
                adapter.Fill(table);
                mydb.CloseConnection();
                return table;
            }
        }

        internal static void themLDV(string tenDichVu)
        {
            using (SqlCommand cmd = new SqlCommand("insert into LoaiDichVu(TenLDV) values (@tenldv)", mydb.GetConnection))
            {
                cmd.Parameters.Add("@tenldv", SqlDbType.NVarChar).Value = tenDichVu;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static string getTenLDVByMDV(int v)
        {
            using (SqlCommand cmd = new SqlCommand("select TenLDV from LoaiDichVu where MaLDV=@madv", mydb.GetConnection))
            {
                cmd.Parameters.Add("@madv", SqlDbType.Int).Value = v;
                mydb.OpenConnection();
                string ten = cmd.ExecuteScalar().ToString();
                mydb.CloseConnection();
                return ten;
            }
        }

        internal static void suaLDV(int maLDV, string tenDichVu)
        {
            using (SqlCommand cmd = new SqlCommand("update LoaiDichVu set TenLDV=@tenldv where MaLDV=@maldv", mydb.GetConnection))
            {
                cmd.Parameters.Add("@tenldv", SqlDbType.NVarChar).Value = tenDichVu;
                cmd.Parameters.Add("@maldv", SqlDbType.Int).Value = maLDV;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static DataTable getDVByMaDV(int v)
        {
            using (SqlCommand cmd = new SqlCommand("select * from DichVu where MaDV=@madv", mydb.GetConnection))
            {
                cmd.Parameters.Add("@madv", SqlDbType.Int).Value = v;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                mydb.OpenConnection();
                adapter.Fill(table);
                mydb.CloseConnection();
                return table;
            }
        }

        internal static void themDV(string tenDV, int giaDV, int maLDV)
        {
           using (SqlCommand cmd = new SqlCommand("insert into DichVu(TenDV,GiaDV,MaLDV) values (@tendv,@giadv,@maldv)", mydb.GetConnection))
            {
                cmd.Parameters.Add("@tendv", SqlDbType.NVarChar).Value = tenDV;
                cmd.Parameters.Add("@giadv", SqlDbType.Int).Value = giaDV;
                cmd.Parameters.Add("@maldv", SqlDbType.Int).Value = maLDV;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static void suaDV(int maDV, string tenDV, double giaDV)
        {
            using (SqlCommand cmd = new SqlCommand("update DichVu set TenDV=@tendv,GiaDV=@giadv where MaDV=@madv", mydb.GetConnection))
            {
                cmd.Parameters.Add("@tendv", SqlDbType.NVarChar).Value = tenDV;
                cmd.Parameters.Add("@giadv", SqlDbType.Float).Value = giaDV;
                cmd.Parameters.Add("@madv", SqlDbType.Int).Value = maDV;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static int getSLThucPhamTonKho(int v)
        {
            using (SqlCommand cmd = new SqlCommand("select tonkho from thucpham where matp=@matp", mydb.GetConnection))
            {
                cmd.Parameters.Add("@matp", SqlDbType.Int).Value = v;
                mydb.OpenConnection();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                mydb.CloseConnection();
                return count;
            }
        }

        internal static void nhapKhoThucPham(int v, int s1)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT into PhieuNhapThucPham(MATP, SoLuong, TongTien) values(@matp,@soluong,@tongtien)", mydb.GetConnection))
            {
                cmd.Parameters.Add("@matp", SqlDbType.Int).Value = v;
                cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = s1;
                double gia = giaGiaTP(v);
                cmd.Parameters.Add("@tongtien", SqlDbType.Int).Value = s1 * gia;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        private static double giaGiaTP(int v)
        {
           using (SqlCommand cmd = new SqlCommand("select giatp from thucpham where matp=@matp", mydb.GetConnection))
            {
                cmd.Parameters.Add("@matp", SqlDbType.Int).Value = v;
                mydb.OpenConnection();
                double gia = Convert.ToDouble(cmd.ExecuteScalar());
                mydb.CloseConnection();
                return gia;
            }
        }

        internal static double getTongTienThucPhamByMaHD(int mahoadon)
        {
            using (SqlCommand cmd = new SqlCommand("select sum(KHAIBAOTHUCPHAM.SoLuong*THUCPHAM.GiaBan)\r\nfrom KHAIBAOTHUCPHAM\r\njoin THUCPHAM on KHAIBAOTHUCPHAM.MaTP=THUCPHAM.MaTP\r\ngroup BY KHAIBAOTHUCPHAM.MaHD,KHAIBAOTHUCPHAM.isLaoCong\r\nhaving KHAIBAOTHUCPHAM.MaHD=@mahd", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mahd", SqlDbType.Int).Value = mahoadon;
                mydb.OpenConnection();
                double tongtien = Convert.ToDouble(cmd.ExecuteScalar());
                mydb.CloseConnection();
                return tongtien;
            }
        }

        internal static DataTable getDSLCKhaiBao(int maHD)
        {
            using (SqlCommand cmd = new SqlCommand("select tp.MaTP as [Mã Thực Phẩm],TenTP as [Tên Thực Phẩm],GiaBan as [Giá Bán] ,SoLuong as [Số Lượng Lao Công Khai Báo]\r\nfrom KHAIBAOTHUCPHAM kt join THUCPHAM tp on kt.MaTP=tp.MaTP where MaHD=@mahd and isLaoCong=1", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mahd", SqlDbType.Int).Value = maHD;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                mydb.OpenConnection();
                adapter.Fill(table);
                mydb.CloseConnection();
                return table;
            }
        }

        internal static DataTable getDSKHKhaiBao(int maHD)
        {
            using (SqlCommand cmd = new SqlCommand("select tp.MaTP as [Mã Thực Phẩm],TenTP as [Tên Thực Phẩm],GiaBan as [Giá Bán] ,SoLuong as [Số Lượng Lao Công Khai Báo]\r\nfrom KHAIBAOTHUCPHAM kt join THUCPHAM tp on kt.MaTP=tp.MaTP where MaHD=@mahd and isLaoCong=0", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mahd", SqlDbType.Int).Value = maHD;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                mydb.OpenConnection();
                adapter.Fill(table);
                mydb.CloseConnection();
                return table;
            }
        }
    }
}
