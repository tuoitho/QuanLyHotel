using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHotel.EMPLOYEE
{
    public class EMP
    {
        MyDB mydb = new MyDB();
        public DataTable getDSNhanVien()
        {
            mydb.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM NhanVien", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            mydb.CloseConnection();
            return table;
        }
        public bool insertNhanVien( string Name, string Gender, DateTime DOB, string Address, string Phone, string Position)
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
        public bool updateNhanVien(string EmployeeID, string Name, string Gender, DateTime DOB, string Address, string Phone, string Position)
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

        public bool deleteNhanVien(string employeeID)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM NhanVien WHERE manv = @eid", mydb.GetConnection);
            sqlCommand.Parameters.Add("@eid", SqlDbType.VarChar).Value = employeeID;
            mydb.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
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
