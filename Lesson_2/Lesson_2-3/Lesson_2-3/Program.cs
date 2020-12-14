//Определить, является ли введённое пользователем число чётным.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if ((num % 2) == 0)
                Console.WriteLine("The number is even.");
            else
                Console.WriteLine("The number is odd.");

            Console.ReadLine();
        }
    }
}
