/*Написать метод по определению времени года. На вход подаётся число – порядковый номер
месяца. На выходе — значение из перечисления (enum) — Winter, Spring, Summer,
Autumn. Написать метод, принимающий на вход значение из этого перечисления и
возвращающий название времени года (зима, весна, лето, осень). Используя эти методы,
ввести с клавиатуры номер месяца и вывести название времени года. Если введено
некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_3
{
    class Program
    {
        enum TimeOfYear
        {
            Winter = 1, 
            Spring, 
            Summer,
            Autumn
        }

        
        static int DetermineTimeOfYear(int numMonth)
        {
            switch (numMonth)
            {
                case 12:
                case 1:
                case 2:
                    return (int)TimeOfYear.Winter;
                case 3:     
                case 4:
                case 5:
                    return (int)TimeOfYear.Spring;
                case 6:
                case 7:
                case 8:
                    return (int)TimeOfYear.Summer;
                case 9:
                case 10:
                case 11:
                    return (int)TimeOfYear.Autumn;
                default:
                    return 0;  //Правильно ли здесь возвращать 0? Иначе ошибка: не все пути кода возвращают значение
            }
        }

        static TimeOfYear ReturnNameTimeOfYear(int numMonth)
        {
            return (TimeOfYear)numMonth;
        }    
      
        static void Main(string[] args)
        {
            int monthNumber;
            while (true)
            {
                Console.WriteLine("Введите порядковый номер месяца");
                monthNumber = Convert.ToInt32(Console.ReadLine());
                if (monthNumber >= 1 && monthNumber <= 12)
                    break;
            }
            int timeOfYear = DetermineTimeOfYear(monthNumber);
            Console.WriteLine(ReturnNameTimeOfYear(timeOfYear));
            Console.ReadLine();
        }
    }
}
