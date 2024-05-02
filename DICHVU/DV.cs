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
    }
}
