using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.Riengbiet
{
    public partial class FormBieuDoDoanhThu : Form
    {
        private DataTable dt;

        public FormBieuDoDoanhThu()
        {
            InitializeComponent();
        }

        public FormBieuDoDoanhThu(DataTable dt):this()
        {
            this.dt = dt;
        }

        private void FormBieuDoDoanhThu_Load(object sender, EventArgs e)
        {

            this.reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
