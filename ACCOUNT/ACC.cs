using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHotel.ACCOUNT
{
    internal class ACC
    {
        static MyDB mydb = new MyDB();
        public static DataTable getListAcc()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan", mydb.GetConnection))
            {
                mydb.OpenConnection();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
        public static int getMaNVByMaTK(int matk)
        {
            using (SqlCommand cmd = new SqlCommand("  SELECT manv FROM TaiKhoan join nhanvien on TaiKhoan.MaTK = nhanvien.MaTK where TaiKhoan.MaTK = @matk", mydb.GetConnection))
            {
                cmd.Parameters.Add("@matk", SqlDbType.Int).Value = matk;
                mydb.OpenConnection();
                int manv = Convert.ToInt32(cmd.ExecuteScalar());
                mydb.CloseConnection();
                return manv;
            }
        }
        internal static void deleteAcc(string id)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM TaiKhoan WHERE matk = @id", mydb.GetConnection))
            {
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                mydb.OpenConnection();
                cmd.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static bool updateStatus(string id, int v)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE TaiKhoan SET status = @status WHERE matk = @id", mydb.GetConnection))
            {
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = v;
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
        public static DataTable getAcc(string username, string password)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE username = @user AND password = @pass", mydb.GetConnection))
            {
                cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
                mydb.OpenConnection();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
    }
}
