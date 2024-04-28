using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Telerik.Charting.Styles;
using Telerik.WinControls.UI.Map.Bing;

namespace QuanLyHotel.EMPLOYEE
{
    public class EMP
    {
        static MyDB mydb = new MyDB();
        public static DataTable getDSNhanVien()
        {
            mydb.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM NhanVien", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            mydb.CloseConnection();
            return table;
        }
        public static bool insertNhanVien(string Name, string Gender, DateTime DOB, string Address, string Phone, string Position)
        {

            SqlCommand command = new SqlCommand("INSERT INTO NhanVien (Hoten, phai, ngaysinh, diachi, sdt, machucvu) VALUES ( @name, @gender, @dob, @address, @phone, @position)", mydb.GetConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = Gender;
            command.Parameters.Add("@dob", SqlDbType.Date).Value = DOB;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = Address;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@position", SqlDbType.VarChar).Value = Position;
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
        public static bool updateNhanVien(string EmployeeID, string Name, string Gender, DateTime DOB, string Address, string Phone, string Position)
        {
            //update nhanvien theo id
            SqlCommand command = new SqlCommand("UPDATE NhanVien SET hoten = @name, phai = @gender, Ngaysinh = @dob, diachi = @address, sdt = @phone, machucvu = @position WHERE manv = @employeeID", mydb.GetConnection);
            command.Parameters.Add("@employeeID", SqlDbType.VarChar).Value = EmployeeID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@gender", SqlDbType.NVarChar
                ).Value = Gender;
            command.Parameters.Add("@dob", SqlDbType.Date).Value = DOB;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = Address;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@position", SqlDbType.VarChar).Value = Position;
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

        public static bool deleteNhanVien(string employeeID)
        {
            //cap nhat ma nguoi quan ly cua nhung nhan vien thuoc nhan vien nay = NULL
            SqlCommand sqlCommand = new SqlCommand("UPDATE NhanVien SET manql = NULL WHERE manql = @eid;"
                + "DELETE FROM NhanVien WHERE manv = @eid", mydb.GetConnection);
            //SqlCommand sqlCommand = new SqlCommand("DELETE FROM NhanVien WHERE manv = @eid", mydb.GetConnection);
            sqlCommand.Parameters.Add("@eid", SqlDbType.VarChar).Value = employeeID;
            mydb.OpenConnection();
            //THUC thi nhieu cau lenh sql trong cung 1 command
            if (sqlCommand.ExecuteNonQuery() > 0)
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

        public static DataTable getDSNVQuanLy()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT manv FROM NhanVien WHERE machucvu = 1", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }


        public static bool insertNhanVien(string Name, string Gender, DateTime DOB, string Address, string Phone, string Position, String manql)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NhanVien (Hoten, phai, ngaysinh, diachi, sdt, machucvu,manql) VALUES ( @name, @gender, @dob, @address, @phone, @position,@nql)", mydb.GetConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = Gender;
            command.Parameters.Add("@dob", SqlDbType.Date).Value = DOB;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = Address;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@position", SqlDbType.VarChar).Value = Position;
            object valueForParameter = (manql is null) ? DBNull.Value : (object)manql;
            command.Parameters.Add("@nql", SqlDbType.VarChar).Value = valueForParameter;
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
        public static DataTable getDSCa()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Ca", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        internal static DataTable getDSNVTiepTan()
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM NhanVien WHERE machucvu = 2", mydb.GetConnection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        internal static DataTable getDSNVLaoCong()
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM NhanVien WHERE machucvu = 3", mydb.GetConnection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
        public static void insertPhanCa(int maca, int manhanvien, DateTime ngay)
        {
            using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO PhanCa (maca, manv, ngay) VALUES (@maca, @manv, @ngay)", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@maca", SqlDbType.Int).Value = maca;
                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = manhanvien;
                sqlCommand.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;
                mydb.OpenConnection();
                sqlCommand.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static int getChucVu(int manv)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT machucvu FROM NhanVien WHERE manv = @manv", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
                mydb.OpenConnection();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        internal static DataTable getAllLichLamViec()
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PhanCa", mydb.GetConnection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        internal static DataTable getAllLichTheoNgay(DateTime date)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PhanCa WHERE ngay = @date", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@date", SqlDbType.Date).Value = date;
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        internal static void updateCa(DataTable dataTable)
        {
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE Ca SET ql = @ql, tt = @tt, lc = @lc WHERE maca = @maca", mydb.GetConnection))
                {
                    sqlCommand.Parameters.Add("@ql", SqlDbType.Int).Value = dataTable.Rows[i]["ql"];
                    sqlCommand.Parameters.Add("@tt", SqlDbType.Int).Value = dataTable.Rows[i]["tt"];
                    sqlCommand.Parameters.Add("@lc", SqlDbType.Int).Value = dataTable.Rows[i]["lc"];
                    sqlCommand.Parameters.Add("@maca", SqlDbType.Int).Value = dataTable.Rows[i]["maca"];
                        mydb.OpenConnection();
                    sqlCommand.ExecuteNonQuery();
                    mydb.CloseConnection();
                }
            }
        }
    }
}
