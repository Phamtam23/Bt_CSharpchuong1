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
          /*  Bài 23: Đếm số lượng “ước số” của số nguyên dương n */
            Console.WriteLine("\nBài 23: Đếm số lượng “ước số” của số nguyên dương n");
            int n_336, dem_336 = 0;

            do
            {
                Console.Write("Nhập số nguyên dương n: ");
                if (!int.TryParse(Console.ReadLine(), out n_336) || n_336 <= 0)
                {
                    Console.WriteLine("Vui lòng nhập số nguyên dương lớn hơn 0!");
                }
            } while (n_336 <= 0);
            Console.WriteLine($"\n Ước số của {n_336} là:");
            for (int i_336 = 1; i_336 <= n_336; i_336++)
            {
                if (n_336 % i_336 == 0)
                {           
                    dem_336++;
                    Console.WriteLine($" {i_336}");
                }
            }

            Console.WriteLine($"\nSố lượng ước số của {n_336} là: {dem_336}");
            Console.ReadLine();
        }
    }
}
