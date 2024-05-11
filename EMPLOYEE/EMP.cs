using OfficeOpenXml;
using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


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

        internal static DataTable getAllLichTheoNgayByMaCa(DateTime date, int maca)
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
                if (position == "1")
                {
                    sqlCommand.Parameters.Add("@manql", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    sqlCommand.Parameters.Add("@manql", SqlDbType.Int).Value = manql;
                }
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

        internal static int getMaPCHienTaiByMaNV(int manv)
        {
            using (
                //SqlCommand sqlCommand = new SqlCommand("SELECT MaPC FROM PhanCa join Ca on PhanCa.MaCa = Ca.MaCa WHERE MaNV = @manv AND CAST(Ca.BatDau AS TIME)  <= CAST(GETDATE() AS TIME) AND CAST(Ca.KetThuc as time)>= CAST(GETDATE() AS TIME) AND Ngay = CAST(GETDATE() AS DATE)", mydb.GetConnection)
                SqlCommand sqlCommand = new SqlCommand(" SELECT MaPC FROM PhanCa join Ca on PhanCa.MaCa = Ca.MaCa   WHERE MaNV = @manv   AND    DATEADD(HOUR,-7,CAST(Ca.BatDau AS TIME))  <= DATEADD(HOUR, -7, CAST(GETDATE() AS time))    AND DATEADD(HOUR,-7,CAST(Ca.KetThuc as time))>= DATEADD(HOUR, -7, CAST(GETDATE() AS time))  AND Ngay = CAST(GETDATE() AS DATE)", mydb.GetConnection)
                //phương pháp tịnh tiến thời gian.
                )
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
                //throw new Exception("Không thể check out sau 8 tiếng kể từ giờ check in");
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

        internal static DataTable getAllLichTheoNgayByMaNV_MaCa(DateTime date, int manv, int maca)
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
            using (SqlCommand sqlCommand = new SqlCommand("SELECT MaNV, Ngay, SUM(DATEDIFF(HOUR, GioDen, GioDi) * 60000) as [LuongNgay] FROM PhanCa where MaNV in (select MaNV from NhanVien where MaChucVu = 2) GROUP BY MaNV, Ngay HAVING Ngay = @date ", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.AddDays(-1);
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
            //truong hop lam 2 ca 1 ngay thi ko bat buoc nhan vien do phai lam, ko dc boc lot suc lao dong
            using (SqlCommand sqlCommand = new SqlCommand("SELECT MaNV, SUM(DATEDIFF(HOUR, GioDen, GioDi)) as [SoGio] FROM PhanCa WHERE Ngay = @date GROUP BY MaNV", mydb.GetConnection))
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

        internal static bool isDaTinhToanLuong(DateTime dateTime)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Luong WHERE Ngay = @date", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@date", SqlDbType.Date).Value = dateTime;
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

        internal static DataTable getDSLuongNgayTheoNgay()
        {
            //cua nhan vien ko la quan lys
            using (SqlCommand sqlCommand = new SqlCommand("SELECT Luong.MaNV,NhanVien.HoTen, Luong.Ngay, Luong.TienLuong FROM Luong join phanca on Luong.MaNV = PhanCa.MaNV and Luong.Ngay = PhanCa.Ngay join  NhanVien on Luong.MaNV = NhanVien.MaNV GROUP BY Luong.MaNV,NhanVien.HoTen, Luong.Ngay,Luong.TienLuong having Luong.MaNV in (select MaNV from NhanVien where MaChucVu != 1)", mydb.GetConnection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        internal static DataTable getDSLuongNgayTheoMaNVLC_Ngay()
        {

            using (SqlCommand sqlCommand = new SqlCommand("SELECT MaNV, Ngay, SUM(DATEDIFF(HOUR, GioDen, GioDi) * 40000) as [LuongNgay] FROM PhanCa where MaNV in (select MaNV from NhanVien where MaChucVu = 3) GROUP BY MaNV, Ngay HAVING Ngay = @date ", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.AddDays(-1);
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        internal static DataTable getAllDSBaoNghi(DateTime date, int chucvu)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PhanCa WHERE Ngay = @date AND MaNV in (SELECT MaNV FROM NhanVien WHERE MaChucVu = @chucvu) and Ghichu = N'Báo nghỉ'", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@date", SqlDbType.Date).Value = date;
                sqlCommand.Parameters.Add("@chucvu", SqlDbType.Int).Value = chucvu;
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
        internal static DataTable getAllDSBaoNghi(DateTime date)
        {
            using (SqlCommand sqlCommand = new SqlCommand("  SELECT * FROM PhanCa   WHERE Ngay = @date AND (GhiChu= N'Báo nghỉ' or GhiChu= N'Đã thay thế') ", mydb.GetConnection))
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

        internal static void thayThePhanCa(int mapc, int manv)
        {
            using (SqlCommand sqlCommand = new SqlCommand("UPDATE PhanCa SET GhiChu = N'Đã thay thế',MaNV=@manv whERE MaPC = @mapc", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
                sqlCommand.Parameters.Add("@mapc", SqlDbType.Int).Value = mapc;
                mydb.OpenConnection();
                sqlCommand.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static void baoNghiCa(int manv, int mapchientai)
        {
            //danh dau bao nghi
            using (SqlCommand sqlCommand = new SqlCommand("UPDATE PhanCa SET GhiChu = N'Báo nghỉ' WHERE MaNV = @manv AND MaPC = @mapc", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
                sqlCommand.Parameters.Add("@mapc", SqlDbType.Int).Value = mapchientai;
                mydb.OpenConnection();
                sqlCommand.ExecuteNonQuery();
                mydb.CloseConnection();
            }
        }

        internal static bool kiemtraCaThayThe(int mapchientai)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PhanCa WHERE MaPC = @mapc AND GhiChu = N'Đã thay thế'", mydb.GetConnection))
            {
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

        internal static void capnhattienthuongphat(int manv, DateTime ngay)
        {
            DataTable tbphancathaythe = new DataTable();
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PhanCa WHERE MaNV = @manv AND Ngay = @ngay AND GhiChu = N'Đã thay thế'", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
                sqlCommand.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    adapter.Fill(tbphancathaythe);
                }
            }
            for (int i = 0; i < tbphancathaythe.Rows.Count; i++)
            {
                double tienthuong = 0;
                double bouns = 0;
                int mcv = EMP.getChucVu(manv);
                if (mcv == 2)
                {
                    bouns = 120000;
                }
                else if (mcv == 3)
                {
                    bouns = 80000;
                }
                if (tbphancathaythe.Rows[i]["GioDen"] != DBNull.Value && tbphancathaythe.Rows[i]["GioDi"] != DBNull.Value)
                {
                    //lam tron xuong
                    tienthuong = ((int)((Convert.ToDateTime(tbphancathaythe.Rows[i]["GioDi"])
                        - Convert.ToDateTime(tbphancathaythe.Rows[i]["GioDen"])).TotalHours)) * bouns;
                    if (manv == 5) MessageBox.Show(tienthuong.ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE ThuongPhat SET Tien = Tien+@tien WHERE MaNV = @manv AND Ngay = @ngay", mydb.GetConnection))
                {
                    sqlCommand.Parameters.Add("@tien", SqlDbType.Float).Value = tienthuong;
                    sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
                    sqlCommand.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;
                    mydb.OpenConnection();
                    sqlCommand.ExecuteNonQuery();
                    mydb.CloseConnection();

                }
            }
        }

        internal static double getTienThuongPhat(int manv, DateTime ngay)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT Tien FROM ThuongPhat WHERE MaNV = @manv AND Ngay = @ngay", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
                sqlCommand.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;
                mydb.OpenConnection();
                double tien = Convert.ToDouble(sqlCommand.ExecuteScalar());
                mydb.CloseConnection();
                return tien;

            }
        }

        internal static DataTable getDSLuongNgayCaChinhTheoMaNVTT_Ngay()
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT MaNV, Ngay, SUM(DATEDIFF(HOUR, GioDen, GioDi) * 60000) as [LuongNgay] FROM PhanCa where ghichu!=N'Đã thay thế' and MaNV in (select MaNV from NhanVien where MaChucVu = 2) GROUP BY MaNV, Ngay HAVING Ngay = @date ", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.AddDays(-1);
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        internal static Dictionary<int, int> getDictSoGioLamViecCaChinhTheoNgay(DateTime dateTime)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT MaNV, SUM(DATEDIFF(HOUR, GioDen, GioDi)) as [SoGio] FROM PhanCa WHERE Ngay = @date and (ghichu !=N'Đã thay thế' or ghichu is null)GROUP BY MaNV", mydb.GetConnection))
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

        internal static DataTable getDSLuongNgayCaChinhTheoMaNVLC_Ngay()
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT MaNV, Ngay, SUM(DATEDIFF(HOUR, GioDen, GioDi) * 40000) as [LuongNgay] FROM PhanCa where ghichu!=N'Đã thay thế' and MaNV in (select MaNV from NhanVien where MaChucVu = 3) GROUP BY MaNV, Ngay HAVING Ngay = @date ", mydb.GetConnection))
            {
                sqlCommand.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.AddDays(-1);
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        internal static DataTable getDSChiTietCaDaLam(int manv, DateTime ngay)
        {
            SqlCommand cmd = new SqlCommand("select PhanCa.MaNV,PhanCa.Ngay,SUm(ISNULL(DATEDIFF(HOUR,PhanCa.GioDen ,PhanCa.GioDi),0)) as SoGioLam,ISNULL(PhanCa.GhiChu,N'Ca chính') as 'Loại(ca chính/ca đã thay thế))' from PhanCa where MaNV = @manv and Ngay = @ngay GROUP BY PhanCa.MaNV,PhanCa.Ngay,PhanCa.GhiChu", mydb.GetConnection);
            cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;
            cmd.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable readExcel(string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                // Lấy sheet đầu tiên
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];

                // Tạo DataTable
                DataTable dataTable = new DataTable();

                //thiet lap datatable giong voi databasee
                dataTable.Columns.Add("hoten");
                
                dataTable.Columns.Add("phai");
                dataTable.Columns.Add("ngaysinh");
                dataTable.Columns.Add("diachi");
                dataTable.Columns.Add("sdt");
                dataTable.Columns.Add("machucvu");
                dataTable.Columns.Add("email");
                dataTable.Columns.Add("matk");
                dataTable.Columns.Add("manql");
                // thêm dữ liệu
                for (int i = 2; i <= worksheet.Dimension.End.Row - 1; i++)
                {
                    DataRow row = dataTable.NewRow();
                    for (int j = 1; j <= worksheet.Dimension.End.Column; j++)
                    {
                        //giong database, neu ko co thi tam thoi null co the edit sau
                        row["hoten"] = worksheet.Cells[i, 2].Value.ToString();
                        row["phai"] = worksheet.Cells[i, 3].Value.ToString();
                        row["ngaysinh"] = worksheet.Cells[i, 4].Value.ToString();
                        row["machucvu"] = worksheet.Cells[i, 5].Value.ToString();
                    }
                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
        }
    }
}
