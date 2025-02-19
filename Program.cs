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
            int n_336;
            double S_336 = 0;

            do
            {
                Console.Write("\nNhập n: ");
                if (!int.TryParse(Console.ReadLine(), out n_336) || n_336 < 1)
                {
                    Console.WriteLine("\nN phải lớn hơn hoặc bằng 1. Xin nhập lại!");
                }
            } while (n_336 < 1);

            for (int i_336 = 1; i_336 <= n_336; i_336++)
            {
                S_336 += 1.0 / (2 * i_336);
            }

            Console.WriteLine("\nTổng là: {0:F6}", S_336);
        
            Console.ReadLine();
        }
    }
}
