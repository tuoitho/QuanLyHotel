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
        bool loaded = false;
        private void FormPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementDataSet1.Phong' table. You can move, or remove it, as needed.
            //this.phongTableAdapter.Fill(this.hotelManagementDataSet1.Phong);

            dataGridView_phong.DataSource = PH.getDSPhong();
            comboBox_maloai.DataSource = PH.getAllMaLoaiPhong();
            comboBox_maloai.DisplayMember = "maloaiphong";
            comboBox_maloai.ValueMember = "maloaiphong";
            comboBox_p2_loai.DataSource = PH.getAllMaLoaiPhong();
            comboBox_p2_loai.DisplayMember = "maloaiphong";
            comboBox_p2_loai.ValueMember = "maloaiphong";
            dataGridView_phong.DefaultCellStyle.SelectionBackColor = Color.Purple;
            loaded=true;
            if (dataGridView_phong.Rows.Count > 0)
            {
                Form form = new FormChiTietPhong(txt_maphong.Text);
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panel_childForm.Controls.Add(form);
                panel_childForm.Tag = form;
                form.BringToFront();
                form.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_phong_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string tenphong = txt_tenphong.Text;
            bool stt = checkBox_stt.Checked?true:false;
            int maloai = Convert.ToInt32(comboBox_maloai.Text);
            try
            {
                PH.insertPhong( tenphong, stt, maloai);
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
            //this.phongTableAdapter.Fill(this.hotelManagementDataSet1.Phong);
            dataGridView_phong.DataSource = PH.getDSPhong();
            
        }

        private void dataGridView_phong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button_editloaiphong_Click(object sender, EventArgs e)
        {
            //chuyen tab
            tabControl_phong.SelectedTab = tabPage_qlloaiphong ;
            comboBox_p2_loai.Text = dataGridView_phong.CurrentRow.Cells[3].Value.ToString();
            //display loai phong
            DataTable table = PH.getLoaiPhongByMaLoai(Convert.ToInt32(comboBox_p2_loai.Text));
            comboBox_p2_loai.Text = table.Rows[0][0].ToString();
            textBox_p2_tenloai.Text = table.Rows[0][1].ToString();
            textBox_p2_trangthietbi.Text = table.Rows[0][2].ToString();
            textBox_p2_gia.Text = table.Rows[0][3].ToString();
            textBox_p2_mota.Text = table.Rows[0][4].ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int maloaiphong = Convert.ToInt32(comboBox_p2_loai.Text);
                string tenloaiphong = textBox_p2_tenloai.Text;
                string trangthietbi = textBox_p2_trangthietbi.Text;
                double gia = Convert.ToDouble(textBox_p2_gia.Text);
                string mota = textBox_p2_mota.Text;
                //ph.themLoaiPhong(maloaiphong, tenloaiphong, trangthietbi, gia, mota);
                PH.themLoaiPhong(tenloaiphong, trangthietbi, gia, mota);
                MessageBox.Show("Thêm loại phòng thành công", "Thêm loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_p2_loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loaded)
            {
                return;
            }
            //display loai phong
            DataTable table = PH.getLoaiPhongByMaLoai(Convert.ToInt32(comboBox_p2_loai.Text));
            if (table.Rows.Count == 0)
            {
                return;
            }
            comboBox_p2_loai.Text = table.Rows[0][0].ToString();
            textBox_p2_tenloai.Text = table.Rows[0][1].ToString();
            textBox_p2_trangthietbi.Text = table.Rows[0][2].ToString();
            textBox_p2_gia.Text = table.Rows[0][3].ToString();
            textBox_p2_mota.Text = table.Rows[0][4].ToString();

        }

        private void button_p2_reload_Click(object sender, EventArgs e)
        {
            //reload loai phong
            comboBox_p2_loai.DataSource = PH.getAllMaLoaiPhong();
            comboBox_p2_loai.DisplayMember = "maloaiphong";
            comboBox_p2_loai.ValueMember = "maloaiphong";

        }

        private void button_p2_sua_Click(object sender, EventArgs e)
        {
            //sua loai phong
            try
            {
                int maloaiphong = Convert.ToInt32(comboBox_p2_loai.Text);
                string tenloaiphong = textBox_p2_tenloai.Text;
                string trangthietbi = textBox_p2_trangthietbi.Text;
                double gia = Convert.ToDouble(textBox_p2_gia.Text);
                string mota = textBox_p2_mota.Text;
                PH.updateLoaiPhong(maloaiphong, tenloaiphong, trangthietbi, gia, mota);
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
                int maloaiphong = Convert.ToInt32(comboBox_p2_loai.Text);
                PH.deleteLoaiPhong(maloaiphong);
                MessageBox.Show("Xóa loại phòng thành công", "Xóa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xóa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_p2_loai_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            int maphong = Convert.ToInt32(txt_maphong.Text);
            //neu co nguoi o trong phong thi ko sua
            if (PH.getTrangThai(maphong))
            {
                MessageBox.Show("Phòng đã có khách, không thể sửa", "Sửa phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string tenphong = txt_tenphong.Text;
            bool stt = checkBox_stt.Checked ? true : false;
            string maloai = comboBox_maloai.Text;
            try
            {
                PH.updatePhong(maphong, tenphong, stt, maloai);
                MessageBox.Show("Sửa phòng thành công", "Sửa phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLoad_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sửa phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button_chitiet_Click(object sender, EventArgs e)
        {
            //FormChiTietPhong formChiTietPhong = new FormChiTietPhong(txt_maphong.Text);
            //formChiTietPhong.Show();
            //clear panel
            foreach (Control item in panel_childForm.Controls)
            {
                item.Dispose();
            }
            Form form = new FormChiTietPhong(txt_maphong.Text);
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel_childForm.Controls.Add(form);
            panel_childForm.Tag = form;
            form.BringToFront();
            form.Show();



        }

        private void dataGridView_phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //neu ko co row nao thi return
            if (dataGridView_phong.Rows.Count == 0)
            {
                return;
            }
            txt_tenphong.Text = dataGridView_phong.CurrentRow.Cells[1].Value.ToString();
            txt_maphong.Text = dataGridView_phong.CurrentRow.Cells[0].Value.ToString();
            checkBox_stt.Text = "Đã thuê";
            checkBox_stt.Checked = dataGridView_phong.CurrentRow.Cells[2].Value.ToString() == "True" ? true : false;
            comboBox_maloai.Text = dataGridView_phong.CurrentRow.Cells[3].Value.ToString();

            DataTable table = PH.getLoaiPhongByMaLoai(Convert.ToInt32(comboBox_maloai.Text));

        }

        private void dataGridView_phong_SelectionChanged(object sender, EventArgs e)
        {
            txt_tenphong.Text = dataGridView_phong.CurrentRow.Cells[1].Value.ToString();
            txt_maphong.Text = dataGridView_phong.CurrentRow.Cells[0].Value.ToString();
            checkBox_stt.Checked = dataGridView_phong.CurrentRow.Cells[2].Value.ToString() == "True" ? true : false;
            comboBox_maloai.Text = dataGridView_phong.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int map = Convert.ToInt32(txt_maphong.Text);
            //neu phong da co khach thi ko xoa
            if (PH.getTrangThai(map))
            {
                MessageBox.Show("Phòng đã có khách, không thể xóa", "Xóa phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    PH.deletePhong(map);
                    MessageBox.Show("Xóa phòng thành công", "Xóa phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLoad_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Xóa phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
