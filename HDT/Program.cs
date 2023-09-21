using HDT;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huongdoituong
{
    internal class HocSinh1 : nguoi
    {
        //Khai bao 
        private int MaHS;
        string TenHS;
        int namSinh;
        string DiaChi;
        double diemToan, diemVan, diemAnh, DTB;
        public HocSinh1()
        {

        }
        public HocSinh1(int ma, string ten, int ns, string dc)
        {
            MaHS = ma;
            TenHS = ten;
            namSinh = ns;
            DiaChi = dc;
        }
        nguoi n = new nguoi();
        public void NhapHS()
        {
            Console.Write("Nhap ma HS: ");
            MaHS = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap ten HS: ");
            TenHS = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namSinh = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            diemToan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem van: ");
            diemVan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem anh: ");
            diemAnh = Convert.ToDouble(Console.ReadLine());
        }
        public Double TinhDTB()
        {
            DTB = Math.Round((diemToan + diemVan + diemAnh) / 3, 1);
            return DTB;
        }
        public void XuatHS()
        {
            Console.WriteLine("Thong tin sinh vien la: ");
            Console.WriteLine("Ma HS la: " + MaHS);
            Console.WriteLine("Ten HS la: " + TenHS);
            Console.WriteLine("Nam sinh la: " + namSinh);
            Console.WriteLine("Dia chi la: " + DiaChi);
            Console.WriteLine(" diem trung binh la: " + DTB);

        }
    }
}
