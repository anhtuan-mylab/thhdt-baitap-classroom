using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_02
{
    class HinhTron
    {
        private double banKinh;

        public double BanKinh
        {
            get { return banKinh; }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Du lieu loi khi nhap.");
                    banKinh = 0;
                }
                else
                {
                    value = banKinh;
                }
            }
        }

        public HinhTron()
        {
            this.banKinh = 1;
        }

        public HinhTron(double r)
        {
            this.BanKinh = r;
        }

        public HinhTron(HinhTron r)
        {
            this.BanKinh = r.BanKinh;
        }

        public double tinhChuvi()
        {
            return this.BanKinh * 2 * Math.PI;
        }

        public double tinhDienTich()
        {
            return this.BanKinh * this.BanKinh * Math.PI;
        }

        public void nhap()
        {
            Console.Write("Nhap ban kinh: ");
            BanKinh = double.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("Ban kinh: {0:0.00}, Chu vi: {1:0.00}, Dien tich: {2:0.00}", BanKinh, tinhChuvi(), tinhDienTich());
        }


    }
}
