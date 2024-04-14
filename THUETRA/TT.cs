using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinForms.Documents.RichTextBoxCommands;

namespace QuanLyHotel.THUETRA
{
    public class TT
    {
        MyDB mydb = new MyDB();
        public DataTable getDSPhieuDangKy()
        {
            string sql = "select * from PhieuDangKy";
            SqlCommand cmd = new SqlCommand(sql, mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            mydb.OpenConnection();
            adapter.Fill(table);
            mydb.CloseConnection();
            return table;
        }

        public bool themPhieuDangKy(DateTime expectedArrival, DateTime expectedDeparture, string depositAmount, string employee, string customer, string room)
        {
            using (SqlCommand cmd = new SqlCommand("insert into PhieuDangKy(DuKienDen, DuKienDi, TienDatCoc, MaNV, MaKH, MaPhong) values (@ngayden, @ngaydi, @sotien, @manv, @makh, @maphong)", mydb.GetConnection))
            {
                cmd.Parameters.Add("@ngayden", SqlDbType.DateTime).Value = expectedArrival;
                cmd.Parameters.Add("@ngaydi", SqlDbType.DateTime).Value = expectedDeparture;
                cmd.Parameters.Add("@sotien", SqlDbType.Money).Value = depositAmount;
                cmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = employee;
                cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = customer;
                cmd.Parameters.Add("@maphong", SqlDbType.VarChar).Value = room;
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

        public void updatePhieuDangKy(string mapdk, DateTime expectedArrival, DateTime expectedDeparture, double depositAmount, string employee, string customer, string room)
        {
            using (SqlCommand cmd = new SqlCommand("update PhieuDangKy set DuKienDen=@ngayden, DuKienDi=@ngaydi, TienDatCoc=@sotien, MaNV=@manv, MaKH=@makh, MaPhong=@maphong where MaPhieuDK=@mapdk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mapdk", SqlDbType.VarChar).Value = mapdk;
                cmd.Parameters.Add("@ngayden", SqlDbType.DateTime).Value = expectedArrival;
                cmd.Parameters.Add("@ngaydi", SqlDbType.DateTime).Value = expectedDeparture;
                cmd.Parameters.Add("@sotien", SqlDbType.Money).Value = depositAmount;
                cmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = employee;
                cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = customer;
                cmd.Parameters.Add("@maphong", SqlDbType.VarChar).Value = room;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        public void deletePhieuDangKy(string mapdk)
        {
            using (SqlCommand cmd = new SqlCommand("delete from PhieuDangKy where MaPhieuDK=@mapdk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mapdk", SqlDbType.VarChar).Value = mapdk;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        public void danhDauPDKHoanThanh(string mapdk)
        {
            using (SqlCommand cmd = new SqlCommand("update PhieuDangKy set TrangThai=N'Hoàn thành' where MaPhieuDK=@mapdk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mapdk", SqlDbType.VarChar).Value = mapdk;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        public void danhDauPDKHetHan(string mapdk)
        {
            using (SqlCommand cmd = new SqlCommand("update PhieuDangKy set TrangThai=N'Hết hạn' where MaPhieuDK=@mapdk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mapdk", SqlDbType.VarChar).Value = mapdk;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }
        public void taoHoaDon(string mapdk)
        {
            SqlCommand cmd = new SqlCommand("insert into HoaDon(TenHoaDon,NgayLap,TongTienHoaDon,MaPhieuDK) values (N'Hoá Đơn Thuê Phòng',null,null,@mapdk)", mydb.GetConnection);
            cmd.Parameters.Add("@mapdk", SqlDbType.VarChar).Value = mapdk;
            mydb.OpenConnection();
            cmd.ExecuteNonQuery();
            mydb.CloseConnection();
        }

        public DataTable getThongTinHoaDonTuMaHD(string mahoadon)
        {
            SqlCommand cmd = new SqlCommand("SELECT HoaDon.MaHoaDon as MaHD,HoaDon.TenHoaDon as TenHD,HoaDon.TongTienHoaDon as TongTien, HoaDon.TienDatCoc as TienCoc,HoaDon.TienPhong as TienPhong,HoaDon.TienDichVu as TienDichVu,\r\n    KhachHang.MaKH as MaKH, KhachHang.HoTen as HoTen,KhachHang.SDT as SDT,KhachHang.CCCD as CCCD,KhachHang.QuocTich as QuocTich,\r\n    Phong.MaPhong as MaPhong,Phong.TenPhong TenPhong, LoaiPhong.GiaLoaiPhong GiaPhong\r\nfrom HoaDon\r\n    JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH\r\n    JOIN Phong ON HoaDon.MaPhong = Phong.MaPhong\r\n    JOIN LoaiPhong ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong\r\nwhere HoaDon.MaHoaDon = @mahd", mydb.GetConnection);
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = mahoadon;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            mydb.OpenConnection();
            adapter.Fill(table);
            mydb.CloseConnection();
            return table;

        }
        public string getMaHoaDonbyMaPDK(string mapdk)
        {
            SqlCommand cmd = new SqlCommand("select MaHoaDon from HoaDon where MaPhieuDK=@mapdk", mydb.GetConnection);
            cmd.Parameters.Add("@mapdk", SqlDbType.VarChar).Value = mapdk;
            mydb.OpenConnection();
            string mahoadon = cmd.ExecuteScalar().ToString();
            mydb.CloseConnection();
            return mahoadon;
        }
        public bool kiemTraHoaDonDaTao(string mapdk)
        {
            SqlCommand cmd = new SqlCommand("select count(*) from HoaDon where MaPhieuDK=@mapdk", mydb.GetConnection);
            cmd.Parameters.Add("@mapdk", SqlDbType.VarChar).Value = mapdk;
            mydb.OpenConnection();
            int count = (int)cmd.ExecuteScalar();
            mydb.CloseConnection();
            if (count > 0)
                return true;
            return false;

        }

        public string getTrangThaiByMaPDK(string mapdk)
        {
            using (SqlCommand cmd = new SqlCommand("select TrangThai from PhieuDangKy where MaPhieuDK=@mapdk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mapdk", SqlDbType.VarChar).Value = mapdk;
                mydb.OpenConnection();
                string trangthai = cmd.ExecuteScalar().ToString();
                mydb.CloseConnection();
                return trangthai;
            }
        }

        public string getMaPhongByMaPDK(string mapdk)
        {
            //
            using (SqlCommand cmd = new SqlCommand("select MaPhong from PhieuDangKy where MaPhieuDK=@mapdk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@mapdk", SqlDbType.VarChar).Value = mapdk;
                mydb.OpenConnection();
                string maphong = cmd.ExecuteScalar().ToString();
                mydb.CloseConnection();
                return maphong;
            }
        }
    }
}
