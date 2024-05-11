using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel
{
    public partial class FormRegister : Form
    {
        int time = 60;
        string randomCode;
        public static string to;
        MyDB mydb = new MyDB();
        public FormRegister()
        {
            InitializeComponent();
        }


        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = textBoxEmail.Text.Trim();
            from = "levanbay0101196868@gmail.com"; //email của bạn
            pass = "kwwx fzcb tcfn bwuq"; // pass email
            messageBody = "Code: " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Account creation code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new System.Net.NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                timerSendCode.Enabled = true;
                MessageBox.Show("Code sent successfully, please check your email");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timerSendCode_Tick(object sender, EventArgs e)
        {
            if (time >= 0)
            {
                button_getcode.Enabled = false;
                label_noti.Text = "Resend code in " + time + " seconds";
                time--;
            }
            else
            {
                label_noti.Text = "";
                time = 60;
                button_getcode.Enabled = true;
                timerSendCode.Enabled = false;
            }
        }

        private void button_check_Click(object sender, EventArgs e)
        {

            mydb.OpenConnection();

            if (radioButton_nv.Checked)
            {
                using (SqlCommand cmd = new SqlCommand("select * from NhanVien where email = @email", mydb.GetConnection))
                {
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = textBoxEmail.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Bạn không phải nhân viên của chúng tôi");
                        return;
                    }
                    //kiem tra xem nhan vien nay da co tai khoan chua, neu co roi thi khong cho tao ma yeu cau quen mat khau
                    //lay ra matk cua nhan vien
                    using (SqlCommand cmd1 = new SqlCommand("select matk from NhanVien where email = @email", mydb.GetConnection))
                    {
                        cmd1.Parameters.Add("@email", SqlDbType.VarChar).Value = textBoxEmail.Text;
                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                        DataTable table1 = new DataTable();
                        adapter1.Fill(table1);
                        if (table1.Rows[0][0].ToString() != "")
                        {
                            MessageBox.Show("Bạn đã có tài khoản, không thể tạo tài khoản mới, bạn có thể đăng nhập bằng tài khoản cũ, hoặc sử dụng chức năng quên mật khẩu nếu bạn quên mật khẩu");
                            return;
                        }
                    }

                    MessageBox.Show("Bạn là nhân viên của chúng tôi và chưa có tài khoản, vui lòng nhập mã xác nhận để tiếp tục tạo tài khoản");
                }
            }
            else
            {
                using (SqlCommand cmd = new SqlCommand("select * from KhachHang where email = @email", mydb.GetConnection))
                {
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = textBoxEmail.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Bạn không phải khách hàng của chúng tôi");
                        return;
                    }
                    //kiem tra xem nhan vien nay da co tai khoan chua, neu co roi thi khong cho tao ma yeu cau quen mat khau
                    //lay ra matk 
                    using (SqlCommand cmd1 = new SqlCommand("select matk from KhachHang where email = @email", mydb.GetConnection))
                    {
                        cmd1.Parameters.Add("@email", SqlDbType.VarChar).Value = textBoxEmail.Text;
                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                        DataTable table1 = new DataTable();
                        adapter1.Fill(table1);
                        if (table1.Rows[0][0].ToString() != "")
                        {
                            MessageBox.Show("Bạn đã có tài khoản, không thể tạo tài khoản mới, bạn có thể đăng nhập bằng tài khoản cũ, hoặc sử dụng chức năng quên mật khẩu nếu bạn quên mật khẩu");
                            return;
                        }
                    }
                    MessageBox.Show("Bạn là khách hàng của chúng tôi và chưa có tk, vui lòng nhập mã xác nhận để tiếp tục");
                }
            }
            button_getcode.Enabled = true;
            textBoxCode.Enabled = true;

        }

        private void button_checkcode_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your code", "Forget Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (randomCode == textBoxCode.Text.ToString() || false)
            {
                to = textBoxEmail.Text;
                groupBox1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Wrong code");
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string username = textBox_u.Text;
            string password = textBox_p.Text;
            if (username.Trim() == "" || password.Trim() == "")
            {
                MessageBox.Show("Please enter your username and password", "Forget Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //check username exist
            using (SqlCommand cmd = new SqlCommand("select * from taikhoan where username = @username", mydb.GetConnection))
            {
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Username already exists", "Forget Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            using (SqlCommand cmd = new SqlCommand("insert into taikhoan(username,password,role) values(@username, @password,@role)", mydb.GetConnection))
            {
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                string role = "";
                if (radioButton_nv.Checked)
                {
                    role = "employee";
                }
                else
                {
                    role = "customer";
                }
                cmd.Parameters.Add("@role", SqlDbType.VarChar).Value = role;
                mydb.OpenConnection();
                try { cmd.ExecuteNonQuery(); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    mydb.CloseConnection();
                    return;
                }

                //cap nhat lai bang nhan vien hoac khach hang
                //lay ra id cua tai khoan vua tao
                try
                {
                    using (SqlCommand cmd1 = new SqlCommand("select matk from taikhoan where username = @username", mydb.GetConnection))
                    {
                        cmd1.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        int id = Convert.ToInt32(table.Rows[0][0].ToString());
                        if (radioButton_nv.Checked)
                        {
                            using (SqlCommand cmd2 = new SqlCommand("update NhanVien set matk = @id where email = @email", mydb.GetConnection))
                            {
                                cmd2.Parameters.Add("@id", SqlDbType.Int).Value = id;
                                cmd2.Parameters.Add("@email", SqlDbType.VarChar).Value = to;
                                cmd2.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            using (SqlCommand cmd2 = new SqlCommand("update KhachHang set matk = @id where email = @email", mydb.GetConnection))
                            {
                                cmd2.Parameters.Add("@id", SqlDbType.Int).Value = id;
                                cmd2.Parameters.Add("@email", SqlDbType.VarChar).Value = to;
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    mydb.CloseConnection();
                    return;
                }
                MessageBox.Show("Tạo tài khoản thành công", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel1.Enabled = false;
                mydb.CloseConnection();

            }
        }
    }
}
