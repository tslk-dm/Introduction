/*
 Написать программу, выводящую введенную пользователем строку 
в обратном порядке (olleH вместо Hello).
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();

            for (int i = str.Length - 1; i >= 0;  i--)
            {
                Console.Write(str[i]);
            }
            Console.ReadLine();
        }
        
    }
}
