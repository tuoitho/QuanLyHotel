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
        //SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=l7;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True");

        SqlConnection conn = new SqlConnection(@"Data Source=TUOITHO\SQLEXPRESS;Initial Catalog=l8;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True");
        //SqlConnection conn = new SqlConnection(@"Server=ttwinform.database.windows.net;Initial Catalog=l8;Persist Security Info=False;User ID=tt;Password=83688436T@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //SqlConnection conn = new SqlConnection(@"Server=ttwinform.database.windows.net;Initial Catalog=HotelTT;User ID=tt;Password=83688436T@;");

        //SqlConnection conn = new SqlConnection(@"Server=tcp:azureforwintt.database.windows.net,1433;Initial Catalog=QuanLyHotel;Persist Security Info=False;User ID=CloudSA18c3fa08;Password=83688436T@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
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
