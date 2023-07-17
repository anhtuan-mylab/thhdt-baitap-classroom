using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_05_BTVN
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SinhVien sv = new SinhVien();
            sv.nhap();
            sv.xuat();

            Console.WriteLine("Tong hoc phi: {0}", sv.tinhTongHP());

            Console.ReadLine();
        }
    }
}
