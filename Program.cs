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
            /*  Bài 16: Tính S(n) = x + x ^ 2 / 1 + 2 + x ^ 3 / 1 + 2 + 3 + … +x ^ n / 1 + 2 + 3 + …. +N */

            int n_336;
            double x_336, S_336 = 0;

            // Nhập giá trị x và n
            Console.Write("Nhập giá trị x: ");
            x_336 = double.Parse(Console.ReadLine());

            do
            {
                Console.Write("Nhập giá trị n (>= 1): ");
                n_336 = int.Parse(Console.ReadLine());
                if (n_336 < 1)
                {
                    Console.WriteLine("n phải lớn hơn hoặc bằng 1");
                }
            } while (n_336 < 1);
            for (int i_336 = 1; i_336 <= n_336; i_336++)
            {
                double tu_336 = Math.Pow(x_336, i_336); // Tính tử số x^i
                int mau_336 = 0; 

                for (int j_336 = 1; j_336 <= i_336; j_336++)
                {
                    mau_336 += j_336;
                }

                S_336 += tu_336 / mau_336;
            }

            Console.WriteLine("\nTổng S({0}) = {1:F6}", n_336, S_336);
            Console.ReadLine();
        }
    }
}
