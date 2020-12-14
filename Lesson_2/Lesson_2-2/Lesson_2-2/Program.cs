//Запросить у пользователя порядковый номер текущего месяца и вывести его название.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_2
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
            Console.Write("Enter the sequence number of the current month: ");
            int currentMonth = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine((monthOfYear)currentMonth);
            
            Console.ReadLine();
        }
    }
}
