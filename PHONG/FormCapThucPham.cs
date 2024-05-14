using QuanLyHotel.EMPLOYEE;
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
    public partial class FormCapThucPham : Form
    {
        private int v;

        public FormCapThucPham()
        {
            InitializeComponent();
        }

        public FormCapThucPham(int v):this()
        {
            this.v = v;
        }
        private void FormCapThucPham_Load(object sender, EventArgs e)
        {
            textBox_p.Text = v.ToString();
            numericUpDown1.Value = PH.getSLThucPhamByMaPhong_MaTP(Convert.ToInt32(textBox_p.Text), 1);
            numericUpDown2.Value = PH.getSLThucPhamByMaPhong_MaTP(Convert.ToInt32(textBox_p.Text), 2);
            numericUpDown3.Value = PH.getSLThucPhamByMaPhong_MaTP(Convert.ToInt32(textBox_p.Text), 3);
            numericUpDown4.Value = PH.getSLThucPhamByMaPhong_MaTP(Convert.ToInt32(textBox_p.Text), 4);
        }
        private void roundedButton_select_Click(object sender, EventArgs e)
        {
            FormSelectPhong formSelectPhong = new FormSelectPhong();
            formSelectPhong.dataGridView_phong.DataSource = PH.getDSPhong();
            formSelectPhong.dataGridView_phong.CellClick += (s, ev) =>
            {
                textBox_p.Text = formSelectPhong.dataGridView_phong.Rows[ev.RowIndex].Cells[0].Value.ToString();
                numericUpDown1.Value = PH.getSLThucPhamByMaPhong_MaTP(Convert.ToInt32(textBox_p.Text), 1);
                numericUpDown2.Value = PH.getSLThucPhamByMaPhong_MaTP(Convert.ToInt32(textBox_p.Text), 2);
                numericUpDown3.Value = PH.getSLThucPhamByMaPhong_MaTP(Convert.ToInt32(textBox_p.Text), 3);
                numericUpDown4.Value = PH.getSLThucPhamByMaPhong_MaTP(Convert.ToInt32(textBox_p.Text), 4);
            };
            formSelectPhong.ShowDialog();
        }

        private void roundedButton_cap_Click(object sender, EventArgs e)
        {
            int s1=Convert.ToInt32(numericUpDown5.Value);
            int s2 = Convert.ToInt32(numericUpDown6.Value);
            int s3 = Convert.ToInt32(numericUpDown7.Value);
            int s4 = Convert.ToInt32(numericUpDown8.Value);
            try
            {
                PH.capTP(Convert.ToInt32(textBox_p.Text), 1, s1);
                PH.capTP(Convert.ToInt32(textBox_p.Text), 2, s2);
                PH.capTP(Convert.ToInt32(textBox_p.Text), 3, s3);
                PH.capTP(Convert.ToInt32(textBox_p.Text), 4, s4);
                MessageBox.Show("Cấp thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
