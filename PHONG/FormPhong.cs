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

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_phong_Click(object sender, EventArgs e)
        {
            txt_tenphong.Text = dataGridView_phong.CurrentRow.Cells[1].Value.ToString();
            txt_maphong.Text = dataGridView_phong.CurrentRow.Cells[0].Value.ToString();
            checkBox_stt.Text = dataGridView_phong.CurrentRow.Cells[2].Value.ToString()=="True"?"Đang thuê":"Còn trống";
            checkBox_stt.Checked = dataGridView_phong.CurrentRow.Cells[2].Value.ToString() == "True" ? true : false;
            txt_maloai.Text = dataGridView_phong.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string maphong = txt_maphong.Text;
            string tenphong = txt_tenphong.Text;
            bool stt = checkBox_stt.Checked?true:false;
            string maloai = txt_maloai.Text;
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
    }
}
