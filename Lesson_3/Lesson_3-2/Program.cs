/*
 Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий
список телефонных контактов: первый элемент хранит имя контакта, второй — номер
телефона/e-mail.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phonebook = new string[5, 2];
            
            for (int i = 0; i < phonebook.GetLength(0); i++)
            {
                Console.WriteLine($"Контакт №{i+1}");
                
                Console.Write("Введите имя: ");
                phonebook[i, 0] = Console.ReadLine();
                
                Console.Write("Введите номер/почту: ");
                phonebook[i, 1] = Console.ReadLine();

                Console.WriteLine();
            }

            for (int i = 0; i < phonebook.GetLength(0); i++)
            {
                for (int j = 0; j < phonebook.GetLength(1); j++)
                {
                    Console.Write(phonebook[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
