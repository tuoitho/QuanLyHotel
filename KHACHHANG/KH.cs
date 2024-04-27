using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHotel.KHACHHANG
{
    public class KH
    {
        static MyDB myDB= new MyDB();
        public static DataTable getDSKhachHang()
        {
            string sql = "select * from KhachHang";
            SqlCommand cmd = new SqlCommand(sql, myDB.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            myDB.OpenConnection();
            adapter.Fill(table);
            myDB.CloseConnection();
            return table;
        }

        internal static bool deleteKhachHang(string maKH)
        {
            using (SqlCommand cmd = new SqlCommand("delete from KhachHang where makh = @makh", myDB.GetConnection))
            {
                cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = maKH;
                myDB.OpenConnection();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    myDB.CloseConnection();
                    return true;
                }
                else
                {
                    myDB.CloseConnection();
                    return false;
                }
            }
        }

        internal static bool insertKhachHang(string hoten, string sdt, string cccd, string quoctich, MemoryStream pic)
        {
            using (SqlCommand cmd = new SqlCommand("insert into KhachHang (hoten, sdt, cccd, quoctich, hinhanh) values (@hoten, @sdt, @cccd, @quoctich, @pic)", myDB.GetConnection))
            {
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
                cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
                cmd.Parameters.Add("@cccd", SqlDbType.NVarChar).Value = cccd;
                cmd.Parameters.Add("@quoctich", SqlDbType.NVarChar).Value = quoctich;
                cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
                myDB.OpenConnection();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    myDB.CloseConnection();
                    return true;
                }
                else
                {
                    myDB.CloseConnection();
                    return false;
                }
            }
        }

        internal static DataTable  searchKhachHang(string input)
        {
            using (SqlCommand cmd = new SqlCommand("select * from KhachHang where makh like @input or hoten like @input or sdt like @input or cccd like @input", myDB.GetConnection))
            {
                cmd.Parameters.Add("@input", SqlDbType.NVarChar).Value = "%" + input + "%";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                myDB.OpenConnection();
                adapter.Fill(table);
                myDB.CloseConnection();
                return table;
            }
        }

        internal static bool updateKhachHang(string text, string hoten, string sdt, string diachi, string quoctich, MemoryStream pic)
        {
            using (SqlCommand cmd = new SqlCommand("update KhachHang set hoten = @hoten, sdt = @sdt, cccd = @cccd, quoctich = @quoctich, hinhanh = @pic where makh = @makh", myDB.GetConnection))
            {
                cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = text;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
                cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
                cmd.Parameters.Add("@cccd", SqlDbType.NVarChar).Value = diachi;
                cmd.Parameters.Add("@quoctich", SqlDbType.NVarChar).Value = quoctich;
                cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
                myDB.OpenConnection();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    myDB.CloseConnection();
                    return true;
                }
                else
                {
                    myDB.CloseConnection();
                    return false;
                }
            }
        }
        public static DataTable getMaGiamGiaChuaSuDungByMaKH(string makh)
        {
            using (SqlCommand cmd = new SqlCommand("select * from MaGiamGia where makh = @makh and DaSuDung=0", myDB.GetConnection))
            {
                cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = makh;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                myDB.OpenConnection();
                adapter.Fill(table);
                myDB.CloseConnection();
                return table;
            }
        }

        internal static void updateMaGiamGiaDaSuDung(int magiamgia)
        {
            using (SqlCommand cmd = new SqlCommand("update [MaGiamGia] set DaSuDung=1 where MaGiamGia.MaGiamGia = @magiamgia", myDB.GetConnection))
            {
                cmd.Parameters.Add("@magiamgia", SqlDbType.Int).Value = magiamgia;
                myDB.OpenConnection();
                cmd.ExecuteNonQuery();
                myDB.CloseConnection();
            }
        }
    }
}
