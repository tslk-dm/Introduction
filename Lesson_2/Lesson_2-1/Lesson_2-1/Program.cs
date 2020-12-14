/*Запросить у пользователя минимальную и максимальную температуру за сутки и вывести
среднесуточную температуру.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the maximum temperature for the day: ");
            int maxTemp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the minimum temperature for the day: ");
            int minTemp = Convert.ToInt32(Console.ReadLine());

            int daileTemp = (maxTemp + minTemp) / 2;

            Console.WriteLine($"The daily temperature is {daileTemp} degrees.");
            Console.ReadLine();
        }
    }
}
