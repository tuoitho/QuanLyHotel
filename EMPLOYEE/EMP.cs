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

        public static bool deleteNhanVien(int employeeID)
        {
            //cap nhat ma nguoi quan ly cua nhung nhan vien thuoc nhan vien nay = NULL
            SqlCommand sqlCommand = new SqlCommand("UPDATE NhanVien SET manql = NULL WHERE manql = @eid;"
                + "DELETE FROM NhanVien WHERE manv = @eid", mydb.GetConnection);
            //SqlCommand sqlCommand = new SqlCommand("DELETE FROM NhanVien WHERE manv = @eid", mydb.GetConnection);
            sqlCommand.Parameters.Add("@eid", SqlDbType.Int).Value = employeeID;
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

        internal static DataTable getAllLichTheoNgayByMaCa(DateTime date,int maca)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PhanCa WHERE ngay = @date and MaCa=@mc", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@date", SqlDbType.Date).Value = date;
                sqlCommand.Parameters.Add("@mc", SqlDbType.Int).Value = maca;
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

        internal static void deletePhanCa(DateTime batdau, int sotuan)
        {
            using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM PhanCa WHERE ngay >= @batdau AND ngay < @ketthuc", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@batdau", SqlDbType.Date).Value = batdau;
                sqlCommand.Parameters.Add("@ketthuc", SqlDbType.Date).Value = batdau.AddDays(sotuan * 7);
                mydb.OpenConnection();
                sqlCommand.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static void insertNhanVien(string name, string gender, DateTime dOB, string address, string phone, string position, string email, int manql)
        {
            using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO NhanVien (hoten, phai, ngaysinh, diachi, sdt, machucvu, email, manql) VALUES (@name, @gender, @dob, @address, @phone, @position, @email, @manql)", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                sqlCommand.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
                sqlCommand.Parameters.Add("@dob", SqlDbType.Date).Value = dOB;
                sqlCommand.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                sqlCommand.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
                sqlCommand.Parameters.Add("@position", SqlDbType.VarChar).Value = position;
                sqlCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                sqlCommand.Parameters.Add("@manql", SqlDbType.Int).Value = manql;
                mydb.OpenConnection();
                sqlCommand.ExecuteNonQuery();
                mydb.CloseConnection();

            }
        }

        internal static void updateNhanVien(int employeeID, string name, string gender, DateTime dOB, string address, string phone, string position, string email, int manql)
        {
           using (SqlCommand sqlCommand = new SqlCommand("UPDATE NhanVien SET hoten = @name, phai = @gender, ngaysinh = @dob, diachi = @address, sdt = @phone, machucvu = @position, email = @email, manql = @manql WHERE manv = @employeeID", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@employeeID", SqlDbType.Int).Value = employeeID;
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                sqlCommand.Parameters.Add("@gender", SqlDbType.NVarChar).Value= gender;
                sqlCommand.Parameters.Add("@dob", SqlDbType.Date).Value = dOB;
                sqlCommand.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                sqlCommand.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
                sqlCommand.Parameters.Add("@position", SqlDbType.VarChar).Value = position;
                sqlCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                sqlCommand.Parameters.Add("@manql", SqlDbType.Int).Value = manql;
                mydb.OpenConnection();
                sqlCommand.ExecuteNonQuery();
                mydb.CloseConnection();

            }
        }

        internal static int getMaPCHienTaiByMaNV(int manv)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT MaPC\r\nFROM PhanCa join Ca on PhanCa.MaCa = Ca.MaCa\r\nWHERE MaNV = @manv AND CAST(Ca.BatDau AS TIME)  <= CAST(GETDATE() AS TIME) AND CAST(Ca.KetThuc as time)>= CAST(GETDATE() AS TIME) AND Ngay = CAST(GETDATE() AS DATE)", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
                mydb.OpenConnection();
                if (sqlCommand.ExecuteScalar() != null)
                {
                    return Convert.ToInt32(sqlCommand.ExecuteScalar());
                }
                else
                {
                    return -1;
                }
            }
        }

        internal static void checkInPC(int manv, int mapchientai)
        {
            using (SqlCommand sqlCommand = new SqlCommand("UPDATE PhanCa SET GioDen = GETDATE() WHERE MaNV = @manv AND MaPC = @mapc", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
                sqlCommand.Parameters.Add("@mapc", SqlDbType.Int).Value = mapchientai;
                mydb.OpenConnection();
                sqlCommand.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }
        public static DateTime getGioDenByMaPC(int mapc)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT GioDen FROM PhanCa WHERE MaPC = @mapc", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@mapc", SqlDbType.Int).Value = mapc;
                mydb.OpenConnection();
                return Convert.ToDateTime(sqlCommand.ExecuteScalar());
            }
        }
        internal static void checkOutPC(int manv, int mapchientai)
        {
            DateTime gioDi = DateTime.Now;
            DateTime gioDen = getGioDenByMaPC(mapchientai);
            if (gioDen.AddHours(8) < DateTime.Now)
            {
                throw new Exception("Không thể check out sau 8 tiếng kể từ giờ check in");
                gioDi = gioDen.AddHours(8);
            }
            using (SqlCommand sqlCommand = new SqlCommand("UPDATE PhanCa SET GioDi =@giodi WHERE MaNV = @manv AND MaPC = @mapc", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@giodi", SqlDbType.DateTime).Value = gioDi;
                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
                sqlCommand.Parameters.Add("@mapc", SqlDbType.Int).Value = mapchientai;
                mydb.OpenConnection();
                sqlCommand.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static DataTable getAllLichTheoNgayByMaNV_MaCa(DateTime date, int manv,int maca)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT PhanCa.* FROM PhanCa  WHERE Ngay = @date AND MaNV = @manv and MaCa=@maca", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@date", SqlDbType.Date).Value = date;
                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
                sqlCommand.Parameters.Add("@maca", SqlDbType.Int).Value = maca;
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        internal static bool kiemtracheckInPC(int id, int mapchientai)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PhanCa WHERE MaNV = @manv AND MaPC = @mapc AND GioDen IS NOT NULL", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = id;
                sqlCommand.Parameters.Add("@mapc", SqlDbType.Int).Value = mapchientai;
                mydb.OpenConnection();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        internal static bool kiemtracheckOutPC(int id, int mapchientai)
        {
           using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PhanCa WHERE MaNV = @manv AND MaPC = @mapc AND GioDi IS NOT NULL", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = id;
                sqlCommand.Parameters.Add("@mapc", SqlDbType.Int).Value = mapchientai;
                mydb.OpenConnection();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        internal static DataTable getDSLuongNgayTheoMaNVTT_Ngay()
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT MaNV, Ngay, SUM(DATEDIFF(HOUR, GioDen, GioDi) * 60000) as [LuongNgay]\r\nFROM PhanCa\r\nwhere MaNV in (select MaNV from NhanVien where MaChucVu = 2)\r\nGROUP BY MaNV, Ngay\r\nHAVING Ngay = '2024-5-4'\r\n", mydb.GetConnection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        internal static Dictionary<int, int> getDictSoGioLamViecTheoNgay(DateTime dateTime)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT MaNV, SUM(DATEDIFF(HOUR, GioDen, GioDi)) as [SoGio]\r\nFROM PhanCa\r\nWHERE Ngay = @date\r\nGROUP BY MaNV", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@date", SqlDbType.Date).Value = dateTime;
                mydb.OpenConnection();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    Dictionary<int, int> dict = new Dictionary<int, int>();
                    while (reader.Read())
                    {
                        if (reader.IsDBNull(1))
                        {
                            dict.Add(reader.GetInt32(0), 0);
                        }
                        else
                            dict.Add(reader.GetInt32(0), reader.GetInt32(1));
                    }
                    return dict;
                }
            }
        }

        internal static void insertLuongNV(int manv, DateTime ngay, double tienluong)
        {
            //insert vao bang luong
            using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Luong (MaNV, Ngay, TienLuong) VALUES (@manv, @ngay, @tienluong)", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
                sqlCommand.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;
                sqlCommand.Parameters.Add("@tienluong", SqlDbType.Float).Value = tienluong;
                mydb.OpenConnection();
                sqlCommand.ExecuteNonQuery();
                mydb.CloseConnection();

            }
        }

        internal static void insertHinhPhat(int manv, DateTime dateTime, double tien)
        {
            using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Thuongphat (MaNV, Ngay, Tien) VALUES (@manv, @ngay, @tienphat)", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
                sqlCommand.Parameters.Add("@ngay", SqlDbType.Date).Value = dateTime;
                sqlCommand.Parameters.Add("@tienphat", SqlDbType.Float).Value = tien;
                mydb.OpenConnection();
                sqlCommand.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }
    }
}
