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
using Telerik.WinControls.VirtualKeyboard;
namespace QuanLyHotel.THUETRA
{
    public partial class FormPhieuDangKy : Form
    {
        public FormPhieuDangKy()
        {
            InitializeComponent();
            dataGridView_pdk.DefaultCellStyle.SelectionBackColor = Color.Purple;

        }

        private void FormPhieuDangKy_Load(object sender, EventArgs e)
        {
            dataGridView_pdk.DataSource=TT.getDSPhieuDangKy();
            dataGridView_pdk.Columns[1].AutoSizeMode = dataGridView_pdk.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cboCustomer.DataSource = KH.getDSKhachHang();
            cboCustomer.DisplayMember = "MaKH";
            cboCustomer.ValueMember = "MaKH";
            cboRoom.DataSource = PH.getDSPhong();
            cboRoom.Enabled = false;
            cboRoom.DisplayMember = "MaPhong";
            cboRoom.ValueMember = "MaPhong";

            //select row 0 if there is any row in datagridview
            if (dataGridView_pdk.Rows.Count > 0)
            {
                dataGridView_pdk.Rows[0].Selected = true;
                DataGridViewRow row = dataGridView_pdk.CurrentRow;
                // Lấy thông tin từ DataGridViewRow và hiển thị vào các control
                tb_mapdk.Text = row.Cells[0].Value.ToString();
                dtpExpectedArrival.Text = row.Cells[1].Value.ToString();
                dtpExpectedDeparture.Text = row.Cells[2].Value.ToString();
                txtDepositAmount.Text = row.Cells[3].Value.ToString();
                cboCustomer.SelectedItem = row.Cells[5].Value.ToString();
                cboRoom.SelectedItem = row.Cells[6].Value.ToString();
                if (row.Cells[6].Value.ToString() == "Hoàn thành")
                {
                    button_hoanthanh.Enabled = false;
                    button_hethan.Enabled = false;
                    btn_modify.Enabled = false;
                }
                else if (row.Cells[6].Value.ToString() == "Hết hạn")
                {
                    button_hoanthanh.Enabled = false;
                    button_hethan.Enabled = false;
                    button_xemhd.Enabled = false;
                    btn_modify.Enabled = false;
                }
                else
                {
                    button_hoanthanh.Enabled = true;
                    btn_modify.Enabled = true;
                    button_hethan.Enabled = true;
                }

                if (TT.kiemTraHoaDonDaTao(Convert.ToInt32(tb_mapdk.Text)) == true)
                {
                    button_xemhd.Enabled = true;
                }
                else
                {
                    button_xemhd.Enabled = false;
                }

            }            


        }

