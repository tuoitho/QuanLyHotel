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
        MyDB mydb = new MyDB();
        public DataTable getDSDichVu()
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

        public DataTable getDSLoaiDichVu()
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

        public DataTable getDSDichVu(string text)
        {
            using (SqlCommand cmd = new SqlCommand("select * from DichVu where MaLDV=@maldv", mydb.GetConnection))
            {
                cmd.Parameters.Add("@maldv", SqlDbType.VarChar).Value = text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                mydb.OpenConnection();
                adapter.Fill(table);
                mydb.CloseConnection();
                return table;
            }
        }

        public double getGiaDV(string madv)
        {
            using (SqlCommand cmd = new SqlCommand("select GiaDV from DichVu where MaDV=@madv", mydb.GetConnection))
            {
                cmd.Parameters.Add("@madv", SqlDbType.VarChar).Value = madv;
                mydb.OpenConnection();
                double gia = Convert.ToDouble(cmd.ExecuteScalar());
                mydb.CloseConnection();
                return gia;
            }
        }

        public void themChiTietHDDV(string madv, string mhd, int sl, double gia)
        {
            //kiem tra xem dich vu da co trong hoa don chua, neu co thi tang so luong, neu chua thi them moi
            SqlCommand cmd = new SqlCommand("select count(*) from ChiTietHoaDonDichVu where MaHoaDon=@mhd and MaDichVu=@madv", mydb.GetConnection);
            cmd.Parameters.Add("@mhd", SqlDbType.VarChar).Value = mhd;
            cmd.Parameters.Add("@madv", SqlDbType.VarChar).Value = madv;
            mydb.OpenConnection();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
            {
                cmd = new SqlCommand("insert into ChiTietHoaDonDichVu(MaHoaDon,MaDichVu,SoLuong,Gia) values (@mhd,@madv,@sl,@gia)", mydb.GetConnection);
                cmd.Parameters.Add("@mhd", SqlDbType.VarChar).Value = mhd;
                cmd.Parameters.Add("@madv", SqlDbType.VarChar).Value = madv;
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = sl;
                cmd.Parameters.Add("@gia", SqlDbType.Money).Value = gia;
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SqlCommand("update ChiTietHoaDonDichVu set SoLuong=SoLuong+@sl where MaHoaDon=@mhd and MaDichVu=@madv", mydb.GetConnection);
                cmd.Parameters.Add("@mhd", SqlDbType.VarChar).Value = mhd;
                cmd.Parameters.Add("@madv", SqlDbType.VarChar).Value = madv;
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = sl;
                cmd.ExecuteNonQuery();
            }
            mydb.CloseConnection();


        }

        public DataTable getDSDichVuByMaHD(string mhd)
        {
            using (SqlCommand cmd = new SqlCommand("select MaDichVu as [Mã Dịch Vụ],TenDV [Tên DV],SoLuong SL,Gia as [Tổng Tiền DV] from ChiTietHoaDonDichVu ct join DichVu dv on ct.MaDichVu=dv.MaDV where MaHoaDon=@mhd", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mhd", SqlDbType.VarChar).Value = mhd;
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
