using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_02
{
    class NuocGiaiKhat
    {
        private string tenHang;
        private string donViTinh;
        private int soLuong;
        private float donGia;
        public static float thue = (float)0.1;

        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set 
            { 
                if (value <= 0)
                {
                    Console.Write("Loi du lieu.");
                    soLuong = 0;
                }
                else
                {
                    soLuong = value;
                }
            }
        }

        public float DonGia
        {
            get { return donGia; }
            set
            {
                if (value <= 0)
                {
                    Console.Write("Loi du lieu.");
                    donGia = 0;
                }
                else
                {
                    donGia = value;
                }
            }
        }

        public float Thue
        {
            get { return thue; }
            set { thue = value; }
        }

        public string DonViTinh
        {
            get
            {
                if (donViTinh.Equals("thung")==true|| donViTinh.Equals("chai") == true|| donViTinh.Equals("ket") == true|| donViTinh.Equals("lon") == true)
                {
                    return donViTinh;
                }
                else
                {
                    return "ket";
                }
            }

            set { donViTinh = value; }
        }

        public NuocGiaiKhat()
        {
            TenHang = DonViTinh = "";
            SoLuong = 1;
            DonGia = 1;
        }

        public NuocGiaiKhat(string tenHang, string donViTinh, int soLuong, float donGia)
        {
            this.TenHang = tenHang;
            this.DonViTinh = donViTinh;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }

        public NuocGiaiKhat(NuocGiaiKhat a)
        {
            this.TenHang = a.TenHang;
            this.DonViTinh = a.DonViTinh;
            this.SoLuong = a.SoLuong;
            this.DonGia = a.DonGia;
        }

        public void nhap()
        {
            Console.Write("Nhap ten hang: ");
            TenHang = Console.ReadLine();

            Console.Write("Nhap don vi tinh: ");
            DonViTinh = Console.ReadLine();

            Console.Write("Nhap so luong: ");
            SoLuong = int.Parse(Console.ReadLine());

            Console.Write("Nhap don gia: ");
            DonGia = (float)double.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("ten hang: {0}. don vi tinh: {1}, so luong: {2}, don gia: {3}", TenHang, DonViTinh, SoLuong, DonGia);

            Console.WriteLine("\nThanh tien: {0:0.00}", tinhThanhTien());
        }

        public double tinhThanhTien()
        {
            if (DonViTinh.Equals("ket") || (DonViTinh.Equals("thung")))
            {
                return SoLuong * DonGia + SoLuong * DonGia * Thue;
            }
            else if (DonViTinh.Equals("chai"))
            {
                return SoLuong * (DonGia/20) + SoLuong * (DonGia/20) * Thue;
            }
            else
            {
                return SoLuong * (DonGia/24) + SoLuong * (DonGia/24) * Thue;
            }
        }


    }
}
