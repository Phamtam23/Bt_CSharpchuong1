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
            //Bài 85: Nhập vào tháng của 1 năm. Cho biết tháng thuộc quý mấy trong năm
            Console.WriteLine("\nBài 85: Nhập vào tháng của 1 năm. Cho biết tháng thuộc quý mấy trong năm");
            int month_336;

            Console.Write("Nhập vào tháng (1 - 12): ");
            month_336 = Convert.ToInt32(Console.ReadLine());
            if (month_336 >= 1 && month_336 <= 3)
                Console.WriteLine("Tháng {0} thuộc Quý 1", month_336);
            else if (month_336 >= 4 && month_336 <= 6)
                Console.WriteLine("Tháng {0} thuộc Quý 2", month_336);
            else if (month_336 >= 7 && month_336 <= 9)
                Console.WriteLine("Tháng {0} thuộc Quý 3", month_336);
            else if (month_336 >= 10 && month_336 <= 12)
                Console.WriteLine("Tháng {0} thuộc Quý 4", month_336);
            else
                Console.WriteLine("Tháng không hợp lệ! Vui lòng nhập từ 1 đến 12.");
            Console.ReadLine();
        }
    }
}
