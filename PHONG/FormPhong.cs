using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.PHONG
{
    public partial class FormPhong : Form
    {
        PH ph = new PH();
        public FormPhong()
        {
            InitializeComponent();
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementDataSet1.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.hotelManagementDataSet1.Phong);
            comboBox_maloai.DataSource=comboBox_maloaiphong.DataSource = ph.getAllMaLoaiPhong();
            comboBox_maloaiphong.DisplayMember = "maloaiphong";
            comboBox_maloaiphong.ValueMember = "maloaiphong";
            comboBox_maloai.DisplayMember = "maloaiphong";
            comboBox_maloai.ValueMember = "maloaiphong";
            comboBox_p2_loai.DataSource = ph.getAllMaLoaiPhong();
            comboBox_p2_loai.DisplayMember = "maloaiphong";
            comboBox_p2_loai.ValueMember = "maloaiphong";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_phong_Click(object sender, EventArgs e)
        {
            txt_tenphong.Text = dataGridView_phong.CurrentRow.Cells[1].Value.ToString();
            txt_maphong.Text = dataGridView_phong.CurrentRow.Cells[0].Value.ToString();
            checkBox_stt.Text = "Đã thuê";
            checkBox_stt.Checked = dataGridView_phong.CurrentRow.Cells[2].Value.ToString() == "True" ? true : false;
            comboBox_maloai.Text = dataGridView_phong.CurrentRow.Cells[3].Value.ToString();

            DataTable table = ph.getLoaiPhongByMaLoai(comboBox_maloai.Text);
            textBox_tenloaiphong.Text = table.Rows[0][1].ToString();
            textBox_trangthietbi.Text = table.Rows[0][2].ToString();
            textBox_gia.Text = table.Rows[0][3].ToString();
            textBox_mota.Text = table.Rows[0][4].ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string maphong = txt_maphong.Text;
            string tenphong = txt_tenphong.Text;
            bool stt = checkBox_stt.Checked?true:false;
            string maloai = comboBox_maloai.Text;
            try
            {
                ph.insertPhong(maphong, tenphong, stt, maloai);
                MessageBox.Show("Thêm phòng thành công", "Thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLoad_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //
            this.phongTableAdapter.Fill(this.hotelManagementDataSet1.Phong);
            
        }

        private void dataGridView_phong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_editloaiphong_Click(object sender, EventArgs e)
        {
            //chuyen tab
            tabControl_phong.SelectedTab = tabPage_qlloaiphong ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string maloaiphong = comboBox_p2_loai.Text;
                string tenloaiphong = textBox_p2_tenloai.Text;
                string trangthietbi = textBox_p2_trangthietbi.Text;
                double gia = Convert.ToDouble(textBox_p2_gia.Text);
                string mota = textBox_p2_mota.Text;
                ph.themLoaiPhong(maloaiphong, tenloaiphong, trangthietbi, gia, mota);
                MessageBox.Show("Thêm loại phòng thành công", "Thêm loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_p2_loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display loai phong
            DataTable table = ph.getLoaiPhongByMaLoai(comboBox_p2_loai.Text);
            comboBox_p2_loai.Text = table.Rows[0][0].ToString();
            textBox_p2_tenloai.Text = table.Rows[0][1].ToString();
            textBox_p2_trangthietbi.Text = table.Rows[0][2].ToString();
            textBox_p2_gia.Text = table.Rows[0][3].ToString();
            textBox_p2_mota.Text = table.Rows[0][4].ToString();

        }

        private void button_p2_reload_Click(object sender, EventArgs e)
        {
            //reload loai phong
            comboBox_p2_loai.DataSource = ph.getAllMaLoaiPhong();
            comboBox_p2_loai.DisplayMember = "maloaiphong";
            comboBox_p2_loai.ValueMember = "maloaiphong";

        }

        private void button_p2_sua_Click(object sender, EventArgs e)
        {
            //sua loai phong
            try
            {
                string maloaiphong = comboBox_p2_loai.Text;
                string tenloaiphong = textBox_p2_tenloai.Text;
                string trangthietbi = textBox_p2_trangthietbi.Text;
                double gia = Convert.ToDouble(textBox_p2_gia.Text);
                string mota = textBox_p2_mota.Text;
                ph.updateLoaiPhong(maloaiphong, tenloaiphong, trangthietbi, gia, mota);
                MessageBox.Show("Sửa loại phòng thành công", "Sửa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sửa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_p2_xoa_Click(object sender, EventArgs e)
        {
            //xoa loai phong theo maloai
            try
            {
                string maloaiphong = comboBox_p2_loai.Text;
                ph.deleteLoaiPhong(maloaiphong);
                MessageBox.Show("Xóa loại phòng thành công", "Xóa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xóa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
