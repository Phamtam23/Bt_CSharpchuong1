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
            Console.WriteLine("\nBài 43: Hãy đếm số lượng chữ số của số nguyên dương ");
            do
            {
                Console.Write("Nhập số nguyên dương n: ");
            } while (!int.TryParse(Console.ReadLine(), out n_336) || n_336 <= 0);

            int temp_336 = n_336;
            while (temp_336 > 0)
            {
                count_336++;
                temp_336 /= 10; 
            }

            Console.WriteLine("\nSố lượng chữ số của {0} là: {1}", n_336, count_336);
          
            Console.ReadLine();
        }
    }
}
