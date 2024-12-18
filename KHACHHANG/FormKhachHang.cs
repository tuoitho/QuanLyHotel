﻿using QuanLyHotel.BILL;
using QuanLyHotel.EMPLOYEE;
using QuanLyHotel.THUETRA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.KHACHHANG
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            if (Info.role == "nhanvien" && Info.chucvu == 3)
            {
                groupBox_tacvu.Enabled = false;
            }

            dataGridView_kh.DefaultCellStyle.SelectionBackColor = Color.Purple;
            textBox_input.Text = "Nhập thông tin cần tìm kiếm";
            //chu mo
            textBox_input.ForeColor = Color.Gray;
            //clear text WHEN CLICK
            textBox_input.Click += new EventHandler(textBox_input_Click);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void load()
        {
            dataGridView_kh.DataSource = KH.getDSKhachHang();
            //zoom datagridview
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView_kh.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView_kh.AllowUserToAddRows = false;

            dataGridView_kh.Columns[0].HeaderText = "Mã KH";
            dataGridView_kh.Columns[1].HeaderText = "Họ tên";
            dataGridView_kh.Columns[2].HeaderText = "SĐT";
            dataGridView_kh.Columns[3].HeaderText = "Ngày sinh";
            dataGridView_kh.Columns[4].HeaderText = "CCCD";
            dataGridView_kh.Columns[5].HeaderText = "Email";
            dataGridView_kh.Columns[6].HeaderText = "Quốc tịch";
            dataGridView_kh.Columns[7].HeaderText = "Ảnh";

        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            load();
            if (dataGridView_kh.Rows.Count > 0)
            {
                dataGridView_kh.Rows[0].Selected = true;
                dataGridView_kh_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
            //zoom
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string hoten = textBox_hoten.Text;
                string sdt = textBox_sdt.Text;
                string diachi = textBox_cccd.Text;
                string quoctich = textBox_quoctich.Text;
                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                KH.insertKhachHang(hoten, sdt, diachi, quoctich, pic);
                MessageBox.Show("Thêm khách hàng thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //anh xa
            textBox_makh.Text = dataGridView_kh.CurrentRow.Cells[0].Value.ToString();
            textBox_hoten.Text = dataGridView_kh.CurrentRow.Cells[1].Value.ToString();
            textBox_sdt.Text = dataGridView_kh.CurrentRow.Cells[2].Value.ToString();
            textBox_cccd.Text = dataGridView_kh.CurrentRow.Cells[4].Value.ToString();
            textBox_quoctich.Text = dataGridView_kh.CurrentRow.Cells[6].Value.ToString();
            if (dataGridView_kh.CurrentRow.Cells[3].Value != DBNull.Value)
            datetimePicker_NgaySinh.Value = Convert.ToDateTime(dataGridView_kh.CurrentRow.Cells[3].Value);
            textBox_email.Text = dataGridView_kh.CurrentRow.Cells[5].Value.ToString();
            if (dataGridView_kh.CurrentRow.Cells[7].Value != DBNull.Value)

            {
                byte[] pic;
                pic = (byte[])dataGridView_kh.CurrentRow.Cells[7].Value;
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
                //zoom
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
                pictureBox1.Image = null;
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            try
            {
                int makh = Convert.ToInt32(textBox_makh.Text);
                string hoten = textBox_hoten.Text;
                string sdt = textBox_sdt.Text;
                DateTime ngaysinh = datetimePicker_NgaySinh.Value;
                string cccd = textBox_cccd.Text;
                string email = textBox_email.Text;
                string diachi = textBox_cccd.Text;
                string quoctich = textBox_quoctich.Text;
                MemoryStream pic = new MemoryStream();
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Chưa chọn ảnh", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if (KH.updateKhachHang(makh, hoten, sdt, ngaysinh, cccd, email, quoctich, pic))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string maKH = textBox_makh.Text;
            //kiem tra co phieu dang ky nao chua
            DataTable pdk = TT.getPDKByMaKH(Convert.ToInt32(maKH));
            if (pdk.Rows.Count > 0)
            {
                //lay trang thai phieu dang ky
                if (pdk.Rows[0]["TrangThai"] == DBNull.Value)
                {
                    MessageBox.Show("Khách hàng này có phiếu đăng ký chưa xử lí, không thể xóa", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (pdk.Rows[0]["TrangThai"].ToString() == "Hoàn thành")
                {

                    if (HD.getTrangThaiHDByMaKH(Convert.ToInt32(maKH)) == "Chưa thanh toán")
                    {
                        MessageBox.Show("Khách hàng này chưa thanh toán hóa đơn, không thể xóa", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    KH.deleteKhachHang(maKH);
                    MessageBox.Show("Xóa khách hàng thành công", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                //tim theo hoten, sdt, cccd, makh
                string input = textBox_input.Text;
                dataGridView_kh.DataSource = KH.searchKhachHang(input);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tìm kiếm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_input_Click(object sender, EventArgs e)
        {
            //clear text
            textBox_input.Text = "";
            textBox_input.ForeColor = Color.Black;
        }

        private void button_dkkm_Click(object sender, EventArgs e)
        {
            int makh = Convert.ToInt32(textBox_makh.Text);
            FormDiemDanhKhuonMat f = new FormDiemDanhKhuonMat(true,makh);
            f.Show();
        }

        private void lblDepositAmount_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_xemhd_Click(object sender, EventArgs e)
        {

        }
    }
}
