using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.DICHVU
{
    public partial class FormQuanLyDichVu : Form
    {
        bool loaded = false;
        public FormQuanLyDichVu()
        {
            InitializeComponent();
            comboBox_maldv.DataSource = DV.getDSLoaiDichVu();
            comboBox_maldv.DisplayMember = "MaLDV";
            comboBox_maldv.ValueMember = "MaLDV";
            comboBox_maldv.SelectedIndex = -1;
            comboBox_loaidv.DataSource = DV.getDSLoaiDichVu();
            comboBox_loaidv.DisplayMember = "TenLDV";
            comboBox_loaidv.ValueMember = "MaLDV";
            loaded = true;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenDichVu = textBox_tenldv.Text;
            try
            {
                DV.themLDV(tenDichVu);
                MessageBox.Show("Thêm loại dịch vụ thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            int maLDV = Convert.ToInt32(comboBox_maldv.SelectedValue);
            string tenDichVu = textBox_tenldv.Text;
            DV.suaLDV(maLDV, tenDichVu);
                MessageBox.Show("Sửa loại dịch vụ thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox_maldv_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!loaded)
                return;
            textBox_tenldv.Text = DV.getTenLDVByMDV(Convert.ToInt32(comboBox_maldv.SelectedValue));
        }

        private void comboBox_loaidv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loaded)
                return;
            DataTable table = DV.getDSDichVu(Convert.ToInt32(comboBox_loaidv.SelectedValue));
            if (table.Rows.Count == 0)
                return;
            comboBox_dv.DataSource = table;
            comboBox_dv.DisplayMember = "TenDV";
            comboBox_dv.ValueMember = "MaDV";
            textBox_tendv.Text = table.Rows[0]["TenDV"].ToString();
            textBox_giadv.Text = table.Rows[0]["GiaDV"].ToString();

        }

        private void FormQuanLyDichVu_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_dv_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox_dv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dv = DV.getDVByMaDV(Convert.ToInt32(comboBox_dv.SelectedValue));
            textBox_giadv.Text = dv.Rows[0]["GiaDV"].ToString();
            textBox_tendv.Text = dv.Rows[0]["TenDV"].ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string tenDV = textBox_tendv.Text;
            int giaDV = Convert.ToInt32(textBox_giadv.Text);
            int maLDV = Convert.ToInt32(comboBox_loaidv.SelectedValue);
            try
            {
                DV.themDV(tenDV, giaDV, maLDV);
                MessageBox.Show("Thêm dịch vụ thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            string tenDV = textBox_tendv.Text;
            double giaDV = Convert.ToDouble(textBox_giadv.Text);
            int maDV = Convert.ToInt32(comboBox_dv.SelectedValue);
            try
            {
                DV.suaDV(maDV, tenDV, giaDV);
                MessageBox.Show("Sửa dịch vụ thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
