using QuanLyHotel.EMPLOYEE;
using QuanLyHotel.KHACHHANG;
using QuanLyHotel.PHONG;
using QuanLyHotel.THUETRA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //FormLogin formLogin = new FormLogin();
            //if (formLogin.ShowDialog() == DialogResult.OK)
            //{
            //    if (Info.role == "admin")
            //    {
            //        Application.Run(new FormMain());
            //    }
            //    else if (Info.role == "employee")
            //    {
            //        Application.Run(new FormMain());
            //    }
            //    else
            //    {
            //        Application.Run(new FormKhachHang());
            //    }
            //}
            Application.Run(new FormMain());
            //Application.Run(new FormRegister());
        }
    }
}
