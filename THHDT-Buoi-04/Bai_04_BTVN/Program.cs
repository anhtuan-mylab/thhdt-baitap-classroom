using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_04_BTVN
{
    class Program
    {
        static void Main(string[] args)
        {

            CBLanhDao cb = new CBLanhDao();
            Console.WriteLine("Nhong tin nhan vien: ");
            cb.nhap();

            Console.WriteLine("\nThong tin nhan vien: ");
            cb.xuat();

            Console.ReadLine();
        }
    }
}
