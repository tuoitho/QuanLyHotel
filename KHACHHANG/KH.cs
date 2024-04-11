using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHotel.KHACHHANG
{
    public class KH
    {
        MyDB myDB= new MyDB();
        public DataTable getDSKhachHang()
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
    }
}
