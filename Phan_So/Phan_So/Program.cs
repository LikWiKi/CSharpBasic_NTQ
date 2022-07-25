using System;

namespace Phan_So
{
    public class PhanSo
    {
        public float tuSo, mauSo;
        public void Nhap()
        {
            Console.Write("Nhap vao tu so: ");
            tuSo = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Nhap vao mau so: ");
                mauSo = Convert.ToInt32(Console.ReadLine());
            } while (mauSo == 0);
        }

        public void Xuat()
        {
            Console.Write("{0}/{1} ", tuSo, mauSo);
        }

        public static PhanSo operator +(PhanSo phanSo1, PhanSo phanSo2)
        {
            PhanSo KQ = new PhanSo();
            KQ.tuSo = phanSo1.tuSo * phanSo2.mauSo + phanSo2.tuSo * phanSo1.mauSo;
            KQ.mauSo = phanSo1.mauSo * phanSo2.mauSo;
            return KQ;
        }

        public PhanSo RutGonPhanSo()
        {
            PhanSo rutgon = new PhanSo();
            float uoc = UCLN(tuSo, mauSo);
            if (uoc != 0)
            {
                rutgon.tuSo = tuSo / uoc;
                rutgon.mauSo = mauSo / uoc;
            }
            else
            {
                rutgon.tuSo = tuSo;
                rutgon.mauSo = mauSo;
            }
            return rutgon;
        }

        public float UCLN(float a, float b)
        {
            a = Math.Abs(tuSo);
            b = Math.Abs(mauSo);
            while (a != b && b != 0 && a != 0)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
    }

    public class DayPhanSo
    {
        PhanSo[] ps;
        int n;
        public void Nhap()
        {

            Console.Write("Nhap so luong phan so :");
            n = Convert.ToInt32(Console.ReadLine());
            ps = new PhanSo[n];
            for (int i = 0; i < n; i++)
            {
                ps[i] = new PhanSo();
                Console.WriteLine("Phan so thu {0}", i + 1);
                ps[i].Nhap();
                ps[i] = ps[i].RutGonPhanSo();
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < n; i++)
            {
                ps[i].Xuat();
                Console.Write("  ");
            }
        }
        public PhanSo tinhtong()
        {
            var tong = ps[0];
            for (int i = 1; i < n; i++)
            {
                tong += ps[i];
            }
            return tong;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            DayPhanSo dPS = new DayPhanSo();
            dPS.Nhap();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Day phan so sau khi rut gon:");
            dPS.Xuat();
            PhanSo tong = dPS.tinhtong();

            float kq = tong.tuSo / tong.mauSo;
            Console.Write("\nTong = " + kq);

            
            Console.ReadLine();
        }
    }
}

