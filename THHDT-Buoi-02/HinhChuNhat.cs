using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_02
{
    class HinhChuNhat
    {
        private double chieuDai;
        private double chieuRong;

        public double ChieuDai
        {
            get { return chieuDai; }
            set { chieuDai = value; }
        }

        public double ChieuRong
        {
            get { return chieuRong; }
            set { chieuRong = value; }
        }

        public HinhChuNhat()
        {
            ChieuDai = ChieuRong = 0;
        }

        public HinhChuNhat(double cd, double cr)
        {
            this.ChieuDai = cd;
            this.ChieuRong = cr;
        }

        public HinhChuNhat(HinhChuNhat a)
        {
            this.ChieuDai = a.ChieuDai;
            this.ChieuRong = a.ChieuRong;
        }

        public void nhap()
        {
            Console.Write("Nhap chieu dai: ");
            ChieuDai = double.Parse(Console.ReadLine());

            Console.Write("Nhap chieu rong: ");
            ChieuRong = double.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.Write("\nChieu dai: {0}, Chieu rong: {1}", ChieuDai, ChieuRong);

            Console.Write("\nChu vi: {0}, Dien tich: {1}", tinhChuvi(), tinhDienTich());
        
        }

        public double tinhChuvi()
        {
            return (ChieuDai + ChieuRong) * 2;
        }

        public double tinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public void changeSize(int tx, int ty, int kieu)
        {
            if (kieu == 1)
            {
                ChieuDai += tx;
                ChieuRong += ty;
            }
            else
            {
                ChieuDai -= tx;
                ChieuRong -= ty;
            }
        }


    }
}
