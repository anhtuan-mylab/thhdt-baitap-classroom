using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_03_THTL
{
    class Program
    {
        static void Main(string[] args)
        {
            //HangHoa hh = new HangHoa();
            //hh.nhap();
            //hh.xuat();

            Console.WriteLine("Thong tin hang hoa: ");
            NuocGiaiKhat ngk = new NuocGiaiKhat();
            ngk.nhap();
            ngk.xuat();

            Console.WriteLine("\nTinh tong: {0}", ngk.tinhTongTien());

            Console.ReadLine();
        }
    }
}
