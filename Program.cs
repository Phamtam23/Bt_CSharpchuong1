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
            /*Bài 43: Hãy đếm số lượng chữ số của số nguyên dương n*/
            int n_336;
            int count_336 = 0;

            do
            {
                Console.Write("Nhập số nguyên dương n: ");
            } while (!int.TryParse(Console.ReadLine(), out n_336) || n_336 <= 0);

          
            Console.WriteLine("\nTổng là:");
            Console.ReadLine();
        }
    }
}
