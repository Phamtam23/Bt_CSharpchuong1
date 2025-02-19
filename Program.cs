using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class Program
    {
        double TinhS_336(int n_336)
        {
            if (n_336 == 1)
                return 1;
            return Math.Sqrt(n_336 + TinhS_336(n_336 - 1));
        }

        static void Main(string[] args)
        {
           /* Bài 34: Tính S(n) = CanBac2(n + CanBac2(n – 1 + CanBac2(n – 2 + … +CanBac2(2 + CanBac2(1)  có n dấu căn */
            int n_336;
            double S_336=0;
            do
            {
                Console.Write("Nhập số nguyên dương n: ");
                if (!int.TryParse(Console.ReadLine(), out n_336) || n_336 < 1)
                {
                    Console.WriteLine("Vui lòng nhập số nguyên dương lớn hơn hoặc bằng 1!");
                }
            } while (n_336 < 1);

            
            Console.WriteLine("\nTổng là:");
            Console.ReadLine();
        }
    }
}
