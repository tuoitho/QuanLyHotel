using QuanLyHotel.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.EMPLOYEE
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementDataSet.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this.hotelManagementDataSet.Employees);
            comboBox_manql.DataSource = EMP.getDSNVQuanLy();
            comboBox_manql.DisplayMember = "manv";
            comboBox_manql.ValueMember = "manv";
            dataGridView_employee.AllowUserToAddRows = false;
            dataGridView_employee.DataSource = EMP.getDSNhanVien();
            dataGridView_employee.DefaultCellStyle.SelectionBackColor = Color.Purple;

        }

        private void FormNhanVien_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_employee_Click(object sender, EventArgs e)
        {
            //display data from datagridview to textbox
            txt_MaNV.Text = dataGridView_employee.CurrentRow.Cells[0].Value.ToString();
            txt_HoTen.Text = dataGridView_employee.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView_employee.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                rdnam.Checked = true;
            }
            else
            {
                rdnu.Checked = true;
            }
            datetimePicker_NgaySinh.Text = dataGridView_employee.CurrentRow.Cells[3].Value.ToString();

            txt_DiaChi.Text = dataGridView_employee.CurrentRow.Cells[4].Value.ToString();
            txt_SDT.Text = dataGridView_employee.CurrentRow.Cells[5].Value.ToString();
            if (dataGridView_employee.CurrentRow.Cells[6].Value.ToString() == "CV001")
            {
                radioButton_ql.Checked = true;
            }
            else if (dataGridView_employee.CurrentRow.Cells[6].Value.ToString() == "CV002")
            {
                radioButton_tt.Checked = true;
            }
            else
            {
                radioButton_lc.Checked = true;
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            string Name = txt_HoTen.Text;
            string gender=null;
            if (rdnam.Checked)
            {
                gender = "Nam";
            }
            else { gender = "Nữ"; }
            DateTime DOB = datetimePicker_NgaySinh.Value;
            string Address = txt_DiaChi.Text;
            string Phone = txt_SDT.Text;
            string Position = "CV001";
            String manql = comboBox_manql.Text;
            if (radioButton_tt.Checked)
            {
                Position = "CV002";
            }
            else if (radioButton_lc.Checked)
            {
                Position = "CV003";
            }
            if (comboBox_manql.Enabled == false)
                manql = null;
            try
            {
                EMP.insertNhanVien(Name, gender, DOB, Address, Phone, Position,manql);
                MessageBox.Show("New Employee Added", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_employee.DataSource = EMP.getDSNhanVien();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            string EmployeeID = (txt_MaNV.Text);
            string Name = txt_HoTen.Text;
            string gender = null;
            if (rdnam.Checked)
            {
                gender = "Nam";
            }
            else { gender = "Nữ"; }
            DateTime DOB = datetimePicker_NgaySinh.Value;
            string Address = txt_DiaChi.Text;
            string Phone = txt_SDT.Text;
            string Position = "CV001";
            if (radioButton_tt.Checked)
            {
                Position = "CV002";
            }
            else if (radioButton_lc.Checked)
            {
                Position = "CV003";
            }
            try
            {
                EMP.updateNhanVien(EmployeeID, Name, gender, DOB, Address, Phone, Position);
                MessageBox.Show("Employee Information Updated", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLoad_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //refresh datagridview
            dataGridView_employee.DataSource = EMP.getDSNhanVien();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //delete employee
            try
            {
                string EmployeeID = (txt_MaNV.Text);
                if (MessageBox.Show("Are you sure you want to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (EMP.deleteNhanVien(EmployeeID))
                    {
                        MessageBox.Show("Employee Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_MaNV.Text = "";
                        txt_HoTen.Text = "";
                        txt_DiaChi.Text = "";
                        txt_SDT.Text = "";
                        rdnam.Checked = true;
                        radioButton_ql.Checked = true;
                        datetimePicker_NgaySinh.Value = DateTime.Now;
                        dataGridView_employee.DataSource = EMP.getDSNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Employee Not Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton_ql_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ql.Checked)
            {
                comboBox_manql.Enabled = false;
            }
            else
            {
                comboBox_manql.Enabled = true;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_nhanvien.SelectedIndex == 1)
            {
                dataGridView_calamviec.DataSource = EMP.getDSCa();
            }
        }

        private void button_phanca_Click(object sender, EventArgs e)
        {
            DataTable ca= EMP.getDSCa();
            int soquanly=EMP.getDSNVQuanLy().Rows.Count;
            int sotieptan = EMP.getDSNVTiepTan().Rows.Count;
            int solaocong = EMP.getDSNVLaoCong().Rows.Count;
            int s1=1,s2=2,s3=4,c1=1,c2=2,c3=3,c32=4;
            PhanCa phanCa = new PhanCa(soquanly, sotieptan, solaocong,s1,s2,s3,c1,c2,c3,c32);
            PhanCa.ThucHien();
        }
        //su kien  chuyen tab


    }
}
