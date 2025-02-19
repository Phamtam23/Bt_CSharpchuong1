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
            //Bài 72: Tính S(x, n) = – x + x^2/2! – x^3/3! + … + (-1)^n * x^n/n!
            Console.WriteLine("\nBài 72: Tính S(x, n) = – x + x^2/2! – x^3/3! + … + (-1)^n * x^n/n!");
            int n_336;
            double x_336, S_336 = 0, tu_336, mau_336=1;
            Console.Write("Nhập x: ");
            x_336 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập n: ");
            n_336 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            for (int i_336 = 1; i_336 <= n_336; i_336++)
            {
                tu_336 = Math.Pow(x_336, i_336);
                mau_336 = mau_336 * i_336;
              S_336 += Math.Pow(-1, i_336) * tu_336 / mau_336;
            }

            Console.WriteLine("\nTổng S(x, n) = {0:F6}", S_336);
        }
    }
}
