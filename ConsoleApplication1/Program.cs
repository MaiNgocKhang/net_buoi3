using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao n sinh vien:");
            int n = Convert.ToInt32(Console.ReadLine());
            bai2[] a = new bai2[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap Thong Tin SV THU " + (i + 1));
                a[i] = new bai2();
                a[i].NhapTT();
            }
            bai2 tb;
            //sap xep DIEM TB
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i].DiemLT < a[j].DiemTH)
                    {
                        tb = a[i];
                        a[i] = a[j];
                        a[j] = tb;
                    }
                }
            }
            Console.WriteLine("\n Sap xep SV theo Diem TB Giam dan:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n MaSV: {0} | Ho Ten: {1} |Diem TB: {2}", a[i].MaSV1, a[i].TeNSV1, a[i].DiemLT, a[i].DiemTH);
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\n 3 SV co diem TB cao nhat :");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n MaSV: {0} | Ho Ten: {1} |Diem TB: {2}", a[i].MaSV1, a[i].TeNSV1, a[i].DiemLT, a[i].DiemTH);
            }
            Console.ReadKey();
        }
    }
}
