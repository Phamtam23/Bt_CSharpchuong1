using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Bài 52: Tìm chữ số nhỏ nhất của số nguyên dương n
            int n_336, min_336 = 9;

            Console.Write("Nhập số nguyên dương n: ");
            while (!int.TryParse(Console.ReadLine(), out n_336) || n_336 < 1)
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương lớn hơn 0!");
                Console.Write("Nhập lại n: ");
            }
            int temp_336 = n_336;
         
           
            Console.ReadLine();
        }
    }
}
