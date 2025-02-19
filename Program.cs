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
            Console.WriteLine("\nTổng là:");
            Console.ReadLine();
        }
    }
}
