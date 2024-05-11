using QuanLyHotel.EMPLOYEE;
using QuanLyHotel.PHONG;
using QuanLyHotel.THUETRA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.BILL
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }
        bool daclick = false;
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            string inp= textBox_inputkhachhang.Text;
            if (!daclick)
            {
                inp = "";
            }
            daclick = true;
            dataGridView_hoadon.DataSource = HD.getDSHoaDonKH(inp);
            dataGridView_hoadon.DefaultCellStyle.SelectionBackColor = Color.Purple;
        }

        private void textBox_inputkhachhang_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox_inputkhachhang_Click(object sender, EventArgs e)
        {
            textBox_inputkhachhang.Text = "";
            //forecolor
            textBox_inputkhachhang.ForeColor = Color.Black;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            //neu data rong
            if (dataGridView_hoadon.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xem");
                return;
            }

            int maHD = Convert.ToInt32(dataGridView_hoadon.CurrentRow.Cells[0].Value);
            FormThongTinHoaDon f = new FormThongTinHoaDon(maHD);
            f.ShowDialog();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            int maHD = Convert.ToInt32(dataGridView_hoadon.CurrentRow.Cells[0].Value);

            FormXuLyKhaiBao f = new FormXuLyKhaiBao(maHD);
            f.ShowDialog();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            if (Info.role == "employee" && Info.chucvu != 1 || Info.role != "admin" && Info.role != "employee")
            {
                //hide
                MessageBox.Show(Info.role+ " " + Info.chucvu);
                roundedButton_xemkhaibao.Visible = false;

            }
        }
    }
}
