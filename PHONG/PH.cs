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
        MyDB mydb = new MyDB();
        public DataTable getAllMaLoaiPhong()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LoaiPhong");
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertPhong(string maphong, string tenphong, bool stt, string maloai)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Phong (maphong, tenphong, tinhtrangphong, maloaiphong) VALUES (@mp, @tp, @stt, @ml)",mydb.GetConnection);
            command.Parameters.Add("@mp", SqlDbType.VarChar).Value = maphong;
            command.Parameters.Add("@tp", SqlDbType.VarChar).Value = tenphong;
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
        public DataTable getLoaiPhongByMaLoai(string maloai)
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
        public bool themLoaiPhong(string maloaiphong, string tenloaiphong, string trangthietbi, double gialoaiphong, string mota)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LoaiPhong (maloaiphong, tenloaiphong, trangthietbi, gialoaiphong, mota) VALUES (@ml, @tlp, @ttb, @g, @mt)", mydb.GetConnection);
            command.Parameters.Add("@ml", SqlDbType.VarChar).Value = maloaiphong;
            command.Parameters.Add("@tlp", SqlDbType.VarChar).Value = tenloaiphong;
            command.Parameters.Add("@ttb", SqlDbType.VarChar).Value = trangthietbi;
            command.Parameters.Add("@g", SqlDbType.Money).Value = gialoaiphong;
            command.Parameters.Add("@mt", SqlDbType.VarChar).Value = mota;
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

        public void updateLoaiPhong(string maloaiphong, string tenloaiphong, string trangthietbi, double gia, string mota)
        {
            //update loai phong
            SqlCommand command = new SqlCommand("UPDATE LoaiPhong SET tenloaiphong = @tlp, trangthietbi = @ttb, gialoaiphong = @g, mota = @mt WHERE maloaiphong = @ml", mydb.GetConnection);
            command.Parameters.Add("@ml", SqlDbType.VarChar).Value = maloaiphong;
            command.Parameters.Add("@tlp", SqlDbType.VarChar).Value = tenloaiphong;
            command.Parameters.Add("@ttb", SqlDbType.VarChar).Value = trangthietbi;
            command.Parameters.Add("@g", SqlDbType.Money).Value = gia;
            command.Parameters.Add("@mt", SqlDbType.VarChar).Value = mota;
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

        public void deleteLoaiPhong(string maloaiphong)
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

        public DataTable getDSPhong()
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM Phong", mydb.GetConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
