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
    public partial class FormInBangLuong : Form
    {
        private DataTable bangluong;

        public FormInBangLuong()
        {
            InitializeComponent();
        }

        public FormInBangLuong(DataTable bangluong):this()
        {
            this.bangluong = bangluong;
        }

        private void FormInBangLuong_Load(object sender, EventArgs e)
        {

            this.reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", bangluong);
            //add
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();

        }
    }
}
