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
    public partial class FormChuyenPhong : Form
    {
        public FormChuyenPhong()
        {
            InitializeComponent();
        }
        int maphieudk,maphong;
        public FormChuyenPhong(int maphieudk,int maphong):this()
        {
            tb_mapdk.Text = maphieudk.ToString();
            textBox_room.Text = maphong.ToString();
            this.maphieudk = maphieudk;
            this.maphong = maphong;
        }
        private void FormChuyenPhong_Load(object sender, EventArgs e)
        {
            comboBox_phongmuonchyyen.DataSource = PH.getDSPhongTrong();
            comboBox_phongmuonchyyen.DisplayMember = "MaPhong";
            comboBox_phongmuonchyyen.ValueMember = "MaPhong";
        }

        private void tb_mapdk_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_chuyenphong_Click(object sender, EventArgs e)
        {
            int phongmuonchuyen = Convert.ToInt32(comboBox_phongmuonchyyen.SelectedValue.ToString());
            try
            {
                TT.chuyenPhong(maphieudk, maphong,phongmuonchuyen);
                MessageBox.Show("Chuyển phòng thành công", "Chuyển phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chuyển phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
