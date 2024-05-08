using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.EMPLOYEE
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }

        private void Import_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files |*.xlsx;*.xls;*.xlsm";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilename.Text = ofd.FileName;
            }
        }
        bool checkimport = true;
        char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] chars_so= "0123456789".ToCharArray();
        private void btnImport_Click(object sender, EventArgs e)
        {
            string path = txtFilename.Text;
            checkimport = true;
            if (path.Trim() != "")
            {
                //import data
                DataTable dt = new DataTable();
                dt = EMP.readExcel(path);
                stdListDataGridView.DataSource = dt;

 
                stdListDataGridView.Columns[0].HeaderText = "Họ tên";
                stdListDataGridView.Columns[1].HeaderText = "Phái";
                stdListDataGridView.Columns[2].HeaderText = "Ngày sinh";
                stdListDataGridView.Columns[3].HeaderText = "Địa chỉ";
                stdListDataGridView.Columns[4].HeaderText = "Số điện thoại";
                stdListDataGridView.Columns[5].HeaderText = "Mã chức vụ";
                stdListDataGridView.Columns[6].HeaderText = "Email";
                stdListDataGridView.Columns[8].HeaderText = "Mã người quản lý";

                //duyet qua cac dong trong datatable
                try
                {
                    for (int row = 0; row < dt.Rows.Count; row++)
                    {
                        //duyet qua cac cot trong datatable

                        //neu cot ten la rong thi hien thi thong bao
                        if (dt.Rows[row][0].ToString() == "")
                        {

                            checkimport = false;
                            throw new Exception(path + "Tên không được để trống" + "\nRow " + (row + 2).ToString() + " Column " + chars[1].ToString());
                            //MessageBox.Show("ID is required", "Error Line " + row.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //neu cot ten chứa số thì hien thi thong bao
                        if (dt.Rows[row][0].ToString().Any(char.IsDigit))
                        {
                            checkimport = false;
                            throw new Exception(path + "Tên ko đc chứa số" + "\nRow " + (row + 2).ToString() + " Column " + chars[1].ToString());
                            //MessageBox.Show("First name must not contain number" + "\nError Line " + (row+2).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //neu cot bdate khong dung dinh dang thi hien thi thong bao
                        if (!DateTime.TryParseExact(dt.Rows[row][2].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture,
                                                                  DateTimeStyles.None, out DateTime bdate))
                        {
                            checkimport = false;
                            throw new Exception(path + "Birthdate is not valid" + "\nRow " + (row + 2).ToString() + " Column " + chars[2].ToString());
                            //MessageBox.Show("Birthdate is not valid" + "\nError Line " + row.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //neu ma chuc vu khac 1,2,3 thi hien thi thong bao
                        if (dt.Rows[row][5].ToString() != "1" && dt.Rows[row][5].ToString() != "2" && dt.Rows[row][5].ToString() != "3")
                        {
                            checkimport = false;
                            throw new Exception(path + "Position is not valid" + "\nRow " + (row + 2).ToString() + " Column " + chars[3].ToString());
                            //MessageBox.Show("Position is not valid" + "\nError Line " + row.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Choose file to import data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_savetodb_Click(object sender, EventArgs e)
        {
            if (!checkimport)
            {
                MessageBox.Show("Please check your data again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dt = (DataTable)stdListDataGridView.DataSource;
            //insert all students from datatable to database
            MyDB mydb=new MyDB();
            mydb.OpenConnection();
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string hoten = dt.Rows[i]["hoten"].ToString();
                    string phai = dt.Rows[i]["phai"].ToString();
                    DateTimePicker ngaysinh = new DateTimePicker();
                    ngaysinh.Value = DateTime.ParseExact(dt.Rows[i]["ngaysinh"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture,
                                       DateTimeStyles.None);
                   
                    DateTime bdate = ngaysinh.Value;
                    int machucvu = int.Parse(dt.Rows[i]["machucvu"].ToString());

                    using (SqlCommand command = new SqlCommand("INSERT INTO NHANVIEN(hoten,phai,ngaysinh,machucvu) VALUES(@hoten,@phai,@ngaysinh,@machucvu)", mydb.GetConnection))
                    {
                        command.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
                        command.Parameters.Add("@phai", SqlDbType.NVarChar).Value = phai;
                        command.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = bdate;
                        command.Parameters.Add("@machucvu", SqlDbType.Int).Value = machucvu;
                        command.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Data imported successfully", "Imported", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mydb.CloseConnection();
            }
        }
    }
}
