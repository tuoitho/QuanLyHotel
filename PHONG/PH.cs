using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHotel.PHONG
{
    public class PH
    {
        static MyDB mydb = new MyDB();
        public static DataTable getAllMaLoaiPhong()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LoaiPhong");
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            mydb.OpenConnection();
            DataTable table = new DataTable();
            adapter.Fill(table);
            mydb.CloseConnection();
            return table;
        }

        public static bool insertPhong(int maphong, string tenphong, bool stt, int maloai)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Phong (maphong, tenphong, tinhtrangphong, maloaiphong) VALUES (@mp, @tp, @stt, @ml)",mydb.GetConnection);
            command.Parameters.Add("@mp", SqlDbType.Int).Value = maphong;
            command.Parameters.Add("@tp", SqlDbType.NVarChar).Value = tenphong;
            command.Parameters.Add("@stt", SqlDbType.Bit).Value = stt;
            command.Parameters.Add("@ml", SqlDbType.Int).Value = maloai;
            mydb.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
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
        public static DataTable getLoaiPhongByMaLoai(int maloai)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LoaiPhong WHERE maloaiphong = @ml", mydb.GetConnection);
            command.Parameters.Add("@ml", SqlDbType.Int).Value = maloai;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            mydb.OpenConnection();
            DataTable table = new DataTable();
            adapter.Fill(table);
            mydb.CloseConnection();
            return table;
        }
        public static bool themLoaiPhong(int maloaiphong, string tenloaiphong, string trangthietbi, double gialoaiphong, string mota)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LoaiPhong (maloaiphong, tenloaiphong, trangthietbi, gialoaiphong, mota) VALUES (@ml, @tlp, @ttb, @g, @mt)", mydb.GetConnection);
            command.Parameters.Add("@ml", SqlDbType.Int).Value = maloaiphong;
            command.Parameters.Add("@tlp", SqlDbType.NVarChar).Value = tenloaiphong;
            command.Parameters.Add("@ttb", SqlDbType.NVarChar).Value = trangthietbi;
            command.Parameters.Add("@g", SqlDbType.Money).Value = gialoaiphong;
            command.Parameters.Add("@mt", SqlDbType.NVarChar).Value = mota;
            mydb.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
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

        public static void updateLoaiPhong(int maloaiphong, string tenloaiphong, string trangthietbi, double gia, string mota)
        {
            //update loai phong
            SqlCommand command = new SqlCommand("UPDATE LoaiPhong SET tenloaiphong = @tlp, trangthietbi = @ttb, gialoaiphong = @g, mota = @mt WHERE maloaiphong = @ml", mydb.GetConnection);
            command.Parameters.Add("@ml", SqlDbType.Int).Value = maloaiphong;
            command.Parameters.Add("@tlp", SqlDbType.NVarChar).Value = tenloaiphong;
            command.Parameters.Add("@ttb", SqlDbType.NVarChar).Value = trangthietbi;
            command.Parameters.Add("@g", SqlDbType.Money).Value = gia;
            command.Parameters.Add("@mt", SqlDbType.NVarChar).Value = mota;
            mydb.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.CloseConnection();
            }
            else
            {
                mydb.CloseConnection();
            }
        }

        public static void deleteLoaiPhong(int maloaiphong)
        {
            //delete loai phong theo maloaiphong
            SqlCommand command = new SqlCommand("DELETE FROM LoaiPhong WHERE maloaiphong = @ml", mydb.GetConnection);
            command.Parameters.Add("@ml", SqlDbType.Int).Value = maloaiphong;
            mydb.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.CloseConnection();
            }
            else
            {
                mydb.CloseConnection();
            }
        }

        public static DataTable getDSPhong()
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM Phong", mydb.GetConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                mydb.OpenConnection();
                DataTable table = new DataTable();
                adapter.Fill(table);
                mydb.CloseConnection();
                return table;
            }
        }

        public static bool themLoaiPhong(string tenloaiphong, string trangthietbi, double gia, string mota)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LoaiPhong ( tenloaiphong, trangthietbi, gialoaiphong, mota) VALUES ( @tlp, @ttb, @g, @mt)", mydb.GetConnection);
            command.Parameters.Add("@tlp", SqlDbType.NVarChar).Value = tenloaiphong;
            command.Parameters.Add("@ttb", SqlDbType.NVarChar).Value = trangthietbi;
            command.Parameters.Add("@g", SqlDbType.Money).Value = gia;
            command.Parameters.Add("@mt", SqlDbType.NVarChar).Value = mota;
            mydb.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
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

        public static void updatePhong(int maphong, string tenphong, bool stt, string maloai)
        {
            using (SqlCommand command = new SqlCommand("UPDATE Phong SET tenphong = @tp, tinhtrangphong = @stt, maloaiphong = @ml WHERE maphong = @mp", mydb.GetConnection))
            {
                command.Parameters.Add("@mp", SqlDbType.Int).Value = maphong;
                command.Parameters.Add("@tp", SqlDbType.NVarChar).Value = tenphong;
                command.Parameters.Add("@stt", SqlDbType.Bit).Value = stt;
                command.Parameters.Add("@ml", SqlDbType.Int).Value = maloai;
                mydb.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    mydb.CloseConnection();
                }
                else
                {
                    mydb.CloseConnection();
                }
            }
        }

        public static DataTable getDSPhongTrong()
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM Phong WHERE tinhtrangphong=0", mydb.GetConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                mydb.OpenConnection();
                adapter.Fill(table);
                mydb.CloseConnection();
                return table;
            }
        }

        public static void danhDauPhong(int maphong,int stt)
        {
            //
            using (SqlCommand command = new SqlCommand("UPDATE Phong SET tinhtrangphong = @stt WHERE maphong = @mp", mydb.GetConnection))
            {
                command.Parameters.Add("@mp", SqlDbType.Int).Value = maphong;
                command.Parameters.Add("@stt", SqlDbType.Bit).Value = stt;
                mydb.OpenConnection();
                command.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static void insertPhong(string tenphong, bool stt, int maloai)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Phong (tenphong, tinhtrangphong, maloaiphong) VALUES (@tp, @stt, @ml)", mydb.GetConnection))
            {
                command.Parameters.Add("@tp", SqlDbType.NVarChar).Value = tenphong;
                command.Parameters.Add("@stt", SqlDbType.Bit).Value = stt;
                command.Parameters.Add("@ml", SqlDbType.Int).Value = maloai;
                mydb.OpenConnection();
                command.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static bool getTrangThai(int map)
        {
            using (SqlCommand command = new SqlCommand("SELECT tinhtrangphong FROM Phong WHERE maphong = @mp", mydb.GetConnection))
            {
                command.Parameters.Add("@mp", SqlDbType.Int).Value = map;
                mydb.OpenConnection();
                bool trangthai = (bool)command.ExecuteScalar();
                mydb.CloseConnection();
                return trangthai;
            }
        }

        internal static void deletePhong(int map)
        {
           using (SqlCommand command = new SqlCommand("DELETE FROM Phong WHERE maphong = @mp", mydb.GetConnection))
            {
                command.Parameters.Add("@mp", SqlDbType.Int).Value = map;
                mydb.OpenConnection();
                command.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static int getSLThucPhamByMaPhong_MaTP(int v1, int v2)
        {
            using (SqlCommand command = new SqlCommand("select soluong from Phong_SoLuongThucPham where maphong = @maph and matp = @matp\r\n", mydb.GetConnection))
            {
                command.Parameters.Add("@maph", SqlDbType.Int).Value = v1;
                command.Parameters.Add("@matp", SqlDbType.Int).Value = v2;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                mydb.OpenConnection();
                adapter.Fill(table);
                mydb.CloseConnection();
                if (table.Rows.Count > 0)
                {
                    return Convert.ToInt32(table.Rows[0][0]);
                }
                else
                {
                    return 0;
                }
            }
        }

        internal static void capTP(int v1, int v2, int s3)
        {
            //neu vuot qua so luong trong kho thi bao loi
            using (SqlCommand command = new SqlCommand("select TONKHO from ThucPham where matp =@matp", mydb.GetConnection))
            {
                command.Parameters.Add("@matp", SqlDbType.Int).Value = v2;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                mydb.OpenConnection();
                adapter.Fill(table);
                mydb.CloseConnection();
                if (table.Rows.Count > 0)
                {
                    if (Convert.ToInt32(table.Rows[0][0]) < s3)
                    {
                        throw new Exception("Số lượng thực phẩm trong kho không đủ");
                    }
                }
                
            }
            //neu chua co thi insert, da co thi update
            using (SqlCommand command = new SqlCommand("select * from Phong_SoLuongThucPham where maphong = @maph and matp = @matp", mydb.GetConnection))
            {
                command.Parameters.Add("@maph", SqlDbType.Int).Value = v1;
                command.Parameters.Add("@matp", SqlDbType.Int).Value = v2;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                mydb.OpenConnection();
                adapter.Fill(table);
                mydb.CloseConnection();
                if (table.Rows.Count > 0)
                {
                    //update
                    using (SqlCommand command1 = new SqlCommand("UPDATE Phong_SoLuongThucPham SET soluong = soluong+@sl WHERE maphong = @maph and matp = @matp", mydb.GetConnection))
                    {
                        command1.Parameters.Add("@maph", SqlDbType.Int).Value = v1;
                        command1.Parameters.Add("@matp", SqlDbType.Int).Value = v2;
                        command1.Parameters.Add("@sl", SqlDbType.Int).Value = s3;
                        mydb.OpenConnection();
                        command1.ExecuteNonQuery();
                        mydb.CloseConnection();
                    }
                }
                else
                {
                    //insert
                    using (SqlCommand command1 = new SqlCommand("INSERT INTO Phong_SoLuongThucPham (maphong, matp, soluong) VALUES (@maph, @matp, @sl)", mydb.GetConnection))
                    {
                        command1.Parameters.Add("@maph", SqlDbType.Int).Value = v1;
                        command1.Parameters.Add("@matp", SqlDbType.Int).Value = v2;
                        command1.Parameters.Add("@sl", SqlDbType.Int).Value = s3;
                        mydb.OpenConnection();
                        command1.ExecuteNonQuery();
                        mydb.CloseConnection();
                    }
                }
                //tru so luong thuc pham trong kho
                using (SqlCommand command1 = new SqlCommand("UPDATE ThucPham SET tonkho = tonkho-@sl WHERE matp = @matp", mydb.GetConnection))
                {
                    command1.Parameters.Add("@matp", SqlDbType.Int).Value = v2;
                    command1.Parameters.Add("@sl", SqlDbType.Int).Value = s3;
                    mydb.OpenConnection();
                    command1.ExecuteNonQuery();
                    mydb.CloseConnection();
                }
            }
        }
    }
}
