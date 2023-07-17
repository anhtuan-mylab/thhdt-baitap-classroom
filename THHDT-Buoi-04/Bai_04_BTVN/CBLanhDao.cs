using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_04_BTVN
{
    public class CBLanhDao:NhanVien
    {
        protected string chucVu;
        protected int thamNienQL;

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        public int ThamNienQL
        {
            get { return thamNienQL; }
            set { thamNienQL = value; }
        }

        public CBLanhDao():base()
        {
            this.MaNV = "NV009";
            this.HoTen = "Dieu Hien";
            this.HeSoLuong = 4.67;
            this.ChucVu = "Giam doc";
            this.ThamNienQL = 10;
        }

        public double tinhLuong()
        {
            double heSoLanhDao = 1.0;
            double tinhPhuCap = 1500 * heSoLanhDao;

            if (ChucVu.Equals("Giam Doc"))
            {
                heSoLanhDao = 7.0;
            }
            else if (ChucVu.Equals("Truong phong"))
            {
                heSoLanhDao = 6.0;
            }
            else
            {
                heSoLanhDao = 4.5;
            }



            return base.tinhThuNhap() + tinhPhuCap;
        }

        public override void nhap()
        {
            base.nhap();

            Console.Write("Nhap chuc vu: ");
            ChucVu = Console.ReadLine();

            Console.Write("Nhap tham nien: ");
            ThamNienQL = int.Parse(Console.ReadLine());
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Chuc vu: {0} \t Tham nien: {1} \t Thu nhap: {2}", ChucVu, ThamNienQL, tinhLuong());
        }
    }
}
