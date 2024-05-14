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
    public partial class FormShowAllNhanVien : Form
    {
        public FormShowAllNhanVien()
        {
            InitializeComponent();
        }

        private void FormShowAllNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView_employee.AllowUserToAddRows = false;
            dataGridView_employee.DataSource = EMP.getDSNhanVien();
            dataGridView_employee.DefaultCellStyle.SelectionBackColor = Color.Purple;

        }
    }
}
