using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        enum DaysOfWeek
        {
            MonDAY=2,
            Tuesday=3

        };
        struct sinhVien257
        {
            enum DaysOfWeek
            {
                MonDAY = 2,
                Tuesday = 3

            };
            public int maSV;
            public string tenSV;
            public double diemToan, diemLy, diemHoa;

            
            public sinhVien257(int maSV, string tenSV, double diemToan, double diemLy, double diemHoa)
            {
                this.maSV = maSV;
                this.tenSV = tenSV;
                this.diemToan = diemToan;
                this.diemLy = diemLy;
                this.diemHoa = diemHoa;
            }
            
            public static void timKiemSV(sinhVien257 SV, string tk)
            {
                if(SV.tenSV == tk)
                {
                    Console.WriteLine(" Ma so: " + SV.maSV);
                    Console.WriteLine(" Ho ten: " + SV.tenSV);
                    Console.WriteLine(" Diem toan: " + SV.diemToan);
                    Console.WriteLine(" Diem ly: " + SV.diemLy);
                    Console.WriteLine(" Diem hoa: " + SV.diemHoa);
                    Console.WriteLine(" Diem TB: " + (SV.diemToan + SV.diemLy + SV.diemHoa));
                    Console.ReadKey();
                }
            }
        }
        static void Main(string[] args)
        {
            List<sinhVien257> listSV = new List<sinhVien257>();
            listSV.Add(new sinhVien257(257, "Van Thanh", 7, 6.8, 8));
            listSV.Add(new sinhVien257(257, "Duong Thanh", 8, 9, 7.4));
            listSV.Add(new sinhVien257(257, "Tien Cuong", 7.8, 7.3, 6));
            string tk;
            Console.Write(" Ho ten can tim kiem: ");
            tk = Console.ReadLine();
            foreach (sinhVien257 SV in listSV) //  for each file
            {
                sinhVien257.timKiemSV(SV, tk);
            }

        }
    }
}
