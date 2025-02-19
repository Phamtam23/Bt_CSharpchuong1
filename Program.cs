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
            //Bài 65 : Giải phương trình bậc 2
            Console.WriteLine("\nBài 65 : Giải phương trình bậc 2");
            double a_336, b_336, c_336, delta_336, x1_336, x2_336;

            Console.Write("Nhập a: ");
            a_336 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập b: ");
            b_336 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập c: ");
            c_336 = Convert.ToDouble(Console.ReadLine());
            if (a_336 == 0)
            {
                if (b_336 == 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm!");
                }
                else
                {
                    Console.WriteLine("Phương trình có một nghiệm: x = {0}", -c_336 / b_336);
                }
            }
            else
            {
                delta_336 = b_336 * b_336 - 4 * a_336 * c_336;

                if (delta_336 > 0)
                {
                    x1_336 = (-b_336 + Math.Sqrt(delta_336)) / (2 * a_336);
                    x2_336 = (-b_336 - Math.Sqrt(delta_336)) / (2 * a_336);
                    Console.WriteLine("Phương trình có hai nghiệm phân biệt:");
                    Console.WriteLine("x1 = {0:F6}", x1_336);
                    Console.WriteLine("x2 = {0:F6}", x2_336);
                }
                else if (delta_336 == 0)
                {
                    x1_336 = -b_336 / (2 * a_336);
                    Console.WriteLine("Phương trình có nghiệm kép: x1 = x2 = {0:F6}", x1_336);
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm!");
                }
            }
            Console.ReadLine();
        }
    }
}