        private void button_hoanthanh_Click(object sender, EventArgs e)
        {
            {
                int mapdk = Convert.ToInt32(tb_mapdk.Text);
                try
                {
                    TT.danhDauPDKHoanThanh(mapdk);
                    //kiem tra hoa don da tao chua
                    if (TT.kiemTraHoaDonDaTao(mapdk) == false)
                        TT.taoHoaDon(mapdk);
                    MessageBox.Show("Hoàn thành phiếu đăng ký thành công", "Hoàn thành phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int index = dataGridView_pdk.SelectedRows[0].Index;
                    reload(index);
                    dataGridView_pdk.Rows[index].Selected = true;
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
                if (cboCustomer.Items.Count > 0)
                {
                    if (row.Cells[4].Value.ToString() != "")
                    cboCustomer.SelectedItem = row.Cells[4].Value.ToString();
                    else
                    {
                        //ko co khach hang nao duoc chon
                        cboCustomer.SelectedIndex = -1;
                    }
                }

                //cboRoom.SelectedItem = row.Cells[6].Value.ToString();
                if (cboRoom.Items.Count > 0)
                {
                    cboRoom.Enabled = true;
                    if (row.Cells[5].Value.ToString() != "")
                    cboRoom.SelectedValue = row.Cells[5].Value.ToString();
                    else
                    {
                        //ko co phong nao duoc chon
                        cboRoom.SelectedIndex = -1;
                    }
                }
                else
                {
                    cboRoom.Enabled = false;
                }
                if (row.Cells[6].Value.ToString() == "Hoàn thành")
                {
                    button_hoanthanh.Enabled = false;
                    button_hethan.Enabled = false;
                }
                else if (row.Cells[6].Value.ToString() == "Hết hạn")
                {
                    button_hoanthanh.Enabled = false;
                    button_hethan.Enabled = false;
                    button_xemhd.Enabled = false;
                }
                else
                {
                    button_hoanthanh.Enabled = true;
                    button_hethan.Enabled = true;
                }

                if (TT.kiemTraHoaDonDaTao(Convert.ToInt32(tb_mapdk.Text)) == true)
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
            ////anh xa
            //DateTime expectedArrival = dtpExpectedArrival.Value;
            //DateTime expectedDeparture = dtpExpectedDeparture.Value;
            //if (expectedArrival > expectedDeparture)
            //{
            //    MessageBox.Show("Ngày đến phải trước ngày đi", "Thêm phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            ////if khoang cach giua ngay den va ngay di <1 thi bao loi
            //if ((expectedDeparture - expectedArrival).TotalDays < 1)
            //{
            //    MessageBox.Show("Bạn phải đặt phòng ít nhất 1 ngày", "Thêm phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //string depositAmount = txtDepositAmount.Text;
            //string employee = cboEmployee.SelectedValue.ToString();
            //string customer = cboCustomer.SelectedValue.ToString();
            //string room = cboRoom.SelectedValue.ToString();
            ////them
            //try
            //{
            //    tt.themPhieuDangKy(expectedArrival, expectedDeparture, depositAmount, employee, customer, room);
            //    MessageBox.Show("Thêm thành công", "Thêm phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    try
            //    {
            //        //danh dau phong da duoc thue
            //        ph.danhDauPhong(room,1);
            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Thêm phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    reload();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Thêm phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            FormThemMoiPDK formThemMoiPDK = new FormThemMoiPDK();
            //center the form
            formThemMoiPDK.StartPosition = FormStartPosition.CenterParent;
            formThemMoiPDK.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            if (formThemMoiPDK.ShowDialog() == DialogResult.OK)
            {
                reload(dataGridView_pdk.Rows.Count);

            }
        }
        private void reload(int index=0)
        {
            dataGridView_pdk.DataSource = TT.getDSPhieuDangKy();
            if (dataGridView_pdk.Rows.Count==0)
            {
                return;
            }
            dataGridView_pdk.Rows[index].Selected = true;
            tb_mapdk.Text = dataGridView_pdk.SelectedCells[0].Value.ToString();
            //display data
            int mapdk = Convert.ToInt32(tb_mapdk.Text);
            dtpExpectedArrival.Text = dataGridView_pdk.SelectedCells[1].Value.ToString();
            dtpExpectedDeparture.Text = dataGridView_pdk.SelectedCells[2].Value.ToString();
            txtDepositAmount.Text = dataGridView_pdk.SelectedCells[3].Value.ToString();
            cboCustomer.SelectedValue = dataGridView_pdk.SelectedCells[4].Value.ToString();
            cboRoom.SelectedValue = dataGridView_pdk.SelectedCells[5].Value.ToString();


            string stt= TT.getTrangThaiByMaPDK(mapdk);
            if (stt == "Hoàn thành")
            {
                button_hoanthanh.Enabled = false;
                button_hethan.Enabled = false;
                button_xemhd.Enabled = true;
            }
            else if (stt == "Hết hạn")
            {
                button_hoanthanh.Enabled = false;
                button_hethan.Enabled = false;
                button_xemhd.Enabled = false;
            }
            else
            {
                button_hoanthanh.Enabled = true;
                button_hethan.Enabled = true;
                button_xemhd.Enabled = false;
            }

        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView_pdk.DataSource = TT.getDSPhieuDangKy();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            //anh xa
            string mapdk = tb_mapdk.Text;
            DateTime expectedArrival = dtpExpectedArrival.Value;
            DateTime expectedDeparture = dtpExpectedDeparture.Value;
            double depositAmount = Convert.ToDouble(txtDepositAmount.Text);
            int customer = Convert.ToInt32(cboCustomer.SelectedValue.ToString());
            int room = Convert.ToInt32(cboRoom.SelectedValue.ToString());
            try
            {
                TT.updatePhieuDangKy(mapdk, expectedArrival,expectedDeparture, depositAmount, customer, room);
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
            if (dataGridView_pdk.CurrentRow.Cells[6].Value.ToString() == "")
            {
                if (MessageBox.Show("PDK chưa xử lí, bạn có chắc chắn muốn xóa?", "Xóa phiếu đăng ký", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            int mapdk = Convert.ToInt32(tb_mapdk.Text);

            //neu phieu dang ky da hoan thanh thi kiem tra trang thai hoa don, neu hoa don chua thanh toan thi khong the xoa
            if (TT.getTrangThaiByMaPDK(mapdk) == "Hoàn thành")
            {
                if (TT.getTrangThaiHoaDonByMaPDK(mapdk) != "Đã thanh toán")
                {
                    MessageBox.Show("Không thể xóa phiếu đăng ký vì hoá đơn liên kết chưa thanh toán", "Xóa phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Phiếu đăng ký đã hoàn thành, bạn có chắc chắn muốn xóa?", "Xóa phiếu đăng ký", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu đăng ký này?", "Xóa phiếu đăng ký", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            try
            {
                TT.deletePhieuDangKy(mapdk);
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
            int mapdk = Convert.ToInt32(tb_mapdk.Text);
            try
            {
                TT.danhDauPDKHetHan(mapdk);
                MessageBox.Show("Đánh dấu phiếu đăng ký hết hạn thành công", "Đánh dấu phiếu đăng ký hết hạn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int index = dataGridView_pdk.CurrentRow.Index;
                try
                {
                    int room = Convert.ToInt32(cboRoom.SelectedValue.ToString());
                    PH.danhDauPhong(room, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Đánh dấu phiếu đăng ký hết hạn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reload();
                dataGridView_pdk.Rows[index].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đánh dấu phiếu đăng ký hết hạn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_xemhd_Click(object sender, EventArgs e)
        {
            int mahoadon = Convert.ToInt32(TT.getMaHoaDonbyMaPDK(Convert.ToInt32(tb_mapdk.Text)));
            FormThongTinHoaDon formHoaDon = new FormThongTinHoaDon(mahoadon);
            formHoaDon.ShowDialog();

        }

        private void dataGridView_pdk_SelectionChanged(object sender, EventArgs e)
        {

            
        }

        

        private void button_chuyenphong_Click(object sender, EventArgs e)
        {
            int mapdk = Convert.ToInt32(tb_mapdk.Text);
            int maphonghientai = Convert.ToInt32(cboRoom.SelectedValue.ToString());
            
            FormChuyenPhong formChuyenPhong = new FormChuyenPhong(mapdk, maphonghientai);
            if (formChuyenPhong.ShowDialog() == DialogResult.OK)
            {
                reload();
            }

        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
