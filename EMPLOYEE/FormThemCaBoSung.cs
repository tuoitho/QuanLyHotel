using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.EMPLOYEE
{
    public partial class FormThemCaBoSung : Form
    {
        public FormThemCaBoSung()
        {
            InitializeComponent();
            comboBox_loainv.DataSource = EMP.getAllLoaiNVNgoaiTruQL();
            comboBox_loainv.DisplayMember = "tenchucvu";
            comboBox_loainv.ValueMember = "machucvu";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker_s.Value;
            DateTime end = dateTimePicker_e.Value;
            DateTime day = dateTimePicker_ngay.Value;
            int number = Convert.ToInt32(numericUpDown_sl.Value);
            int machucvu = Convert.ToInt32(comboBox_loainv.SelectedValue);
            try
            {
                EMP.addPhanCa(day, start, end, number, machucvu);
                MessageBox.Show("Thêm ca bổ sung thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
