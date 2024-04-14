﻿using QuanLyHotel.EMPLOYEE;
using QuanLyHotel.KHACHHANG;
using QuanLyHotel.PHONG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.THUETRA
{
    public partial class FormThemMoiPDK : Form
    {
        public FormThemMoiPDK()
        {
            InitializeComponent();
        }
        KH kh = new KH();
        TT tt = new TT();
        PH ph = new PH();
        EMP emp = new EMP();
        private void FormThemMoiPDK_Load(object sender, EventArgs e)
        {
            cboCustomer.DataSource = kh.getDSKhachHang();
            cboCustomer.DisplayMember = "MaKH";
            cboCustomer.ValueMember = "MaKH";
            cboRoom.DataSource = ph.getDSPhongTrong();
            cboRoom.DisplayMember = "MaPhong";
            cboRoom.ValueMember = "MaPhong";
            cboEmployee.DataSource = emp.getDSNhanVien();
            cboEmployee.DisplayMember = "MaNV";
            cboEmployee.ValueMember = "MaNV";

        }
        private void button_add_Click(object sender, EventArgs e)
        {
            //anh xa
            DateTime expectedArrival = dtpExpectedArrival.Value;
            DateTime expectedDeparture = dtpExpectedDeparture.Value;
            if (expectedArrival > expectedDeparture)
            {
                MessageBox.Show("Ngày đến phải trước ngày đi", "Thêm phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //ít nhất 1 đêm
            if (expectedDeparture.Date == expectedArrival.Date)
            {
                MessageBox.Show("Phải ở ít nhất 1 đêm", "Thêm phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string depositAmount = txtDepositAmount.Text;
            string employee = cboEmployee.SelectedValue.ToString();
            string customer = cboCustomer.SelectedValue.ToString();
            string room = cboRoom.SelectedValue.ToString();
            //them
            try
            {
                tt.themPhieuDangKy(expectedArrival, expectedDeparture, depositAmount, employee, customer, room);
                ph.danhDauPhong(room, 1);
                //tra ve dialog result
                MessageBox.Show("Thêm phiếu đăng ký thành công", "Thêm phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}