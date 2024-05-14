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
    public partial class FormNhapKhoThucPham : Form
    {
        public FormNhapKhoThucPham()
        {
            InitializeComponent();
        }

        private void roundedButton_kb_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(numericUpDown1.Value);
            int s2 = Convert.ToInt32(numericUpDown2.Value);
            int s3 = Convert.ToInt32(numericUpDown3.Value);
            int s4 = Convert.ToInt32(numericUpDown4.Value);
            try
            {
                if (s1>0)
                    DV.nhapKhoThucPham(1, s1);
                if (s2 > 0)
                    DV.nhapKhoThucPham(2, s2);
                if (s3 > 0)
                    DV.nhapKhoThucPham(3, s3);
                if (s4 > 0)
                    DV.nhapKhoThucPham(4, s4);
                MessageBox.Show("Nhập kho thành công");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
