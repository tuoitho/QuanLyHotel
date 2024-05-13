using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.EMPLOYEE
{
    internal class PHANCA_CHINHTHUC
    {
        static int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }
        static int BCNN(int a, int b)
        {
            return a * b / UCLN(a, b);
        }
        static int BCNN_3So(int a, int b, int c)
        {
            int d = BCNN(a, b);
            return BCNN(d, c);
        }
        static DateTime batdau;
        static int so_quan_li;
        static int so_tiep_tan;
        static int so_lao_cong;
        static int s1, s2, s3;
        static int c1, c2, c3;
        static List<int> ql;
        static List<int> tt;
        static List<int> lc;

        static Dictionary<int, int> socasangdalam;
        static Dictionary<int, int> socasang2dalam;
        static Dictionary<int, int> socatoidalam;
        static Dictionary<int, int> socatoidalam2;
        static Queue<int> queue_ngay_ql;
        static Queue<int> queue_ngay_tt;
        static Queue<int> queue_ngay_lc;

        static Dictionary<string, int> ca_sang;
        static Dictionary<string, int> ca_sang2;
        static Dictionary<string, int> ca_toi;
        static Dictionary<string, int> ca_toi2;
        //contructer
        public PHANCA_CHINHTHUC()
        {
            socasangdalam = new Dictionary<int, int>();
            socasang2dalam = new Dictionary<int, int>();
            socatoidalam = new Dictionary<int, int>();
            socatoidalam2 = new Dictionary<int, int>();

            DataTable table_ql = EMP.getDSNVQuanLy();
            ql = new List<int>();
            foreach (DataRow row in table_ql.Rows)
            {
                ql.Add(Convert.ToInt32(row["manv"].ToString()));
            }
            DataTable table_tt = EMP.getDSNVTiepTan();
            tt = new List<int>();
            foreach (DataRow row in table_tt.Rows)
            {
                tt.Add(Convert.ToInt32(row["manv"].ToString()));
            }
            DataTable table_lc = EMP.getDSNVLaoCong();
            lc = new List<int>();
            foreach (DataRow row in table_lc.Rows)
            {
                lc.Add(Convert.ToInt32(row["manv"].ToString()));
            }
            queue_ngay_ql = new Queue<int>(ql);
            queue_ngay_tt = new Queue<int>(tt);
            queue_ngay_lc = new Queue<int>(lc);
        }
        public PHANCA_CHINHTHUC(int sql, int stt, int slc, int s1, int s2, int s3, int c1, int c2, int c3, DateTime bd) : this()
        {
            so_quan_li = sql;
            so_tiep_tan = stt;
            so_lao_cong = slc;
            PHANCA_CHINHTHUC.s1 = s1;
            PHANCA_CHINHTHUC.s2 = s2;
            PHANCA_CHINHTHUC.s3 = s3;
            PHANCA_CHINHTHUC.c1 = c1;
            PHANCA_CHINHTHUC.c2 = c2;
            PHANCA_CHINHTHUC.c3 = c3;
            ca_sang = new Dictionary<string, int>()
    {
        { "quan_li", s1 },
        { "tiep_tan", s2 },
        { "lao_cong", s3 }
    };
            ca_sang2 = new Dictionary<string, int>()
            {
                { "quan_li", s1 },
        { "tiep_tan", s2 },
        { "lao_cong", s3 }
            };
            ca_toi = new Dictionary<string, int>()
            {
                { "quan_li", c1 },
                { "tiep_tan", c2 },
                { "lao_cong", c3 }
            };
            ca_toi2 = new Dictionary<string, int>()
            {
                { "quan_li", c1 },
                { "tiep_tan", c2 },
                { "lao_cong", c3 }
            };
            batdau = bd;

        }

        static int calsocasang(int x)
        {
            return socasangdalam[x];
        }
        static int calsocasang2(int x)
        {
            return socasang2dalam[x];
        }

        static int calsocatoi(int x)
        {
            return socatoidalam[x];
        }
        static int calsocatoi2(int x)
        {
            return socatoidalam2[x];
        }
        public static void ThucHien()
        {
           
            int chukiquanly = 1;
            for (; chukiquanly <= so_quan_li; chukiquanly++)
                if ((chukiquanly * s1) % so_quan_li == 0 && ((chukiquanly * c1) % so_quan_li) == 0)
                {
                    break;
                }
            int so_ca_sang_moi_ql = chukiquanly * ca_sang["quan_li"] / so_quan_li;

            int so_ca_sang_2_moi_ql = so_ca_sang_moi_ql;

            int so_ca_toi_moi_ql = ca_toi["quan_li"] * chukiquanly / so_quan_li;
            int so_ca_toi_2_moi_ql = so_ca_toi_moi_ql;

            int chukitieptan = 1;
            for (; chukitieptan <= so_tiep_tan; chukitieptan++)
            {
                if ((chukitieptan * s2) % so_tiep_tan == 0 && ((chukitieptan * c2) % so_tiep_tan == 0))
                { break; }
            }


            int so_ca_sang_moi_tt = ca_sang["tiep_tan"] * chukitieptan / so_tiep_tan;
            int so_ca_sang_2_moi_tt = so_ca_sang_moi_tt;
            int so_ca_toi_moi_tt = ca_toi["tiep_tan"] * chukitieptan / so_tiep_tan;
            int so_ca_toi_2_moi_tt = so_ca_toi_moi_tt;

            int chukilaocong = 7;
            bool flag = false;
            int tmp = 1;
            for (; tmp <= 7; tmp++)
            {
                if ((tmp * s3) % so_lao_cong == 0 && ((tmp * c3) % so_lao_cong == 0))
                {
                    flag = true;
                    break;
                }
            }
            int so_ca_sang_moi_lc = ca_sang["lao_cong"] * 7 / so_lao_cong;
            if (ca_sang["lao_cong"] * so_lao_cong % 7 != 0)
                so_ca_sang_moi_lc++;
            if (flag)
            {
                chukilaocong = tmp;
                so_ca_sang_moi_lc = ca_sang["lao_cong"] * chukilaocong / so_lao_cong;
            }
            //Console.WriteLine("chu ki:" + chukiquanly+" "+chukitieptan+" "+ chukilaocong);

            int so_ca_sang_2_moi_lc = ca_sang2["lao_cong"] * 7 / so_lao_cong;
            if (ca_sang2["lao_cong"] * so_lao_cong % 7 != 0)
                so_ca_sang_2_moi_lc++;
            if (flag)
            {
                so_ca_sang_2_moi_lc = ca_sang2["lao_cong"] * chukilaocong / so_lao_cong;
            }
            int so_ca_toi_moi_lc = ca_toi["lao_cong"] * 7 / so_lao_cong;
            if (ca_toi["lao_cong"] * so_lao_cong % 7 != 0)
                so_ca_toi_moi_lc++;
            if (flag)
            {
                so_ca_toi_moi_lc = ca_toi["lao_cong"] * chukilaocong / so_lao_cong;
            }
            int so_ca_toi_2_moi_lc = ca_toi2["lao_cong"] * 7 / so_lao_cong;
            if (ca_toi2["lao_cong"] * so_lao_cong % 7 != 0)
                so_ca_toi_2_moi_lc++;
            if (flag)
            {
                so_ca_toi_2_moi_lc = ca_toi2["lao_cong"] * chukilaocong / so_lao_cong;
            }
            foreach (int s in ql.Concat(tt).Concat(lc))
            {
                socasangdalam[s] = 0;
                socasang2dalam[s] = 0;
                socatoidalam[s] = 0;
                socatoidalam2[s] = 0;
            }

            int chuki = BCNN_3So(chukiquanly, chukitieptan, chukilaocong);
            //xoa phan ca cu
            //EMP.deletePhanCaTheoChuKi(batdau, chuki);
            DateTime ngaybatdau = batdau;
            DateTime ngayketthuc = batdau.AddDays(chuki);
            if (EMP.isDaPhanCa(ngaybatdau, ngayketthuc))
            {
              //hop thoai xac nhan
              if (MessageBox.Show("Đã phân ca cho chu kì này, bạn có muốn phân lại không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    EMP.deletePhanCaTrongKhoang(ngaybatdau, ngayketthuc);
                }
            }

            List<int> ca_sang_ql = new List<int>();
            List<int> ca_sang_2_ql = new List<int>();
            List<int> ca_toi_ql = new List<int>();
            List<int> ca_toi_2_ql = new List<int>();
            List<int> ca_sang_tt = new List<int>();
            List<int> ca_sang_2_tt = new List<int>();
            List<int> ca_toi_tt = new List<int>();
            List<int> ca_toi_2_tt = new List<int>();
            List<int> ca_sang_lc = new List<int>();
            List<int> ca_sang_2_lc = new List<int>();
            List<int> ca_toi_lc = new List<int>();
            List<int> ca_toi_2_lc = new List<int>();
            //lay ngay batdau va kiem tra thu may trong tuan
            int thu = (int)batdau.DayOfWeek;
            //boi chung nho nhat cua 3 so
            int solanphanchoquanli = chuki / chukiquanly;
            int solanphanchotieptan = chuki / chukitieptan;
            int solanphancholaocong = chuki / chukilaocong;

            #region PhAN CA CHO QUAN LY
            for (int k = 0; k < solanphanchoquanli; k++)
            {
                foreach (int s in ql)
                {
                    socasangdalam[s] = 0;
                    socasang2dalam[s] = 0;
                    socatoidalam[s] = 0;
                    socatoidalam2[s] = 0;
                }
                for (int i = k * chukiquanly; i < (k + 1) * chukiquanly; i++)
                {
                    ca_sang_ql.Clear();
                    ca_sang_2_ql.Clear();
                    ca_toi_ql.Clear();
                    ca_toi_2_ql.Clear();
                    for (int j = 0; j < ca_sang["quan_li"]; j++)
                    {
                        int x;
                        int cnt = 0;
                        while (true)
                        {
                            x = queue_ngay_ql.Dequeue();
                            queue_ngay_ql.Enqueue(x);
                            if (socasangdalam[x] < so_ca_sang_moi_ql)
                            {
                                socasangdalam[x]++;
                                ca_sang_ql.Add(x);
                                break;
                            }
                            cnt++;
                            if (cnt == so_quan_li)
                            {
                                break;
                            }
                            //biến cnt dùng để kiểm tra xem có duyệt qua hết queue chưa, để tránh trường hợp vòng lặp vô tận khi tất cả quản lý có số ca làm đã như nhau
                        }
                        socasangdalam[x]++;
                        ca_sang_ql.Add(x);
                    }
                    for (int j = 0; j < ca_sang2["quan_li"]; j++)
                    {
                        int x;
                        int cnt = 0;
                        while (true)
                        {
                            x = queue_ngay_ql.Dequeue();
                            queue_ngay_ql.Enqueue(x);
                            if (socasang2dalam[x] < so_ca_sang_2_moi_ql)
                            {
                                socasang2dalam[x]++;
                                ca_sang_2_ql.Add(x);
                                break;
                            }
                            cnt++;
                            if (cnt == so_quan_li)
                            {
                                break;
                            }

                        }

                    }

                    for (int j = 0; j < ca_toi["quan_li"]; j++)
                    {
                        int x;
                        int cnt = 0;
                        while (true)
                        {
                            x = queue_ngay_ql.Dequeue();
                            queue_ngay_ql.Enqueue(x);
                            if (socatoidalam[x] < so_ca_toi_moi_ql)
                            {
                                socatoidalam[x]++;
                                ca_toi_ql.Add(x);
                                break;
                            }
                            cnt++;

                            if (cnt == so_quan_li)
                            {
                                break;
                            }

                        }
                    }
                    for (int j = 0; j < ca_toi2["quan_li"]; j++)
                    {
                        int x;
                        int cnt = 0;
                        while (true)
                        {
                            x = queue_ngay_ql.Dequeue();
                            queue_ngay_ql.Enqueue(x);
                            if (socatoidalam2[x] < so_ca_toi_2_moi_ql)
                            {
                                socatoidalam2[x]++;
                                ca_toi_2_ql.Add(x);
                                break;
                            }
                            cnt++;

                            if (cnt == so_quan_li)
                            {
                                break;
                            }

                        }

                    }
                    //phải có dòng này để đảm bảo ngày cuối ko bị trương hợp 1 nhân viên làm 2 lần trong 1 ca
                    queue_ngay_ql.Enqueue(queue_ngay_ql.Dequeue());
                    foreach (int s in ca_sang_ql)
                    {
                        EMP.insertPhanCa(1, s, batdau.AddDays(i), batdau.AddDays(i).Date.AddHours(7), batdau.AddDays(i).Date.AddHours(15));
                    }
                    foreach (int s in ca_sang_2_ql)
                    {
                        EMP.insertPhanCa(1, s, batdau.AddDays(i), batdau.AddDays(i).Date.AddHours(15), batdau.AddDays(i).Date.AddHours(19));
                    }
                    foreach (int s in ca_toi_ql)
                    {
                        //tuc la 4h ngay hom sau
                        EMP.insertPhanCa(2, s, batdau.AddDays(i), batdau.AddDays(i).Date.AddHours(20), batdau.AddDays(i + 1).Date.AddHours(4));
                    }
                    foreach (int s in ca_toi_2_ql)
                    {
                        EMP.insertPhanCa(2, s, batdau.AddDays(i), batdau.AddDays(i + 1).Date.AddHours(4), batdau.AddDays(i + 1).Date.AddHours(6));
                    }
                }
            }
            #endregion



            #region PhAN CA CHO Tiep tan
            for (int k = 0; k < solanphanchotieptan; k++)
            {
                foreach (int s in tt)
                {
                    socasangdalam[s] = 0;
                    socasang2dalam[s] = 0;
                    socatoidalam[s] = 0;
                    socatoidalam2[s] = 0;
                }
                for (int i = k * chukitieptan; i < (k + 1) * chukitieptan; i++)
                {
                    ca_sang_tt.Clear();
                    ca_sang_2_tt.Clear();
                    ca_toi_tt.Clear();
                    ca_toi_2_tt.Clear();
                    for (int j = 0; j < ca_sang["tiep_tan"]; j++)
                    {
                        int x;
                        int cnt = 0;
                        while (true)
                        {
                            x = queue_ngay_tt.Dequeue();
                            queue_ngay_tt.Enqueue(x);
                            if (socasangdalam[x] < so_ca_sang_moi_tt)
                            {
                                socasangdalam[x]++;
                                ca_sang_tt.Add(x);
                                break;
                            }
                            cnt++;
                            if (cnt == so_tiep_tan)
                            {
                                break;
                            }
                        }
                    }
                    for (int j = 0; j < ca_sang2["tiep_tan"]; j++)
                    {
                        int x;
                        int cnt = 0;
                        while (true)
                        {
                            x = queue_ngay_tt.Dequeue();
                            queue_ngay_tt.Enqueue(x);
                            if (socasang2dalam[x] < so_ca_sang_2_moi_tt)
                            {
                                socasang2dalam[x]++;
                                ca_sang_2_tt.Add(x);
                                break;
                            }
                            cnt++;
                            if (cnt == so_tiep_tan)
                            {
                                break;
                            }
                        }
                    }
                    for (int j = 0; j < ca_toi["tiep_tan"]; j++)
                    {
                        int x;
                        int cnt = 0;
                        while (true)
                        {
                            x = queue_ngay_tt.Dequeue();
                            queue_ngay_tt.Enqueue(x);
                            if (socatoidalam[x] < so_ca_toi_moi_tt)
                            {
                                socatoidalam[x]++;
                                ca_toi_tt.Add(x);
                                break;
                            }
                            cnt++;
                            if (cnt == so_tiep_tan)
                            {
                                break;
                            }
                        }
                    }
                    for (int j = 0; j < ca_toi2["tiep_tan"]; j++)
                    {
                        int x;
                        int cnt = 0;
                        while (true)
                        {
                            x = queue_ngay_tt.Dequeue();
                            queue_ngay_tt.Enqueue(x);
                            if (socatoidalam2[x] < so_ca_toi_2_moi_tt)
                            {
                                socatoidalam2[x]++;
                                ca_toi_2_tt.Add(x);
                                break;
                            }
                            cnt++;
                            if (cnt == so_tiep_tan)
                            {
                                break;
                            }
                        }
                    }
                    queue_ngay_tt.Enqueue(queue_ngay_tt.Dequeue());
                    foreach (int s in ca_sang_tt)
                    {
                        EMP.insertPhanCa(1, s, batdau.AddDays(i), batdau.AddDays(i).Date.AddHours(7), batdau.AddDays(i).Date.AddHours(15));
                    }
                    foreach (int s in ca_sang_2_tt)
                    {
                        EMP.insertPhanCa(1, s, batdau.AddDays(i), batdau.AddDays(i).Date.AddHours(15), batdau.AddDays(i).Date.AddHours(19));
                    }
                    foreach (int s in ca_toi_tt)
                    {
                        EMP.insertPhanCa(2, s, batdau.AddDays(i), batdau.AddDays(i).Date.AddHours(20), batdau.AddDays(i + 1).Date.AddHours(4));
                    }
                    foreach (int s in ca_toi_2_tt)
                    {
                        EMP.insertPhanCa(2, s, batdau.AddDays(i), batdau.AddDays(i + 1).Date.AddHours(4), batdau.AddDays(i + 1).Date.AddHours(6));
                    }

                }
            }
            #endregion


            #region PhAN CA CHO LAO CONG
            if (flag)
            {
                for (int k = 0; k < solanphancholaocong; k++)
                {
                    foreach (int s in lc)
                    {
                        socasangdalam[s] = 0;
                        socasang2dalam[s] = 0;
                        socatoidalam[s] = 0;
                        socatoidalam2[s] = 0;
                    }
                    for (int i = k * chukilaocong; i < (k + 1) * chukilaocong; i++)
                    {
                        ca_sang_lc.Clear();
                        ca_sang_2_lc.Clear();
                        ca_toi_lc.Clear();
                        ca_toi_2_lc.Clear();
                        for (int j = 0; j < ca_sang["lao_cong"]; j++)
                        {
                            int x;
                            int cnt = 0;
                            while (true)
                            {
                                x = queue_ngay_lc.Dequeue();
                                queue_ngay_lc.Enqueue(x);
                                if (socasangdalam[x] < so_ca_sang_moi_lc)
                                {
                                    socasangdalam[x]++;
                                    ca_sang_lc.Add(x);
                                    break;
                                }
                                cnt++;
                                if (cnt == so_lao_cong)
                                {
                                    break;
                                }
                            }
                        }
                        for (int j = 0; j < ca_sang2["lao_cong"]; j++)
                        {
                            int x;
                            int cnt = 0;
                            while (true)
                            {
                                x = queue_ngay_lc.Dequeue();
                                queue_ngay_lc.Enqueue(x);
                                if (socasang2dalam[x] < so_ca_sang_2_moi_lc)
                                {
                                    socasang2dalam[x]++;
                                    ca_sang_2_lc.Add(x);
                                    break;
                                }
                                cnt++;
                                if (cnt == so_lao_cong)
                                {
                                    break;
                                }
                            }
                        }
                        for (int j = 0; j < ca_toi["lao_cong"]; j++)
                        {
                            int x;
                            int cnt = 0;
                            while (true)
                            {
                                x = queue_ngay_lc.Dequeue();
                                queue_ngay_lc.Enqueue(x);
                                if (socatoidalam[x] < so_ca_toi_moi_lc)
                                {
                                    socatoidalam[x]++;
                                    ca_toi_lc.Add(x);
                                    break;
                                }
                                cnt++;
                                if (cnt == so_lao_cong)
                                {
                                    break;
                                }
                            }
                        }
                        for (int j = 0; j < ca_toi2["lao_cong"]; j++)
                        {
                            int x;
                            int cnt = 0;
                            while (true)
                            {
                                x = queue_ngay_lc.Dequeue();
                                queue_ngay_lc.Enqueue(x);
                                if (socatoidalam2[x] < so_ca_toi_2_moi_lc)
                                {
                                    socatoidalam2[x]++;
                                    ca_toi_2_lc.Add(x);
                                    break;
                                }
                                cnt++;
                                if (cnt == so_lao_cong)
                                {
                                    break;
                                }
                            }
                        }
                        queue_ngay_lc.Enqueue(queue_ngay_lc.Dequeue());
                        foreach (int s in ca_sang_lc)
                        {
                            EMP.insertPhanCa(1, s, batdau.AddDays(i), batdau.AddDays(i).Date.AddHours(7), batdau.AddDays(i).Date.AddHours(15));
                        }
                        foreach (int s in ca_sang_2_lc)
                        {
                            EMP.insertPhanCa(1, s, batdau.AddDays(i), batdau.AddDays(i).Date.AddHours(15), batdau.AddDays(i).Date.AddHours(19));
                        }
                        foreach (int s in ca_toi_lc)
                        {
                            EMP.insertPhanCa(2, s, batdau.AddDays(i), batdau.AddDays(i).Date.AddHours(20), batdau.AddDays(i + 1).Date.AddHours(4));
                        }
                        foreach (int s in ca_toi_2_lc)
                        {
                            EMP.insertPhanCa(2, s, batdau.AddDays(i), batdau.AddDays(i + 1).Date.AddHours(4), batdau.AddDays(i + 1).Date.AddHours(6));
                        }
                    }
                }
            }
            else
            {
                //Phan 7 ngay
                for (int k = 0; k < solanphancholaocong; k++)
                {
                    foreach (int s in lc)
                    {
                        socasangdalam[s] = 0;
                        socasang2dalam[s] = 0;
                        socatoidalam[s] = 0;
                        socatoidalam2[s] = 0;
                    }
                    int chunhat = 0;
                    for (int i = thu + k * 7; i < thu + 7 + k * 7; i++)
                    {
                        if (i % 7 == 0)
                            chunhat = i;

                        ca_sang_lc.Clear();
                        ca_sang_2_lc.Clear();
                        ca_toi_lc.Clear();
                        ca_toi_2_lc.Clear();


                        for (int j = 0; j < ca_sang["lao_cong"]; j++)
                        {
                            int x;
                            int cnt = 0;
                            while (true)
                            {
                                x = queue_ngay_lc.Dequeue();
                                queue_ngay_lc.Enqueue(x);
                                if (calsocasang(x) < so_ca_sang_moi_lc)
                                {
                                    socasangdalam[x]++;
                                    ca_sang_lc.Add(x);
                                    break;
                                }
                                cnt++;
                                if (cnt == so_lao_cong)
                                {
                                    break;
                                }

                            }

                        }
                        for (int j = 0; j < ca_sang2["lao_cong"]; j++)
                        {
                            int x;
                            int cnt = 0;
                            while (true)
                            {
                                x = queue_ngay_lc.Dequeue();
                                queue_ngay_lc.Enqueue(x);
                                if (calsocasang2(x) < so_ca_sang_2_moi_lc)
                                {
                                    socasang2dalam[x]++;
                                    ca_sang_2_lc.Add(x);
                                    break;
                                }
                                cnt++;
                                if (cnt == so_lao_cong)
                                {
                                    break;
                                }

                            }
                        }
                        for (int j = 0; j < ca_toi["lao_cong"]; j++)
                        {
                            int x;
                            int cnt = 0;
                            while (true)
                            {
                                x = queue_ngay_lc.Dequeue();
                                queue_ngay_lc.Enqueue(x);
                                if (calsocatoi(x) < so_ca_toi_moi_lc)
                                {
                                    socatoidalam[x]++;
                                    ca_toi_lc.Add(x);
                                    break;
                                }
                                cnt += 1;
                                if (cnt == so_lao_cong)
                                {
                                    break;
                                }
                            }
                        }
                        for (int j = 0; j < ca_toi2["lao_cong"]; j++)
                        {
                            int x;
                            int cnt = 0;
                            while (true)
                            {
                                x = queue_ngay_lc.Dequeue();
                                queue_ngay_lc.Enqueue(x);
                                if (calsocatoi2(x) < so_ca_toi_2_moi_lc)
                                {
                                    socatoidalam2[x]++;
                                    ca_toi_2_lc.Add(x);
                                    break;
                                }
                                cnt += 1;
                                if (cnt == so_lao_cong)
                                {
                                    break;
                                }
                            }
                        }
                        foreach (int s in ca_sang_lc)
                        {
                            EMP.insertPhanCa(1, s, batdau.AddDays(i - thu), batdau.AddDays(i - thu).Date.AddHours(7), batdau.AddDays(i - thu).Date.AddHours(15));
                        }
                        foreach (int s in ca_sang_2_lc)
                        {
                            EMP.insertPhanCa(1, s, batdau.AddDays(i - thu), batdau.AddDays(i - thu).Date.AddHours(15), batdau.AddDays(i - thu).Date.AddHours(19));
                        }
                        foreach (int s in ca_toi_lc)
                        {
                            EMP.insertPhanCa(2, s, batdau.AddDays(i - thu), batdau.AddDays(i - thu).Date.AddHours(20), batdau.AddDays(i - thu + 1).Date.AddHours(4));
                        }
                        foreach (int s in ca_toi_2_lc)
                        {
                            EMP.insertPhanCa(2, s, batdau.AddDays(i - thu), batdau.AddDays(i - thu + 1).Date.AddHours(4), batdau.AddDays(i - thu + 1).Date.AddHours(6));
                        }

                    }
                    //chu nhat (chi danh cho cach phan ca 7 ngay)

                    ca_sang_lc.Clear();
                    ca_sang_2_lc.Clear();
                    ca_toi_lc.Clear();
                    ca_toi_2_lc.Clear();
                    foreach (int s in lc)
                    {
                        if (socasangdalam[s] < so_ca_sang_moi_lc)
                        {
                            socasangdalam[s]++;
                            ca_sang_lc.Add(s);
                        }
                        if (socasang2dalam[s] < so_ca_sang_2_moi_lc)
                        {
                            socasang2dalam[s]++;
                            ca_sang_2_lc.Add(s);
                        }
                        if (socatoidalam[s] < so_ca_toi_moi_lc)
                        {
                            socatoidalam[s]++;
                            ca_toi_lc.Add(s);
                        }
                        if (socatoidalam2[s] < so_ca_toi_2_moi_lc)
                        {
                            socatoidalam2[s]++;
                            ca_toi_2_lc.Add(s);
                        }
                    }

                    foreach (int s in ca_sang_lc)
                    {
                        EMP.insertPhanCa(1, s, batdau.AddDays(chunhat - thu), batdau.AddDays(chunhat - thu).Date.AddHours(7), batdau.AddDays(chunhat - thu).Date.AddHours(15));
                    }
                    foreach (int s in ca_sang_2_lc)
                    {
                        EMP.insertPhanCa(1, s, batdau.AddDays(chunhat - thu), batdau.AddDays(chunhat - thu).Date.AddHours(15), batdau.AddDays(chunhat - thu).Date.AddHours(19));
                    }
                    foreach (int s in ca_toi_lc)
                    {
                        EMP.insertPhanCa(2, s, batdau.AddDays(chunhat - thu), batdau.AddDays(chunhat - thu).Date.AddHours(20), batdau.AddDays(chunhat - thu + 1).Date.AddHours(4));
                    }
                    foreach (int s in ca_toi_2_lc)
                    {
                        EMP.insertPhanCa(2, s, batdau.AddDays(chunhat - thu), batdau.AddDays(chunhat - thu + 1).Date.AddHours(4), batdau.AddDays(chunhat - thu + 1).Date.AddHours(6));
                    }
                }
            }
            #endregion
            string message = "Phân ca thành công!";
            message += "\nChu kì phân ca chung: " + chuki + " ngày";
            message += ", từ ngày " + batdau.ToString("dd/MM/yyyy") + " đến ngày " + batdau.AddDays(chuki).ToString("dd/MM/yyyy") + "";
            message += "\nChu kì phân ca quản lý: mỗi " + chukiquanly + " ngày trong " + chuki + " ngày";
            message += "\nChu kì phân ca tiếp tân: mỗi " + chukitieptan + " ngày trong " + chuki + " ngày";
            message += "\nChu kì phân ca lao công: mỗi " + chukilaocong + " ngày trong " + chuki + " ngày";
            CustomMessageBox customMessageBox = new CustomMessageBox(message, "Thông báo");
            customMessageBox.ShowDialog();
        }


    }
    class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, string caption)
        {
            // Thiết lập các thuộc tính cho cửa sổ
            this.Text = caption;
            this.Size = new Size(1500, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Tạo Label để hiển thị nội dung thông báo
            Label label = new Label();
            label.Text = message;
            label.AutoSize = true;
            label.Location = new Point(20, 20);
            this.Controls.Add(label);

            // Tạo nút OK để đóng cửa sổ
            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(500, 330);
            okButton.Size = new Size(200, 100);
            okButton.Font = new Font(okButton.Font.FontFamily, 20, FontStyle.Regular);
            okButton.BackColor = Color.Yellow;
            this.Controls.Add(okButton);

            // Tăng kích thước chữ của Label
            label.Font = new Font(label.Font.FontFamily, 25, FontStyle.Bold); // Thay đổi kích thước chữ ở đây
            label.ForeColor = Color.Purple;
            //chu dam


            // Cài đặt sự kiện khi nhấn Enter cũng đóng cửa sổ
            this.AcceptButton = okButton;
            //dialog result no

        }
    }
}
