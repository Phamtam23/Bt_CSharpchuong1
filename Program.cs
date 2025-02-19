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
            while (temp_336 > 0)
            {
                int digit_336 = temp_336 % 10; // Lấy chữ số cuối cùng
                if (digit_336 < min_336)
                {
                    min_336 = digit_336; // Cập nhật chữ số nhỏ nhất
                }
                temp_336 /= 10; // Bỏ chữ số cuối đã xét
            }

            Console.WriteLine($"Chữ số nhỏ nhất của {n_336} là: {min_336}");

            Console.ReadLine();
        }
    }
}
