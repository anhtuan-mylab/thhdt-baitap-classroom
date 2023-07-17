using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_02
{
    class Time
    {
        private int gio, phut, giay;
        
        public int Gio
        {
            get { return gio; }
            set
            {
                if (value > 23 || value < 0)
                {
                    Console.Write("Loi du lieu");
                }
                else
                {
                    gio = value;
                }
                
            }
        }

        public int Phut
        {
            get { return phut; }
            set
            {
                if (value > 59 || value <0)
                {
                    Console.Write("Loi du lieu.");
                }
                else
                {
                    phut = value;
                }
            }
        }

        public int Giay
        {
            get { return giay; }
            set
            {
                if (value > 59 || value < 0)
                {
                    Console.Write("Loi du lieu.");
                }
                else
                {
                    giay = value;
                }
            }
        }

        public Time()
        {
            Gio = Phut = Giay = 1;
        }

        public Time(int gio, int phut, int giay)
        {
            this.Gio = gio;
            this.Phut = phut;
            this.Giay = giay;
        }

        public Time(Time a)
        {
            this.Gio = a.Gio;
            this.Phut = a.Phut;
            this.Giay = a.Giay;
        }

        public void nhap()
        {
            Console.Write("Nhap gio (24h): ");
            Gio = int.Parse(Console.ReadLine());

            Console.Write("Nhap phut (24h): ");
            Phut = int.Parse(Console.ReadLine());

            Console.Write("Nhap giay (24h): ");
            Giay = int.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("{0:00}:{1:00}:{2:00}", Gio, Phut, Giay);
        }

        public void xuat_12()
        {
            string t;

            if (Gio>12)
            {
                int gio_moi = Gio - 12;
                t = "PM";
                Console.Write("\n{0}:{1}:{2} {3}", gio_moi, Phut, Giay, t);

            }
            else
            {
                t = "AM";
                Console.Write("\n{0:00}:{1:00}:{2:00} {3}", Gio, Phut, Giay, t);

            }
        }

    }
}
