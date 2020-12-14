/*
 Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести
сообщение «Дождливая зима».
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_4
{
    class Program
    {
        enum monthOfYear
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the daily temperature for the day: ");
            int dailyTemp = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the sequence number of the current month: ");
            int currentMonth = Convert.ToInt32(Console.ReadLine());

            if ((dailyTemp > 0) && (currentMonth == (int)monthOfYear.December || currentMonth == (int)monthOfYear.January ||
                currentMonth == (int)monthOfYear.February))
                Console.WriteLine("Rainy winter");

            Console.ReadLine();
        }
    }
}
