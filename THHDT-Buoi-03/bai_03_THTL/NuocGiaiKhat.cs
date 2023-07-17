using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_03_THTL
{
    public class NuocGiaiKhat:HangHoa
    {
        private string donViTinh;
        private int soLuong;
        private double donGia;

        public string DonViTinh
        {
            get { return donViTinh;  }
            set { donViTinh = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public NuocGiaiKhat():base()
        {
            DonViTinh = "";
            DonGia = 3000;
            SoLuong = 1;
        }

        public NuocGiaiKhat(string mahang, string tenhang, string donvitinh, int soluong, double dongia):base(mahang, tenhang)
        {
            this.SoLuong = soluong;
            this.DonGia = dongia;

            if (donvitinh.Equals("ket") || donvitinh.Equals("thung") || donvitinh.Equals("chai") || donvitinh.Equals("lon"))
            {
                this.DonViTinh = donvitinh;
            }
            else
            {
                this.DonViTinh = "ket";
            }
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap dvt: ");
            DonViTinh = Console.ReadLine();

            Console.Write("Nhap so luong: ");
            SoLuong = int.Parse(Console.ReadLine());

            Console.Write("Nhap don gia: ");
            DonGia = double.Parse(Console.ReadLine());
        }

        
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Don vi tinh: {0} \t So luong: {1} \t Don gia: {2}", DonViTinh, SoLuong, DonGia);
        }

        public double tinhTongTien()
        {
            double tinhTong = SoLuong * DonGia;
            double tinhThanhTien = tinhTong * 0.1;
            if (DonViTinh.Equals("chai"))
            {
                return tinhTong / 20;
            }
            
            if (DonViTinh.Equals("lon"))
            {
                return tinhTong / 24;
            }

            return tinhThanhTien;

        }
    }
}
