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

        public static bool insertPhong(string maphong, string tenphong, bool stt, string maloai)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Phong (maphong, tenphong, tinhtrangphong, maloaiphong) VALUES (@mp, @tp, @stt, @ml)",mydb.GetConnection);
            command.Parameters.Add("@mp", SqlDbType.VarChar).Value = maphong;
            command.Parameters.Add("@tp", SqlDbType.NVarChar).Value = tenphong;
            command.Parameters.Add("@stt", SqlDbType.Bit).Value = stt;
            command.Parameters.Add("@ml", SqlDbType.VarChar).Value = maloai;
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
        public static DataTable getLoaiPhongByMaLoai(string maloai)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LoaiPhong WHERE maloaiphong = @ml", mydb.GetConnection);
            command.Parameters.Add("@ml", SqlDbType.VarChar).Value = maloai;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            mydb.OpenConnection();
            DataTable table = new DataTable();
            adapter.Fill(table);
            mydb.CloseConnection();
            return table;
        }
        public static bool themLoaiPhong(string maloaiphong, string tenloaiphong, string trangthietbi, double gialoaiphong, string mota)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LoaiPhong (maloaiphong, tenloaiphong, trangthietbi, gialoaiphong, mota) VALUES (@ml, @tlp, @ttb, @g, @mt)", mydb.GetConnection);
            command.Parameters.Add("@ml", SqlDbType.VarChar).Value = maloaiphong;
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

        public static void updateLoaiPhong(string maloaiphong, string tenloaiphong, string trangthietbi, double gia, string mota)
        {
            //update loai phong
            SqlCommand command = new SqlCommand("UPDATE LoaiPhong SET tenloaiphong = @tlp, trangthietbi = @ttb, gialoaiphong = @g, mota = @mt WHERE maloaiphong = @ml", mydb.GetConnection);
            command.Parameters.Add("@ml", SqlDbType.VarChar).Value = maloaiphong;
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

        public static void deleteLoaiPhong(string maloaiphong)
        {
            //delete loai phong theo maloaiphong
            SqlCommand command = new SqlCommand("DELETE FROM LoaiPhong WHERE maloaiphong = @ml", mydb.GetConnection);
            command.Parameters.Add("@ml", SqlDbType.VarChar).Value = maloaiphong;
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

        public static void updatePhong(string maphong, string tenphong, bool stt, string maloai)
        {
            using (SqlCommand command = new SqlCommand("UPDATE Phong SET tenphong = @tp, tinhtrangphong = @stt, maloaiphong = @ml WHERE maphong = @mp", mydb.GetConnection))
            {
                command.Parameters.Add("@mp", SqlDbType.VarChar).Value = maphong;
                command.Parameters.Add("@tp", SqlDbType.NVarChar).Value = tenphong;
                command.Parameters.Add("@stt", SqlDbType.Bit).Value = stt;
                command.Parameters.Add("@ml", SqlDbType.VarChar).Value = maloai;
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

        internal static void insertPhong(string tenphong, bool stt, string maloai)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Phong (tenphong, tinhtrangphong, maloaiphong) VALUES (@tp, @stt, @ml)", mydb.GetConnection))
            {
                command.Parameters.Add("@tp", SqlDbType.NVarChar).Value = tenphong;
                command.Parameters.Add("@stt", SqlDbType.Bit).Value = stt;
                command.Parameters.Add("@ml", SqlDbType.VarChar).Value = maloai;
                mydb.OpenConnection();
                command.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }
    }
}
