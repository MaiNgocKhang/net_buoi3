using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class bai2
    {
        private string MaSV;

        public string MaSV1
        {
            get { return MaSV; }
            set { MaSV = value; }
        }
        private string TeNSV;

        public string TeNSV1
        {
            get { return TeNSV; }
            set { TeNSV = value; }
        }
        private double DiemLythuyet;

        public double DiemLT
        {
            get { return DiemLythuyet; }
            set { DiemLythuyet = value; }
        }
        private double DiemThuchanh;

        public double DiemTH
        {
            get { return DiemThuchanh; }
            set { DiemThuchanh = value; }
        }

        public  bai2()
        {

        }
        public bai2(string id, string name, double diemlt, double diemth)
        {
            MaSV = id;
            TeNSV = name;
            DiemLT = diemlt;
            DiemTH = diemth;
        }
        public void NhapTT()
        {
            Console.Write("Nhap Ma SV:");
            MaSV = Console.ReadLine();
            Console.Write("Nhap Ho Ten:");
            TeNSV = Console.ReadLine();
            Console.Write("Nhap Diem ly thuyet:");
            DiemLT = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap Diem thuc hanh:");
            DiemTH = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("");
        }
        public double diemTB()
        {
            return (DiemLT + DiemTH) / 2;
        }
        
       

    }
}
