using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHotel.Resources
{
    public class MyDB
    {
        SqlConnection conn = new SqlConnection(@"Data Source=TUOITHO\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True");
        public SqlConnection GetConnection
        {
            get
            {
                return conn;
            }
        }
        public void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
