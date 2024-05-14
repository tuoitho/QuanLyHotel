using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.KHACHHANG
{
    public class KH
    {
        static MyDB myDB = new MyDB();
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

        internal static void deleteKhachHang(string maKH)
        {
            using (SqlCommand cmd = new SqlCommand("delete from KhachHang where makh = @makh", myDB.GetConnection))
            {
                cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = maKH;
                myDB.OpenConnection();
                cmd.ExecuteNonQuery();
                myDB.CloseConnection();
            }
        }

        internal static void insertKhachHang(string hoten, string sdt, string cccd, string quoctich, MemoryStream pic)
        {
            using (SqlCommand cmd = new SqlCommand("insert into KhachHang (hoten, sdt, cccd, quoctich, hinhanh) values (@hoten, @sdt, @cccd, @quoctich, @pic)", myDB.GetConnection))
            {
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
                cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
                cmd.Parameters.Add("@cccd", SqlDbType.NVarChar).Value = cccd;
                cmd.Parameters.Add("@quoctich", SqlDbType.NVarChar).Value = quoctich;
                cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
                myDB.OpenConnection();
                try
                {
                    int k = cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        internal static DataTable searchKhachHang(string input)
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

        internal static bool updateKhachHang(int makh, string hoten, string sdt, DateTime ngaysinh, string cccd, string email, string quoctich, MemoryStream pic)
        {
            using (SqlCommand cmd = new SqlCommand("update KhachHang set hoten=@hoten, sdt=@sdt, ngaysinh=@ngaysinh, cccd=@cccd, email=@email, quoctich=@quoctich, hinhanh=@pic where makh=@makh", myDB.GetConnection))
            {
                cmd.Parameters.Add("@makh", SqlDbType.Int).Value = makh;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
                cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
                cmd.Parameters.Add("@cccd", SqlDbType.NVarChar).Value = cccd;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                cmd.Parameters.Add("@quoctich", SqlDbType.NVarChar).Value = quoctich;
                cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
                myDB.OpenConnection();
                try
                {
                    int k = cmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        internal static DataTable getMaGiamGia(int makh)
        {
            using (SqlCommand cmd = new SqlCommand("select * from MaGiamGia where MaKH=@makh", myDB.GetConnection))
            {
                cmd.Parameters.Add("@makh", SqlDbType.Int).Value = makh;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                myDB.OpenConnection();
                adapter.Fill(table);
                myDB.CloseConnection();
                return table;
            }
        }

        

        internal static string getNameByID(int makh)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT hoten FROM KhachHang where MaKH = @makh", myDB.GetConnection);
            sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = makh;
            myDB.OpenConnection();
            string name = sqlCommand.ExecuteScalar().ToString();
            myDB.CloseConnection();
            return name;

        }

        internal static int getMaHoaDonHienTaiByMaKH(int id)
        {
            using (SqlCommand cmd = new SqlCommand("select MaHoaDon from HoaDon where MaKH = @id and TrangThai like N'Chưa thanh toán'", myDB.GetConnection))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                myDB.OpenConnection();
                int mahd = Convert.ToInt32(cmd.ExecuteScalar());
                myDB.CloseConnection();
                return mahd;
            }
        }

        internal static DataTable getDSKhaiBaoByMaHD(int mahd)
        {
           using (SqlCommand cmd = new SqlCommand("select * from KhaiBao where MaHD = @mahd", myDB.GetConnection))
            {
                cmd.Parameters.Add("@mahd", SqlDbType.Int).Value = mahd;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                myDB.OpenConnection();
                adapter.Fill(table);
                myDB.CloseConnection();
                return table;
            }
        }

        internal static void insertKhaiBao(int id, int mahd, int madv, int soluong)
        {
            using (SqlCommand cmd = new SqlCommand("insert into KhaiBao (MaKH, MaHD, MaDV, SoLuong) values (@id, @mahd, @madv, @soluong)", myDB.GetConnection))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@mahd", SqlDbType.Int).Value = mahd;
                cmd.Parameters.Add("@madv", SqlDbType.Int).Value = madv;
                cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
                myDB.OpenConnection();
                cmd.ExecuteNonQuery();
                myDB.CloseConnection();
            }
        }

        internal static bool checkKhaiBao(int mahd, int madv)
        {
            using (SqlCommand cmd = new SqlCommand("select * from KhaiBao where MaHD = @mahd and MaDV = @madv", myDB.GetConnection))
            {
                cmd.Parameters.Add("@mahd", SqlDbType.Int).Value = mahd;
                cmd.Parameters.Add("@madv", SqlDbType.Int).Value = madv;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                myDB.OpenConnection();
                adapter.Fill(table);
                myDB.CloseConnection();
                if (table.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal static DataTable getDSKhaiBaoDayDu(int maHD)
        {
            SqlCommand cmd=new SqlCommand("SELECT ISNULL(ChiTietHoaDonDichVu.MaDichVu, KhaiBao.MaDV) [Mã DV], ChiTietHoaDonDichVu.SoLuong as [Số lượng nhân viên cập nhật], KhaiBao.SoLuong as [Số lượng khách hàng khai báo]\r\nFROM ChiTietHoaDonDichVu\r\nfull JOIN KhaiBao ON ChiTietHoaDonDichVu.MaHoaDon = KhaiBao.MaHD AND ChiTietHoaDonDichVu.MaDichVu = KhaiBao.MaDV\r\nwhere ChiTietHoaDonDichVu.MaHoaDon = @mhd or KhaiBao.MaHD=@mhd", myDB.GetConnection);
            cmd.Parameters.Add("@mhd", SqlDbType.Int).Value = maHD;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            myDB.OpenConnection();
            adapter.Fill(table);
            myDB.CloseConnection();
            return table;
        }

        internal static void addMaGiamGia(int id)
        {
            SqlCommand cmd = new SqlCommand(" INSERT INTO MaGiamGia (MaKH, NgayNhan, SoTien) VALUES(@makh, GETDATE(), FLOOR(RAND()*(999999-100000+1)+100000))", myDB.GetConnection);
            myDB.OpenConnection();
            cmd.Parameters.Add("@makh", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
            myDB.CloseConnection();

        }
    }
}
