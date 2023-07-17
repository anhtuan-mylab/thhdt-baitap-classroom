using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_03_THTL
{
    public class HangHoa
    {
        protected string maHang;
        protected string tenHang;

        public string MaHang
        {
            get { return maHang;  }
            set { maHang = value; }
        }

        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }

        public HangHoa()
        {
            //this.maHang = "";
            //this.tenHang = "";

        }

        public HangHoa(string mahang, string tenhang)
        {
            if (mahang.Length == 5 && mahang.StartsWith("HH") && mahang.Substring(2).All(char.IsDigit))
            {
                this.MaHang = mahang;
            }
            else
            {
                this.MaHang = "HH001";
            }
            
        }

        public virtual void nhap()
        {
            Console.Write("Nhap ma: ");
            MaHang = Console.ReadLine();

            Console.Write("Nhap ten hang: ");
            TenHang = Console.ReadLine();
        }

        public virtual void xuat()
        {
            Console.WriteLine("\nMa hang: {0} \t Ten hang: {1} \t", MaHang, TenHang);
        }



    }
}
