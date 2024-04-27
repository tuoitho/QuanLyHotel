using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.ACCOUNT
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ACC.getListAcc();
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Purple;

        }
        //reload
        private void reload()
        {
            dataGridView1.DataSource = ACC.getListAcc();
        }
        private void roundedButton_duyet_Click(object sender, EventArgs e)
        {
            //set status = 1
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (ACC.updateStatus(id, 1))
            {
                MessageBox.Show("Duyệt thành công", "Duyệt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = ACC.getListAcc();
            }
            else
            {
                MessageBox.Show("Duyệt thất bại", "Duyệt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roundedButton_tuchoi_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (ACC.updateStatus(id, 0))
            {
                MessageBox.Show("Từ chối thành công", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = ACC.getListAcc();
            }
            else
            {
                MessageBox.Show("Từ chối thất bại", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roundedButton_xoa_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                ACC.deleteAcc(id);
                MessageBox.Show("Xóa thành công", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
