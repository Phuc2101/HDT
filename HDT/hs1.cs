using huongdoituong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDT
{
    
    
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Nhap so luong sinh vien :");
                int n = Convert.ToInt32(Console.ReadLine());    
                HocSinh1[] dssv = new HocSinh1[n];
                for (int i = 0;i<n;i++)
                {
                    dssv[i] = new HocSinh1();
                    Console.WriteLine("Nhap thong tin sinh vien la :"+ (i+1));
                    dssv[i].NhapHS();
                    dssv[i].TinhDTB();
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Thong tin sinh vien: "+ (i+1));
                    dssv[i].XuatHS();
                }
                Console.ReadKey();
            }
        }
    }

