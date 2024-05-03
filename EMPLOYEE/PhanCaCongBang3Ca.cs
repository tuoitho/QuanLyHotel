using QuanLyHotel.EMPLOYEE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    internal class PhanCaCongBang3Ca
    {
        static DateTime batdau;
        static int sotuan;
        static int so_quan_li;
        static int so_tiep_tan;
        static int so_lao_cong;
        static int s1, s2, s3;
        static int t1, t2, t3;
        static int c1, c2, c3;
        static List<int> ql;
        static List<int> tt;
        static List<int> lc;

        static Dictionary<int, int> socasangdalam;
        static Dictionary<int,int> socatruadalam;
        static Dictionary<int, int> socatoidalam;
        static Queue<int> queue_ngay_ql;
        static Queue<int> queue_ngay_tt;
        static Queue<int> queue_ngay_lc;

        static Dictionary<string, int> ca_sang;
        static Dictionary<string, int> ca_trua;
        static Dictionary<string, int> ca_toi;

        //contructer
        public PhanCaCongBang3Ca()
        {
            socasangdalam = new Dictionary<int, int>();
            socatoidalam = new Dictionary<int, int>();

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
        public PhanCaCongBang3Ca(int sql, int stt, int slc, int s1, int s2, int s3, int t1,int t2,int t3, int c1, int c2, int c3, DateTime bd, int st) : this()
        {
            so_quan_li = sql;
            so_tiep_tan = stt;
            so_lao_cong = slc;
            s1 = s1;
            s2 = s2;
            s3 = s3;
            t1= t1;
            t2 = t2;
            t3 = t3;
            c1 = c1;
            c2 = c2;
            c3 = c3;
            ca_sang = new Dictionary<string, int>()
    {
        { "quan_li", s1 },
        { "tiep_tan", s2 },
        { "lao_cong", s3 }
    };
            ca_trua = new Dictionary<string, int>()
            {
                { "quan_li", t1 },
                { "tiep_tan", t2 },
                { "lao_cong", t3 }
            };
            ca_toi = new Dictionary<string, int>()
            {
                { "quan_li", c1 },
                { "tiep_tan", c2 },
                { "lao_cong", c3 }
            };
            batdau = bd;
            sotuan = st;

        }

        static int calsocasang(int x)
        {
            return socasangdalam[x];
        }
        static int calsocatrua(int x)
        {
            return socatruadalam[x];
        }
        static int calsocatoi(int x)
        {
            return socatoidalam[x];
        }
        static void xaotronqueuengay(Queue<int> a, Queue<int> b, Queue<int> c)
        {
            a.Enqueue(a.Dequeue());
            b.Enqueue(b.Dequeue());
            c.Enqueue(c.Dequeue());
        }
        public static void ThucHien()
        {
            //xoa phan ca cu
            EMP.deletePhanCa(batdau, sotuan);
            int so_ca_sang_moi_ql = ca_sang["quan_li"] * 7 / so_quan_li;
            //lam tron len
            if (ca_sang["quan_li"] * so_quan_li % 7 != 0)
                so_ca_sang_moi_ql++;

            int so_ca_trua_moi_ql = ca_trua["quan_li"] * 7 / so_quan_li;
            if (ca_trua["quan_li"] * so_quan_li % 7 != 0)
                so_ca_trua_moi_ql++;

            int so_ca_toi_moi_ql = ca_toi["quan_li"] * 7 / so_quan_li;
            if (ca_toi["quan_li"] * so_quan_li % 7 != 0)
                so_ca_toi_moi_ql++;

            int so_ca_sang_moi_tt = ca_sang["tiep_tan"] * 7 / so_tiep_tan;
            if (ca_sang["tiep_tan"] * so_tiep_tan % 7 != 0)
                so_ca_sang_moi_tt++;

            int so_ca_trua_moi_tt = ca_trua["tiep_tan"] * 7 / so_tiep_tan;
            if (ca_trua["tiep_tan"] * so_tiep_tan % 7 != 0)
                so_ca_trua_moi_tt++;

            int so_ca_toi_moi_tt = ca_toi["tiep_tan"] * 7 / so_tiep_tan;
            if (ca_toi["tiep_tan"] * so_tiep_tan % 7 != 0)
                so_ca_toi_moi_tt++;

            int so_ca_sang_moi_lc = ca_sang["lao_cong"] * 7 / so_lao_cong;
            if (ca_sang["lao_cong"] * so_lao_cong % 7 != 0)
                so_ca_sang_moi_lc++;

            int so_ca_trua_moi_lc = ca_trua["lao_cong"] * 7 / so_lao_cong;
            if (ca_trua["lao_cong"] * so_lao_cong % 7 != 0)
                so_ca_trua_moi_lc++;

            int so_ca_toi_moi_lc = ca_toi["lao_cong"] * 7 / so_lao_cong;
            if (ca_toi["lao_cong"] * so_lao_cong % 7 != 0)
                so_ca_toi_moi_lc++;
            foreach (int s in ql.Concat(tt).Concat(lc))
            {
                socasangdalam[s] = 0;
                socatruadalam[s] = 0;
                socatoidalam[s] = 0;
            }
            List<int> ca_sang_ql = new List<int>();
            List<int> ca_trua_ql = new List<int>();
            List<int> ca_toi_ql = new List<int>();
            List<int> ca_sang_tt = new List<int>();
            List<int> ca_trua_tt = new List<int>();
            List<int> ca_toi_tt = new List<int>();
            List<int> ca_sang_lc = new List<int>();
            List<int> ca_trua_lc = new List<int>();
            List<int> ca_toi_lc = new List<int>();
            //lay ngay batdau va kiem tra thu may trong tuan
            int thu = (int)batdau.DayOfWeek;
            for (int k = 0; k < sotuan; k++)
            {
                foreach (int s in ql.Concat(tt).Concat(lc))
                {
                    socasangdalam[s] = 0;
                    socatruadalam[s] = 0;
                    socatoidalam[s] = 0;
                }
                int chunhat = 0;
                for (int i = thu + k * 7; i < thu + 7 + k * 7; i++)
                {
                    if (i % 7 == 0)
                        chunhat = i;
                    ca_sang_ql.Clear();
                    ca_trua_ql.Clear();
                    ca_toi_ql.Clear();
                    ca_sang_tt.Clear();
                    ca_trua_tt.Clear();
                    ca_toi_tt.Clear();
                    ca_sang_lc.Clear();
                    ca_trua_lc.Clear();
                    ca_toi_lc.Clear();

                    for (int j = 0; j < ca_sang["quan_li"]; j++)
                    {
                        int x;
                        while (true)
                        {
                            x = queue_ngay_ql.Dequeue();
                            queue_ngay_ql.Enqueue(x);
                            if (calsocasang(x) < so_ca_sang_moi_ql)
                            {
                                break;
                            }
                            //hoac tat ca deu bang so_ca_sang_moi_ql thi break
                            //check min == max
                            //if (socasangdalam.Values.Min() == so_ca_sang_moi_ql && socasangdalam.Values.Max() == so_ca_sang_moi_ql)
                            //{
                            //    break;
                            //}
                        }
                        socasangdalam[x]++;
                        ca_sang_ql.Add(x);
                    }
                    for (int j = 0; j < ca_trua["quan_li"]; j++)
                    {
                        int x;
                        while (true)
                        {
                            x = queue_ngay_ql.Dequeue();
                            queue_ngay_ql.Enqueue(x);
                            if (calsocatrua(x) < so_ca_trua_moi_ql)
                            {
                                break;
                            }
                            //if (socatruadalam.Values.Min() == so_ca_trua_moi_ql && socatruadalam.Values.Max() == so_ca_trua_moi_ql)
                            //{
                            //    break;
                            //}
                        }
                        socatruadalam[x]++;
                        ca_trua_ql.Add(x);
                    }
                    for (int j = 0; j < ca_toi["quan_li"]; j++)
                    {
                        int x;
                        while (true)
                        {
                            x = queue_ngay_ql.Dequeue();
                            queue_ngay_ql.Enqueue(x);
                            if (calsocatoi(x) < so_ca_toi_moi_ql)
                            {
                                break;
                            }
                            //if (socatoidalam.Values.Min() == so_ca_toi_moi_ql && socatoidalam.Values.Max() == so_ca_toi_moi_ql)
                            //{
                            //    break;
                            //}
                        }
                        socatoidalam[x]++;
                        ca_toi_ql.Add(x);
                    }
                    //tuong tu cho tiep tan va lao cong
                    for (int j = 0; j < ca_sang["tiep_tan"]; j++)
                    {
                        int x;
                        while (true)
                        {
                            x = queue_ngay_tt.Dequeue();
                            queue_ngay_tt.Enqueue(x);
                            if (calsocasang(x) < so_ca_sang_moi_tt)
                            {
                                break;
                            }
                            //if (socasangdalam.Values.Min() == so_ca_sang_moi_tt && socasangdalam.Values.Max() == so_ca_sang_moi_tt)
                            //{
                            //    break;
                            //}
                        }
                        socasangdalam[x]++;
                        ca_sang_tt.Add(x);
                    }
                    for (int j = 0; j < ca_trua["tiep_tan"]; j++)
                    {
                        int x;
                        while (true)
                        {
                            x = queue_ngay_tt.Dequeue();
                            queue_ngay_tt.Enqueue(x);
                            if (calsocatrua(x) < so_ca_trua_moi_tt)
                            {
                                break;
                            }
                            //if (socatruadalam.Values.Min() == so_ca_trua_moi_tt && socatruadalam.Values.Max() == so_ca_trua_moi_tt)
                            //{
                            //    break;
                            //}
                        }
                        socatruadalam[x]++;
                        ca_trua_tt.Add(x);
                    }
                    for (int j = 0; j < ca_toi["tiep_tan"]; j++)
                    {
                        int x;
                        while (true)
                        {
                            x = queue_ngay_tt.Dequeue();
                            queue_ngay_tt.Enqueue(x);
                            if (calsocatoi(x) < so_ca_toi_moi_tt)
                            {
                                break;
                            }
                            //if (socatoidalam.Values.Min() == so_ca_toi_moi_tt && socatoidalam.Values.Max() == so_ca_toi_moi_tt)
                            //{
                            //    break;
                            //}
                        }
                        socatoidalam[x]++;
                        ca_toi_tt.Add(x);
                    }
                    for (int j = 0; j < ca_sang["lao_cong"]; j++)
                    {
                        int x;
                        while (true)
                        {
                            x = queue_ngay_lc.Dequeue();
                            queue_ngay_lc.Enqueue(x);
                            if (calsocasang(x) < so_ca_sang_moi_lc)
                            {
                                break;
                            }
                            //if (socasangdalam.Values.Min() == so_ca_sang_moi_lc && socasangdalam.Values.Max() == so_ca_sang_moi_lc)
                            //{
                            //    break;
                            //}
                        }
                        socasangdalam[x]++;
                        ca_sang_lc.Add(x);
                    }
                    for (int j = 0; j < ca_trua["lao_cong"]; j++)
                    {
                        int x;
                        while (true)
                        {
                            x = queue_ngay_lc.Dequeue();
                            queue_ngay_lc.Enqueue(x);
                            if (calsocatrua(x) < so_ca_trua_moi_lc)
                            {
                                break;
                            }
                            //if (socatruadalam.Values.Min() == so_ca_trua_moi_lc && socatruadalam.Values.Max() == so_ca_trua_moi_lc)
                            //{
                            //    break;
                            //}
                        }
                        socatruadalam[x]++;
                        ca_trua_lc.Add(x);
                    }
                    for (int j = 0; j < ca_toi["lao_cong"]; j++)
                    {
                        int x;
                        while (true)
                        {
                            x = queue_ngay_lc.Dequeue();
                            queue_ngay_lc.Enqueue(x);
                            if (calsocatoi(x) < so_ca_toi_moi_lc)
                            {
                                break;
                            }
                            //if (socatoidalam.Values.Min() == so_ca_toi_moi_lc && socatoidalam.Values.Max() == so_ca_toi_moi_lc)
                            //{
                            //    break;
                            //}

                        }
                        socatoidalam[x]++;
                        ca_toi_lc.Add(x);
                    }

                    foreach (int s in ca_sang_ql.Concat(ca_sang_tt).Concat(ca_sang_lc))
                    {
                        EMP.insertPhanCa(1, s, batdau.AddDays(i - thu));
                    }
                    foreach (int s in ca_trua_ql.Concat(ca_trua_tt).Concat(ca_trua_lc))
                    {
                        EMP.insertPhanCa(3, s, batdau.AddDays(i - thu));
                    }
                    foreach (int s in ca_toi_ql.Concat(ca_toi_tt).Concat(ca_toi_lc))
                    {
                        EMP.insertPhanCa(2, s, batdau.AddDays(i - thu));
                    }
                }
                //chu nhat
                ca_sang_ql.Clear();
                ca_trua_ql.Clear();
                ca_toi_ql.Clear();
                ca_sang_tt.Clear();
                ca_trua_tt.Clear();
                ca_toi_tt.Clear();
                ca_sang_lc.Clear();
                ca_trua_lc.Clear();
                ca_toi_lc.Clear();
                foreach (int s in ql)
                {
                    if (socasangdalam[s] < so_ca_sang_moi_ql)
                    {
                        socasangdalam[s]++;
                        ca_sang_ql.Add(s);
                    }
                    if (socatoidalam[s] < so_ca_toi_moi_ql)
                    {
                        socatoidalam[s]++;
                        ca_toi_ql.Add(s);
                    }
                    if (socatruadalam[s] < so_ca_trua_moi_ql)
                    {
                        socatruadalam[s]++;
                        ca_trua_ql.Add(s);
                    }
                }
                foreach (int s in tt)
                {
                    if (socasangdalam[s] < so_ca_sang_moi_tt)
                    {
                        socasangdalam[s]++;
                        ca_sang_tt.Add(s);
                    }
                    if (socatruadalam[s] < so_ca_trua_moi_tt)
                    {
                        socatruadalam[s]++;
                        ca_trua_tt.Add(s);
                    }
                    if (socatoidalam[s] < so_ca_toi_moi_tt)
                    {
                        socatoidalam[s]++;
                        ca_toi_tt.Add(s);
                    }
                }
                foreach (int s in lc)
                {
                    if (socasangdalam[s] < so_ca_sang_moi_lc)
                    {
                        socasangdalam[s]++;
                        ca_sang_lc.Add(s);
                    }
                    if (socatruadalam[s] < so_ca_trua_moi_lc)
                    {
                        socatruadalam[s]++;
                        ca_trua_lc.Add(s);
                    }
                    if (socatoidalam[s] < so_ca_toi_moi_lc)
                    {
                        socatoidalam[s]++;
                        ca_toi_lc.Add(s);
                    }
                }

                foreach (int s in ca_sang_ql.Concat(ca_sang_tt).Concat(ca_sang_lc))
                {
                    EMP.insertPhanCa(1, s, batdau.AddDays(chunhat - thu));
                }
                foreach (int s in ca_trua_ql.Concat(ca_trua_tt).Concat(ca_trua_lc))
                {
                    EMP.insertPhanCa(3, s, batdau.AddDays(chunhat - thu));
                }
                foreach (int s in ca_toi_ql.Concat(ca_toi_tt).Concat(ca_toi_lc))
                {
                    EMP.insertPhanCa(2, s, batdau.AddDays(chunhat - thu));
                }
            }
            DateTime start = batdau;
            //format dd/MM/yyyy
            String startString = start.ToString("dd/MM/yyyy");
            DateTime end = start.AddDays(sotuan * 7 - 1);
            String endString = end.ToString("dd/MM/yyyy");
            MessageBox.Show("Phân ca thành công với chu kỳ công bằng mỗi 7 ngày, từ ngày " + startString + " đến ngày " + endString);
        }


    }
}
