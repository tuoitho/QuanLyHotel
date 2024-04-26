using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.EMPLOYEE
{
    public class PhanCa
    {
        static int so_quan_li = 2;
        static int so_tiep_tan = 4;
        static int so_lao_cong = 6;
        static int s1 = 1, s2 = 2, s3 = 4;
        static int c1 = 1, c2 = 2, c3 = 2;
        static int c32 = 4;
        static List<String> ql;
        static List<String> tt;
        static List<String> lc;

        static Dictionary<String, int> socasangdalam;
        static Dictionary<String, int> socatoidalam;
        static Queue<String> queue_ngay_ql;
        static Queue<String> queue_ngay_tt;
        static Queue<String> queue_ngay_lc;

        static Dictionary<String, int> ca_sang;
        static Dictionary<String, int> ca_toi;
        static Dictionary<String, int> ca_toi_thuong;
        static Dictionary<String, int> ca_toi_chu_nhat;
        //contructer
        public PhanCa()
        {
            socasangdalam = new Dictionary<String, int>();
            socatoidalam = new Dictionary<String, int>();

            DataTable table_ql = EMP.getDSNVQuanLy();
            ql = new List<String>();
            foreach (DataRow row in table_ql.Rows)
            {
                ql.Add(row["manv"].ToString());
            }
            DataTable table_tt = EMP.getDSNVTiepTan();
            tt = new List<String>();
            foreach (DataRow row in table_tt.Rows)
            {
                tt.Add(row["manv"].ToString());
            }
            DataTable table_lc = EMP.getDSNVLaoCong();
            lc = new List<String>();
            foreach (DataRow row in table_lc.Rows)
            {
                lc.Add(row["manv"].ToString());
            }
            queue_ngay_ql = new Queue<String>(ql);
            queue_ngay_tt = new Queue<String>(tt);
            queue_ngay_lc = new Queue<String>(lc);
        }
        public PhanCa(int sql, int stt, int slc, int s1, int s2, int s3, int c1, int c2, int c3, int c32) : this()
        {
            so_quan_li = sql;
            so_tiep_tan = stt;
            so_lao_cong = slc;
            s1 = s1;
            s2 = s2;
            s3 = s3;
            c1 = c1;
            c2 = c2;
            c3 = c3;
            c32 = c32;
            ca_sang = new Dictionary<String, int>()
    {
        { "quan_li", s1 },
        { "tiep_tan", s2 },
        { "lao_cong", s3 }
    };
            ca_toi = new Dictionary<String, int>()
            {
                { "quan_li", c1 },
                { "tiep_tan", c2 },
                { "lao_cong", c3 }
            };
            ca_toi_thuong = new Dictionary<String, int>()
            {
                { "quan_li", c1 },
                { "tiep_tan", c2 },
                { "lao_cong", c3 }
            };
            ca_toi_chu_nhat = new Dictionary<String, int>()
            {
                { "quan_li", c1 },
                { "tiep_tan", c2 },
                { "lao_cong", c32 }
            };
        }





        static bool check(List<String> q1, List<String> q2, List<String> q3)
        {
            int socasangdalamql = socasangdalam[ql[0]];
            int socatoidalamql = socatoidalam[ql[0]];

            for (int i = 1; i < ql.Count; i++)
            {
                if (socasangdalam[ql[i]] != socasangdalamql || socatoidalamql != socatoidalam[ql[i]])
                    return false;
            }

            int socasangdalamtt = socasangdalam[tt[0]];
            int socatoidalamtt = socatoidalam[tt[0]];

            for (int i = 1; i < tt.Count; i++)
            {
                if (socasangdalam[tt[i]] != socasangdalamtt || socatoidalamtt != socatoidalam[tt[i]])
                    return false;
            }

            int socasangdalamlc = socasangdalam[lc[0]];
            int socatoidalamlc = socatoidalam[lc[0]];

            for (int i = 1; i < lc.Count; i++)
            {
                if (socasangdalam[lc[i]] != socasangdalamlc || socatoidalamlc != socatoidalam[lc[i]])
                    return false;
            }

            return true;
        }


        static int calsocasang(String x)
        {
            return socasangdalam[x];
        }
        static Queue<String> DoubleQueue(Queue<String> originalQueue)
        {
            Queue<String> newQueue = new Queue<String>(originalQueue);
            foreach (var item in originalQueue)
            {
                newQueue.Enqueue(item);
            }
            return newQueue;
        }
        public static void ThucHien()
        {
            queue_ngay_ql = DoubleQueue(queue_ngay_ql);
            queue_ngay_tt = DoubleQueue(queue_ngay_tt);
            queue_ngay_lc = DoubleQueue(queue_ngay_lc);
            foreach (String s in ql.Concat(tt).Concat(lc))
            {
                socasangdalam[s] = 0;
                socatoidalam[s] = 0;
            }
            //lay ngay hien tai va kiem tra thu may trong tuan
            int thu = (int)DateTime.Now.DayOfWeek;
            for (int i = thu; i < 10000; i++)
            {
                //List<String> lichngayql = new List<String>();
                List<String> ca_sang_ql = new List<String>();
                List<String> ca_toi_ql = new List<String>();
                List<String> ca_sang_tt = new List<String>();
                List<String> ca_toi_tt = new List<String>();
                List<String> ca_sang_lc = new List<String>();
                List<String> ca_toi_lc = new List<String>();


                List<String> x = queue_ngay_ql.Take(ca_sang["quan_li"]).ToList();
                foreach (String j in x)
                {
                    socasangdalam[j]++;
                }
                List<String> y = queue_ngay_ql.Skip(ca_sang["quan_li"]).Take(ca_toi["quan_li"]).ToList();
                foreach (String j in y)
                {
                    socatoidalam[j]++;
                }
                ca_sang_ql.AddRange(x);
                ca_toi_ql.AddRange(y);
                queue_ngay_ql.Enqueue(queue_ngay_ql.Dequeue());


                x = queue_ngay_tt.Take(ca_sang["tiep_tan"]).ToList();
                foreach (String j in x)
                {
                    socasangdalam[j]++;
                }
                y = queue_ngay_tt.Skip(ca_sang["tiep_tan"]).Take(ca_toi["tiep_tan"]).ToList();
                foreach (String j in y)
                {
                    socatoidalam[j]++;
                }
                ca_sang_tt.AddRange(x);
                ca_toi_tt.AddRange(y);
                queue_ngay_tt.Enqueue(queue_ngay_tt.Dequeue());

                x = queue_ngay_lc.Take(ca_sang["lao_cong"]).ToList();
                foreach (String j in x)
                {
                    socasangdalam[j]++;
                }
                ca_toi = (i % 7 == 0) ? ca_toi_chu_nhat : ca_toi_thuong;
                y = queue_ngay_lc.Skip(ca_sang["lao_cong"]).Take(ca_toi["lao_cong"]).ToList();
                foreach (String j in y)
                {
                    socatoidalam[j]++;
                }
                ca_sang_lc.AddRange(x);
                ca_toi_lc.AddRange(y);
                queue_ngay_lc.Enqueue(queue_ngay_lc.Dequeue());

                capnhatlichlamviec(ca_sang_ql, ca_toi_ql, ca_sang_tt, ca_toi_tt, ca_sang_lc, ca_toi_lc);
                foreach (String s in ca_sang_ql.Concat(ca_sang_tt).Concat(ca_sang_lc))
                {
                    EMP.insertPhanCa("CA001", s, DateTime.Now.AddDays(i - thu));
                }
                foreach (String s in ca_toi_ql.Concat(ca_toi_tt).Concat(ca_toi_lc))
                {
                    EMP.insertPhanCa("CA002", s, DateTime.Now.AddDays(i - thu));
                }
                if (check(queue_ngay_ql.ToList(), queue_ngay_tt.ToList(), queue_ngay_lc.ToList()))
                {
                    MessageBox.Show("Da phan ca thanh cong voi chu ky cong bang" + (i - thu + 1).ToString() + "Days");
                    break;
                }
            }
        }

        private static void capnhatlichlamviec(List<string> ca_sang_ql, List<string> ca_toi_ql, List<string> ca_sang_tt, List<string> ca_toi_tt, List<string> ca_sang_lc, List<string> ca_toi_lc)
        {
        }
    }
}
