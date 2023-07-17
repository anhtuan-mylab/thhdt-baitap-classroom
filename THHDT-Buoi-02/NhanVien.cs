using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_02
{
    class NhanVien
    {
        private string maSo, hoTen;
        private int ngayCong;
        public static double luongNgay = 200000;

        public string MaSo
        {
            get { return maSo; }
            set
            {
                maSo = value;
            }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public int NgayCong
        {
            get { return ngayCong; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Loi du lieu.");
                    ngayCong = 0;
                }
                else
                {
                    ngayCong = value;
                }
            }
        }

        public char XepLoai
        {
            get
            {
                if (NgayCong>=26)
                {
                    return 'A';
                }
                else if (NgayCong>=22)
                {
                    return 'B';
                }
                else
                {
                    return 'C';
                }
            }
        }

        public double LuongNgay
        {
            get { return luongNgay; }
            set { value = luongNgay; }
        }

        public NhanVien()
        {
            MaSo = HoTen = "";
            NgayCong = 0;
        }

        public NhanVien(string maSo, string hoTen, int ngayCong)
        {
            this.MaSo = maSo;
            this.HoTen = hoTen;
            this.NgayCong = ngayCong;
        }

        public NhanVien(NhanVien a)
        {
            this.HoTen = a.HoTen;
            this.HoTen = a.MaSo;
            this.NgayCong = a.NgayCong;
        }

        public void nhap()
        {
            Console.Write("Nhap ma so: ");
            MaSo = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap so ngay cong: ");
            NgayCong = int.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.Write("Ho ten: {0}, Ma so: {1}, Ngay cong: {2}, Xep hang: {3}", HoTen, MaSo, NgayCong, XepLoai);

            Console.WriteLine("\nluong: {0:0.00}, thuong: {1:0.00}", tinhLuong(), tinhThuong());
        }

        public double tinhLuong()
        {
            return ngayCong * LuongNgay;
        }

        public double tinhThuong()
        {
            if (XepLoai == 'A')
            {
                return tinhLuong() * 5 / 100;
            }
            else if (XepLoai == 'B')
            {
                return tinhLuong() * 2 / 100;
            }
            else
            {
                return 0;
            }
        }


    }
}
