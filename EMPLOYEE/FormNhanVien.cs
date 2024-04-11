﻿using QuanLyHotel.Resources;
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
        MyDB mydb = new MyDB();
        EMP emp = new EMP();
        public FormNhanVien()
        {
            InitializeComponent();

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementDataSet.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this.hotelManagementDataSet.Employees);
            dataGridView_employee.AllowUserToAddRows = false;
            dataGridView_employee.DataSource = emp.getDSNhanVien();
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
                emp.insertNhanVien(Name, gender, DOB, Address, Phone, Position);
                MessageBox.Show("New Employee Added", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_employee.DataSource = emp.getDSNhanVien();
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
                emp.updateNhanVien(EmployeeID, Name, gender, DOB, Address, Phone, Position);
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
            dataGridView_employee.DataSource = emp.getDSNhanVien();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //delete employee
            try
            {
                string EmployeeID = (txt_MaNV.Text);
                if (MessageBox.Show("Are you sure you want to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (emp.deleteNhanVien(EmployeeID))
                    {
                        MessageBox.Show("Employee Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_MaNV.Text = "";
                        txt_HoTen.Text = "";
                        txt_DiaChi.Text = "";
                        txt_SDT.Text = "";
                        rdnam.Checked = true;
                        radioButton_ql.Checked = true;
                        datetimePicker_NgaySinh.Value = DateTime.Now;
                        dataGridView_employee.DataSource = emp.getDSNhanVien();
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
    }
}
