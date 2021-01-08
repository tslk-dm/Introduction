/*Написать метод GetFullName(string firstName, string lastName, string
patronymic), принимающий на вход ФИО в разных аргументах и возвращающий
объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль
3–4 разных ФИО.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_1
{
    class Program
    {
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + " " + lastName + " " + patronymic;
        }

        static void Main(string[] args)
        {
            string firstName = "Dima";
            string lastName = "Tislyuk";
            string patronymic = "Andreevich";
            string fullName = GetFullName(firstName, lastName, patronymic);

            Console.WriteLine(fullName);

            firstName = "Ivan";
            lastName = "Ivanov";
            patronymic = "Ivanovich";
            fullName = GetFullName(firstName, lastName, patronymic);

            Console.WriteLine(fullName);
            Console.ReadLine();
        }
    }
}
