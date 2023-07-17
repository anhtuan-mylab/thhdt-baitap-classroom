using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_04_BTVN
{
    public class NhanVien
    {
        protected string maNV;
        protected string hoTen;
        protected double heSoLuong;

        public static double luongCoBan = 1150;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public double HeSoLuong
        {
            get { return heSoLuong; }
            set { heSoLuong = value; }
        }

        public NhanVien()
        {
            this.MaNV = "NV001";
            this.HoTen = "Phung Tan Sang";
            this.HeSoLuong = 2.34;
        }

        public NhanVien(string manv, string hoten, double hesoluong)
        {
            this.HoTen = hoten;
            this.HeSoLuong = hesoluong;

            if (manv.StartsWith("NV"))
            {
                this.MaNV = manv;
            }
            else
            {
                this.MaNV = "NV001";
            }
        }

        public virtual void nhap()
        {
            Console.Write("Nhap ma nv: ");
            MaNV = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap he so luong: ");
            HeSoLuong = double.Parse(Console.ReadLine());
        }

        public virtual void xuat()
        {
            Console.WriteLine("Ma nv: {0} \t HoTen: {1} \t He so luong: {2} \t Tinh thu nhap: {3}", MaNV, HoTen, HeSoLuong, tinhThuNhap());
        }

        public double tinhThuNhap()
        {
            return HeSoLuong * luongCoBan;
        }

    }
}
