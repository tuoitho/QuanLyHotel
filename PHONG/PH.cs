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
    }
}
