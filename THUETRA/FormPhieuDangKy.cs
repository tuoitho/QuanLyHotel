using QuanLyHotel.EMPLOYEE;
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
    public partial class FormPhieuDangKy : Form
    {
        public FormPhieuDangKy()
        {
            InitializeComponent();
        }
        TT tt= new TT();
        KH kh = new KH();
        EMP emp = new EMP();
        PH ph= new PH();
        private void FormPhieuDangKy_Load(object sender, EventArgs e)
        {
            dataGridView_pdk.DataSource=tt.getDSPhieuDangKy();
            cboCustomer.DataSource = kh.getDSKhachHang();
            cboCustomer.DisplayMember = "MaKH";
            cboCustomer.ValueMember = "MaKH";
            cboEmployee.DataSource = emp.getDSNhanVien();
            cboEmployee.DisplayMember = "MaNV";
            cboEmployee.ValueMember = "MaNV";
            cboRoom.DataSource = ph.getDSPhong();
            cboRoom.DisplayMember = "MaPhong";
            cboRoom.ValueMember = "MaPhong";
        }

        private void button_hoanthanh_Click(object sender, EventArgs e)
        {
            {
                string mapdk = tb_mapdk.Text;
                try
                {
                    tt.danhDauPDKHoanThanh(mapdk);
                    //kiem tra hoa don da tao chua
                    if (tt.kiemTraHoaDonDaTao(mapdk) == false)
                        tt.taoHoaDon(mapdk);
                    MessageBox.Show("Hoàn thành phiếu đăng ký thành công", "Hoàn thành phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reload();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hoàn thành phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }

        private void dataGridView_pdk_Click(object sender, EventArgs e)
        {

            
        }

        private void dataGridView_pdk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_pdk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_pdk.Rows[e.RowIndex];
                // Lấy thông tin từ DataGridViewRow và hiển thị vào các control
                tb_mapdk.Text = row.Cells[0].Value.ToString();
                dtpExpectedArrival.Text = row.Cells[1].Value.ToString();
                dtpExpectedDeparture.Text = row.Cells[2].Value.ToString();
                txtDepositAmount.Text = row.Cells[3].Value.ToString();
                cboEmployee.SelectedItem = row.Cells[4].Value.ToString();
                cboCustomer.SelectedItem = row.Cells[5].Value.ToString();
                cboRoom.SelectedItem = row.Cells[6].Value.ToString();
                if (row.Cells[7].Value.ToString() == "Hoàn thành")
                {
                    button_hoanthanh.Enabled = false;
                    button_hethan.Enabled = false;
                }
                else if (row.Cells[7].Value.ToString() == "Hết hạn")
                {
                    button_hoanthanh.Enabled = false;
                    button_hethan.Enabled = false;
                    button_xemhd.Enabled = false;
                }
                else
                {
                    MessageBox.Show(row.Cells[7].Value.ToString());
                    button_hoanthanh.Enabled = true;
                    button_hethan.Enabled = true;
                }

                

                if (tt.kiemTraHoaDonDaTao(tb_mapdk.Text) == true)
                {
                    button_xemhd.Enabled = true;
                }
                else
                {
                    button_xemhd.Enabled = false;
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //anh xa
            DateTime expectedArrival = dtpExpectedArrival.Value;
            DateTime expectedDeparture = dtpExpectedDeparture.Value;
            string depositAmount = txtDepositAmount.Text;
            string employee = cboEmployee.SelectedValue.ToString();
            string customer = cboCustomer.SelectedValue.ToString();
            string room = cboRoom.SelectedValue.ToString();
            //them
            try
            {
                tt.themPhieuDangKy(expectedArrival, expectedDeparture, depositAmount, employee, customer, room);
                MessageBox.Show("Thêm thành công", "Thêm phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void reload()
        {
            dataGridView_pdk.DataSource = tt.getDSPhieuDangKy();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            //anh xa
            string mapdk = tb_mapdk.Text;
            DateTime expectedArrival = dtpExpectedArrival.Value;
            DateTime expectedDeparture = dtpExpectedDeparture.Value;
            double depositAmount = Convert.ToDouble(txtDepositAmount.Text);
            string employee = cboEmployee.SelectedValue.ToString();
            string customer = cboCustomer.SelectedValue.ToString();
            string room = cboRoom.SelectedValue.ToString();
            try
            {
                                tt.updatePhieuDangKy(mapdk, expectedArrival,expectedDeparture, depositAmount, employee, customer, room);
                MessageBox.Show("Cập nhật thành công", "Cập nhật phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cập nhật phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string mapdk = tb_mapdk.Text;
            try
            {
                tt.deletePhieuDangKy(mapdk);
                MessageBox.Show("Xóa thành công", "Xóa phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xóa phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_hethan_Click(object sender, EventArgs e)
        {
            string mapdk = tb_mapdk.Text;
            try
            {
                tt.danhDauPDKHetHan(mapdk);
                MessageBox.Show("Đánh dấu phiếu đăng ký hết hạn thành công", "Đánh dấu phiếu đăng ký hết hạn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đánh dấu phiếu đăng ký hết hạn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_xemhd_Click(object sender, EventArgs e)
        {
            string mapdk = tb_mapdk.Text;
            FormHoaDon formHoaDon = new FormHoaDon(mapdk);
            formHoaDon.ShowDialog();

        }

        private void dataGridView_pdk_SelectionChanged(object sender, EventArgs e)
        {

            
        }
    }
}
