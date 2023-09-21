
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDT
{
    internal class nguoi
    {
        public int SDT { get; set; }
        public string gioitinh { get; set; }
        public nguoi() { }
        public nguoi(int SDT, string gioitinh)
        {
            SDT = SDT;
            gioitinh = gioitinh;
        }
        public void NhapTT()
        {
            Console.Write("Nhap SDT : ");
            SDT = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap gioi tinh : ");
            gioitinh = Console.ReadLine();
        }
        public void XuatTT()
        {
            Console.WriteLine("SDT :" + SDT);
            Console.WriteLine("Gioitinh : " + gioitinh);
        }

    }
}
