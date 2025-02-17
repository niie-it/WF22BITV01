using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("HELLO WORLD!!!");
            string hoTen;
            int namSinh;
            Console.Write("Họ tên của bạn: ");
            hoTen = Console.ReadLine();
            Console.Write("Năm sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bạn {hoTen} sinh {namSinh}");
            Console.Read();
        }
    }
}
