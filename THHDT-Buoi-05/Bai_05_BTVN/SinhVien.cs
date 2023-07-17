using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_05_BTVN
{
    public class SinhVien:Nguoi
    {
        private string maSV;
        private string heDaoTao;
        private int tongTinChi;
        
        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        public string HeDaoTao
        {
            get { return heDaoTao; }
            set { heDaoTao = value; }
        }

        public int TongTinChi
        {
            get { return tongTinChi; }
            set { tongTinChi = value; }
        }

        public SinhVien():base()
        {
            this.MaSV = "SV001";
            this.HeDaoTao = "";
            this.TongTinChi = 0;
            
        }

        public SinhVien(string hoten, string ngaysinh, string gioitinh, string maso, string hedaotao, int tongtinchi):base(hoten, ngaysinh, gioitinh)
        {
            this.MaSV = maso;
            
            if (hedaotao.Equals("dai hoc") || hedaotao.Equals("cao dang") || hedaotao.Equals("cao dang nghe"))
            {
                this.HeDaoTao = hedaotao;
            }
            else
            {
                this.HeDaoTao = "dai hoc";
            }

            if (this.HeDaoTao.Equals("dai hoc"))
            {
                this.TongTinChi = 150;
            }
            else if (hedaotao.Equals("cao dang"))
            {
                this.TongTinChi = 100;
            }
            else
            {
                this.TongTinChi = 130;
            }
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap ma sv: ");
            MaSV = Console.ReadLine();

            Console.Write("Nhap he dao tao: ");
            HeDaoTao = Console.ReadLine();

        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Ma sv: {0} \t He dao tao: {1}", MaSV, HeDaoTao);
        }

        public double tinhTongHP()
        {
            double hocPhiTC = 120000;
            double TongTinChi = 130;

            if (HeDaoTao.Equals("dai hoc"))
            {
                hocPhiTC = 200000;
                TongTinChi = 150;
            }
            
            if (HeDaoTao.Equals("cao dang"))
            {
                hocPhiTC = 150000;
                TongTinChi = 100;
            }
            


            return TongTinChi * hocPhiTC;
        }


    }
}
