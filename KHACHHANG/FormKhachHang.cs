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
            picCol = (DataGridViewImageColumn)dataGridView_kh.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView_kh.AllowUserToAddRows = false;


        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            load();
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
                if (KH.insertKhachHang(hoten, sdt, diachi, quoctich, pic))
                {
                    MessageBox.Show("Thêm khách hàng thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            textBox_cccd.Text = dataGridView_kh.CurrentRow.Cells[3].Value.ToString();
            textBox_quoctich.Text = dataGridView_kh.CurrentRow.Cells[4].Value.ToString();
            if (dataGridView_kh.CurrentRow.Cells[5].Value != DBNull.Value)

            {
                byte[] pic;
                pic = (byte[])dataGridView_kh.CurrentRow.Cells[5].Value;
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
                string hoten = textBox_hoten.Text;
                string sdt = textBox_sdt.Text;
                string diachi = textBox_cccd.Text;
                string quoctich = textBox_quoctich.Text;
                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if (KH.updateKhachHang(textBox_makh.Text, hoten, sdt, diachi, quoctich, pic))
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
            try
            {
                string maKH = textBox_makh.Text;
                if (KH.deleteKhachHang(maKH))
                {
                    MessageBox.Show("Xóa khách hàng thành công", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            textBox_input.ForeColor= Color.Black;
        }
    }
}
