/*Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и
возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести
результат на экран.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_2
{
    class Program
    {
        static int SumOfNumbersinRow(string str)
        {
            int sum = 0;
            string[] stringArray = str.Split(' ');
            foreach (var item in stringArray)
            {
                sum += Convert.ToInt32(item);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(SumOfNumbersinRow(str)) ;
            Console.ReadLine();
        }
    }
}
