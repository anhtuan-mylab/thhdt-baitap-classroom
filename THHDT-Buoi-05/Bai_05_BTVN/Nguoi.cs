using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_05_BTVN
{
    public class Nguoi
    {
        protected string hoTen;
        protected string ngaySinh;
        protected string gioiTinh;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set
            {
                if (value.Equals("Nam") || value.Equals("Nu"))
                {
                    gioiTinh = value;
                }
                else
                {
                    Console.WriteLine("Loi nhap du lieu.");
                }
            }
        }

        public Nguoi()
        {
            this.HoTen = "Nguyen Van A";
            this.NgaySinh = "19-02-2008";
            this.GioiTinh = "Nam";
        }

        public Nguoi(string hoten, string ngaysinh, string gioitinh)
        {
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;

            if (gioitinh.Equals("Nam") || gioitinh.Equals("Nu"))
            {
                this.GioiTinh = gioitinh;
            }
            else
            {
                this.GioiTinh = "Nam";
            }
        }

        public virtual void nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap ngay sinh: ");
            NgaySinh = Console.ReadLine();

            Console.Write("Nhap gioi tinh: ");
            GioiTinh = Console.ReadLine();
        }

        public virtual void xuat()
        {
            Console.WriteLine("ho ten: {0} \t ngay sinh: {1} \t gioi tinh: {2}", HoTen, NgaySinh, GioiTinh);
        }


    }
}
