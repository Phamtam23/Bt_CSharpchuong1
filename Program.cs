using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class Program
    {
        // Hàm kiểm tra ngày hợp lệ
    static bool IsValidDate(int day_336, int month_336, int year_336)
        {
            if (year_336 < 1 || month_336 < 1 || month_336 > 12 || day_336 < 1)
                return false;

            int[] daysInMonth_336 = { 31, IsLeapYear(year_336) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day_336 > daysInMonth_336[month_336 - 1])
                return false;

            return true;
        }

        // Hàm kiểm tra năm nhuận
        static bool IsLeapYear(int year_336)
        {
            return (year_336 % 4 == 0 && year_336 % 100 != 0) || (year_336 % 400 == 0);
        }
        static void Main(string[] args)
        {
            //Bài 103: Viết chương trình nhập vào 1 ngày ( ngày, tháng, năm). Tìm ngày trước ngày vừa nhập (ngày, tháng, năm)
            Console.WriteLine("\nBài 103: Viết chương trình nhập vào 1 ngày ( ngày, tháng, năm). Tìm ngày trước ngày vừa nhập (ngày, tháng, năm)");

            int day_336, month_336, year_336;

            Console.Write("Nhập ngày: ");
            day_336 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập tháng: ");
            month_336 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập năm: ");
            year_336 = Convert.ToInt32(Console.ReadLine());

            if (!IsValidDate(day_336, month_336, year_336))
            {
                Console.WriteLine("Ngày nhập không hợp lệ!");
            }
            else
            {
                // Tạo đối tượng DateTime và trừ đi 1 ngày
                DateTime currentDate_336 = new DateTime(year_336, month_336, day_336);
                DateTime previousDate_336 = currentDate_336.AddDays(-1);

                Console.WriteLine("Ngày trước đó là: {0}/{1}/{2}",
                    previousDate_336.Day, previousDate_336.Month, previousDate_336.Year);
            }

            Console.WriteLine("Nhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }
    }
}
