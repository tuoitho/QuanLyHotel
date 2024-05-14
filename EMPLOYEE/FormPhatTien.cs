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
    public partial class FormPhatTien : Form
    {
        private int mahd;

        public FormPhatTien()
        {
            InitializeComponent();
        }

        public FormPhatTien(int mahd):this()
        {
            this.mahd = mahd;
        }
    }
}
