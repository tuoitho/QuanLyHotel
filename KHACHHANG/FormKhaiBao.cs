using QuanLyHotel.DICHVU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.KHACHHANG
{
    public partial class FormKhaiBao : Form
    {
        public FormKhaiBao()
        {
            InitializeComponent();
        }
        private int mahd;
        public FormKhaiBao(int mahd):this()
        {
            this.mahd = mahd;
        }
        bool loaded=false;
        bool dakhaibao = false;
        private void FormKhaiBao_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = DV.getDSLoaiDichVu();
            comboBox1.DisplayMember = "tenldv";
            comboBox1.ValueMember = "maldv";
            loaded = true;
            dataGridView1.DataSource=KH.getDSKhaiBaoByMaHD(mahd);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loaded) return;
            int maloaidv = (int)comboBox1.SelectedValue;
            listBox_ds.DataSource = DV.getDSDichVu(maloaidv);
            listBox_ds.DisplayMember = "tendv";
            listBox_ds.ValueMember = "madv";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int madv = (int)listBox_ds.SelectedValue;
            //neu da khai bao dich vu nay thi khong cho khai bao nua
            if (KH.checkKhaiBao(mahd, madv))
            {
                MessageBox.Show("Dịch vụ này đã được khai báo rồi, không thể khai báo thêm");
                return;
            }
            int soluong = (int)numericUpDown1.Value;
            try { 
                KH.insertKhaiBao(Info.id,mahd, madv, soluong);
                dataGridView1.DataSource = KH.getDSKhaiBaoByMaHD(mahd);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_f5_Click(object sender, EventArgs e)
        {
        }
    }
}
