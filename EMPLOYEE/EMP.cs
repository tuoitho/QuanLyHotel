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
            SqlCommand command = new SqlCommand("SELECT * FROM Employees", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            mydb.CloseConnection();
            return table;
        }
        public bool insertNhanVien(int EmployeeID, string Name, string Gender, DateTime DOB, string Address, string Phone, int Position)
        {

            SqlCommand command = new SqlCommand("INSERT INTO Employees (EmployeeID, Name, Gender, DOB, Address, Phone, PositionID) VALUES (@eid, @name, @gender, @dob, @address, @phone, @position)", mydb.GetConnection);
            command.Parameters.Add("@eid", SqlDbType.Int).Value = EmployeeID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = Gender;
            command.Parameters.Add("@dob", SqlDbType.Date).Value = DOB;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = Address;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@position", SqlDbType.Int).Value = Position;
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
        public bool updateNhanVien(int EmployeeID, string Name, string Gender, DateTime DOB, string Address, string Phone, int Position)
        {
            //update nhanvien theo id
            SqlCommand command = new SqlCommand("UPDATE Employees SET Name = @name, Gender = @gender, DOB = @dob, Address = @address, Phone = @phone, PositionID = @position WHERE EmployeeID = @employeeID", mydb.GetConnection);
            command.Parameters.Add("@employeeID", SqlDbType.Int).Value = EmployeeID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@gender", SqlDbType.NVarChar
                ).Value = Gender;
            command.Parameters.Add("@dob", SqlDbType.Date).Value = DOB;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = Address;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@position", SqlDbType.Int).Value = Position;
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

        public bool deleteNhanVien(int employeeID)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Employees WHERE EmployeeID = @eid", mydb.GetConnection);
            sqlCommand.Parameters.Add("@eid", SqlDbType.Int).Value = employeeID;
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
