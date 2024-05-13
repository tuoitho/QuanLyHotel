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
    public partial class FormThemMoiPDK : Form
    {
        public FormThemMoiPDK()
        {
            InitializeComponent();
        }

        private void FormThemMoiPDK_Load(object sender, EventArgs e)
        {
            cboCustomer.DataSource = KH.getDSKhachHang();
            cboCustomer.DisplayMember = "MaKH";
            cboCustomer.ValueMember = "MaKH";
            cboRoom.DataSource = PH.getDSPhongTrong();
            cboRoom.DisplayMember = "MaPhong";
            cboRoom.ValueMember = "MaPhong";


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
            int customer = Convert.ToInt32(cboCustomer.SelectedValue.ToString());
            int room = Convert.ToInt32(cboRoom.SelectedValue.ToString());
            //them
            try
            {
                TT.themPhieuDangKy(expectedArrival, expectedDeparture, depositAmount, customer, room);
                PH.danhDauPhong(room, 1);
                //tra ve dialog result
                MessageBox.Show("Thêm phiếu đăng ký thành công", "Thêm phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roundedButton_selet_Click(object sender, EventArgs e)
        {

            FormSelectKhachHang formSelectKhachHang = new FormSelectKhachHang();
            formSelectKhachHang.dataGridView_kh.DataSource = KH.getDSKhachHang();
            formSelectKhachHang.dataGridView_kh.CellClick += (s, ev) =>
            {
                cboCustomer.SelectedValue = formSelectKhachHang.dataGridView_kh.CurrentRow.Cells[0].Value.ToString();
            };
            formSelectKhachHang.Show();


        }

        private void roundedButton_selectroom_Click(object sender, EventArgs e)
        {
            FormSelectPhong formSelectPhong = new FormSelectPhong();
            formSelectPhong.dataGridView_phong.DataSource = PH.getDSPhongTrong();
            formSelectPhong.dataGridView_phong.CellClick += (s, ev) =>
            {
                cboRoom.SelectedValue = formSelectPhong.dataGridView_phong.CurrentRow.Cells[0].Value.ToString();
            };
            formSelectPhong.Show();

        }
    }
}
