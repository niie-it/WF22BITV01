using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSinhVien
{
    public class SinhVien
    {
        //Automatic properties
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string DienThoai { get; set; }
        public double GPA { get; set; }
        public string XepLoai //read only
        {
            get {
                if (GPA >= 8.5) { return "A"; }
                else if (GPA >= 7) { return "B"; }
                else if(GPA >= 5.5) { return "C"; }
                else if (GPA >= 4) return "D";
                return "F";
            }
        }

        public SinhVien(string ma, string hoten, string phone, double gpa)
        {
            MaSV = ma; HoTen = hoten; DienThoai = phone; GPA = gpa;
        }

        public override string ToString()
        {
            return $"{MaSV} {HoTen} {DienThoai} {GPA} : {XepLoai}";
        }
    }
}
