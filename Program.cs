﻿using QuanLyHotel.DICHVU;
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
            //Application.Run(new FormDiemDanhKhuonMat());
            FormLogin formLogin = new FormLogin();
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                if (Info.role == "admin")
                {
                    if (Info.form == "employee")
                    {
                        Application.Run(new FormMain());
                    }
                    else if (Info.form == "customer")
                    {
                        Application.Run(new FormKhachHang());
                    }
                }
                else if (Info.role == "employee")
                {
                    Application.Run(new FormMain());
                }
                else
                {
                    Application.Run(new FormMain_KhachHang());
                }
            }
            //Application.Run(new FormRegister());
            //Info.role = "employee";
            //Info.chucvu = 1;
            //Info.id = 1;
            //Info.form = "employee";
            //Info.role = "admin";
            //Application.Run(new FormMain());

            //Application.Run(new FormQuanLyDichVu());

            //Info.form = "customer";
            //Info.role = "customer";
            //Info.id = 4;
            //Info.role = "admin";
            //Application.Run(new FormMain());
            //Application.Run(new FormMain_KhachHang());
            //Application.Run(new FormRegister());
            //Application.Run(new FormBaoCaoNgay());
        }
    }
}
