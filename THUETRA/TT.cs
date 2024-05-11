using QuanLyHotel.PHONG;
using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.THUETRA
{
    public class TT
    {
        static MyDB mydb = new MyDB();
        public static DataTable getDSPhieuDangKy()
        {
            string sql = "select MaPhieuDK as 'Mã Phiếu Đăng Ký', DuKienDen as 'Dự Kiến Đến', DuKienDi as 'Dự Kiến Đi', TienDatCoc as 'Tiền Đặt Cọc',  MaKH as 'Mã Khách Hàng', MaPhong as 'Mã Phòng', TrangThai as 'Trạng Thái' from PhieuDangKy";
            SqlCommand cmd = new SqlCommand(sql, mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            mydb.OpenConnection();
            adapter.Fill(table);
            mydb.CloseConnection();
            return table;
        }
        public static DataTable getPDKByMaKH(int makh)
        {
            string sql = "select * from PhieuDangKy where MaKH=@makh";
            SqlCommand cmd = new SqlCommand(sql, mydb.GetConnection);
            cmd.Parameters.Add("@makh", SqlDbType.Int).Value = makh;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            mydb.OpenConnection();
            adapter.Fill(table);
            mydb.CloseConnection();
            return table;
        }
        public static bool themPhieuDangKy(DateTime expectedArrival, DateTime expectedDeparture, string depositAmount, int customer, int room)
        {
            using (SqlCommand cmd = new SqlCommand("insert into PhieuDangKy(DuKienDen, DuKienDi, TienDatCoc, MaKH, MaPhong) values (@ngayden, @ngaydi, @sotien, @makh, @maphong)", mydb.GetConnection))
            {
                cmd.Parameters.Add("@ngayden", SqlDbType.DateTime).Value = expectedArrival;
                cmd.Parameters.Add("@ngaydi", SqlDbType.DateTime).Value = expectedDeparture;
                cmd.Parameters.Add("@sotien", SqlDbType.Money).Value = depositAmount;
                cmd.Parameters.Add("@makh", SqlDbType.Int).Value = customer;
                cmd.Parameters.Add("@maphong", SqlDbType.Int).Value = room;
                mydb.OpenConnection();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    mydb.CloseConnection();
                    return true;
                }
                else
                {
                    mydb.CloseConnection();
                    return false;
                }
            }
        }

        public static void updatePhieuDangKy(string mapdk, DateTime expectedArrival, DateTime expectedDeparture, double depositAmount, int customer, int room)
        {
            using (SqlCommand cmd = new SqlCommand("update PhieuDangKy set DuKienDen=@ngayden, DuKienDi=@ngaydi, TienDatCoc=@sotien, MaKH=@makh, MaPhong=@maphong where MaPhieuDK=@mapdk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mapdk", SqlDbType.VarChar).Value = mapdk;
                cmd.Parameters.Add("@ngayden", SqlDbType.DateTime).Value = expectedArrival;
                cmd.Parameters.Add("@ngaydi", SqlDbType.DateTime).Value = expectedDeparture;
                cmd.Parameters.Add("@sotien", SqlDbType.Money).Value = depositAmount;
                cmd.Parameters.Add("@makh", SqlDbType.Int).Value = customer;
                cmd.Parameters.Add("@maphong", SqlDbType.Int).Value = room;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        public static void deletePhieuDangKy(int mapdk)
        {
            //danh dau phong da tra (0)
            int maphong = getMaPhongByMaPDK(mapdk);
            if (maphong != -1)
                PH.danhDauPhong(Convert.ToInt32(maphong), 0);
            using (SqlCommand cmd = new SqlCommand("delete from PhieuDangKy where MaPhieuDK=@mapdk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mapdk", SqlDbType.Int).Value = mapdk;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        public static void danhDauPDKHoanThanh(int mapdk)
        {
            using (SqlCommand cmd = new SqlCommand("update PhieuDangKy set TrangThai=N'Hoàn thành' where MaPhieuDK=@mapdk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mapdk", SqlDbType.Int).Value = mapdk;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        public static void danhDauPDKHetHan(int mapdk)
        {
            using (SqlCommand cmd = new SqlCommand("update PhieuDangKy set TrangThai=N'Hết hạn' where MaPhieuDK=@mapdk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mapdk", SqlDbType.Int).Value = mapdk;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }
        public static void taoHoaDon(int mapdk)
        {
            SqlCommand cmd = new SqlCommand("insert into HoaDon(TenHoaDon,NgayLap,TongTienHoaDon,MaPhieuDK) values (N'Hoá Đơn Thuê Phòng',null,null,@mapdk)", mydb.GetConnection);
            cmd.Parameters.Add("@mapdk", SqlDbType.Int).Value = mapdk;
            mydb.OpenConnection();
            cmd.ExecuteNonQuery();
            mydb.CloseConnection();
        }

        public static DataTable getThongTinHoaDonTuMaHD(int mahoadon)
        {
            SqlCommand cmd = new SqlCommand("SELECT HoaDon.MaHoaDon as MaHD,HoaDon.TenHoaDon as TenHD,HoaDon.TongTienHoaDon as TongTien, HoaDon.TienDatCoc as TienCoc,HoaDon.TienPhong as TienPhong,HoaDon.TienDichVu as TienDichVu,HoaDon.TrangThai TrangThaiHoaDon, HoaDon.NgayThanhToanHoanTat NgayThanhToan,   KhachHang.MaKH as MaKH, KhachHang.HoTen as HoTen,KhachHang.SDT as SDT,KhachHang.CCCD as CCCD,KhachHang.QuocTich as QuocTich,\r\n    Phong.MaPhong as MaPhong,Phong.TenPhong TenPhong, LoaiPhong.GiaLoaiPhong GiaPhong\r\nfrom HoaDon\r\n    left JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH\r\n   left JOIN Phong ON HoaDon.MaPhong = Phong.MaPhong\r\n    left JOIN LoaiPhong ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong\r\nwhere HoaDon.MaHoaDon = @mahd", mydb.GetConnection);
            cmd.Parameters.Add("@mahd", SqlDbType.Int).Value = mahoadon;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            mydb.OpenConnection();
            adapter.Fill(table);
            mydb.CloseConnection();
            return table;
        }

        public static string getMaHoaDonbyMaPDK(int mapdk)
        {
            SqlCommand cmd = new SqlCommand("select MaHoaDon from HoaDon where MaPhieuDK=@mapdk", mydb.GetConnection);
            cmd.Parameters.Add("@mapdk", SqlDbType.Int).Value = mapdk;
            mydb.OpenConnection();
            string mahoadon = cmd.ExecuteScalar().ToString();
            mydb.CloseConnection();
            return mahoadon;
        }
        public static bool kiemTraHoaDonDaTao(int mapdk)
        {
            SqlCommand cmd = new SqlCommand("select count(*) from HoaDon where MaPhieuDK=@mapdk", mydb.GetConnection);
            cmd.Parameters.Add("@mapdk", SqlDbType.Int).Value = mapdk;
            mydb.OpenConnection();
            int count = (int)cmd.ExecuteScalar();
            mydb.CloseConnection();
            if (count > 0)
                return true;
            return false;

        }

        public static string getTrangThaiByMaPDK(int mapdk)
        {
            using (SqlCommand cmd = new SqlCommand("select TrangThai from PhieuDangKy where MaPhieuDK=@mapdk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mapdk", SqlDbType.Int).Value = mapdk;
                mydb.OpenConnection();
                string trangthai = cmd.ExecuteScalar().ToString();
                mydb.CloseConnection();
                return trangthai;
            }
        }

        public static int getMaPhongByMaPDK(int mapdk)
        {
            //
            using (SqlCommand cmd = new SqlCommand("select MaPhong from PhieuDangKy where MaPhieuDK=@mapdk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mapdk", SqlDbType.Int).Value = mapdk;
                mydb.OpenConnection();
                int maphong;
                if (cmd.ExecuteScalar() == DBNull.Value)
                    maphong = -1;
                else
                    maphong = Convert.ToInt32(cmd.ExecuteScalar());
                mydb.CloseConnection();
                return (int)maphong;
            }
        }

        internal static void chuyenPhong(int mapdk, int maphonghientai, int maphongmuonchuyen)
        {
            try
            {
                PH.danhDauPhong(maphonghientai, 0);
                PH.danhDauPhong(maphongmuonchuyen, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chuyển phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            using (SqlCommand cmd = new SqlCommand("update PhieuDangKy set MaPhong=@maphongmuonchuyen where MaPhieuDK=@mapdk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mapdk", SqlDbType.Int).Value = mapdk;
                cmd.Parameters.Add("@maphongmuonchuyen", SqlDbType.Int).Value = maphongmuonchuyen;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static DataTable getPPKTuMaHD(int mahoadon)
        {
            using (SqlCommand cmd = new SqlCommand("select * from PhieuDangKy where MaPhieuDK = (select MaPhieuDK from HoaDon where MaHoaDon=@mahd)", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mahd", SqlDbType.Int).Value = mahoadon;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                mydb.OpenConnection();
                adapter.Fill(table);
                mydb.CloseConnection();
                return table;
            }
        }

        internal static void InsertThanhToan(int mahoadon, DateTime now, double v1, double v2, double v3)
        {
            using (SqlCommand cmd = new SqlCommand("insert into ThanhToan(MaHoaDon,NgayThanhToan,TongTienHoaDon,GiamGia,SoTien) values (@mahd,@ngaytt,@tongtien,@sotiengiamgia,@sotiencantra)", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mahd", SqlDbType.Int).Value = mahoadon;
                cmd.Parameters.Add("@ngaytt", SqlDbType.DateTime).Value = now;
                cmd.Parameters.Add("@tongtien", SqlDbType.Money).Value = v1;
                cmd.Parameters.Add("@sotiengiamgia", SqlDbType.Money).Value = v2;
                cmd.Parameters.Add("@sotiencantra", SqlDbType.Money).Value = v3;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static string getTrangThaiHoaDonByMaPDK(int mapdk)
        {
            using (SqlCommand cmd = new SqlCommand("select TrangThai from HoaDon where MaPhieuDK=@mapdk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mapdk", SqlDbType.Int).Value = mapdk;
                mydb.OpenConnection();
                string trangthai = cmd.ExecuteScalar().ToString();
                mydb.CloseConnection();
                return trangthai;
            }
        }
    }
}
