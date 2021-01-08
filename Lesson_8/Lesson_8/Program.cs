using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine(greeting);

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Console.WriteLine("Введите возраст:");
                Properties.Settings.Default.UserAge =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите род деятельности:");
                Properties.Settings.Default.Occupation = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            string userName = Properties.Settings.Default.UserName;
            int userAge = Properties.Settings.Default.UserAge;
            string occupation = Properties.Settings.Default.Occupation;
            Console.WriteLine($"{userName}, {userAge}, {occupation}");
            Console.ReadLine();
        }
    }
}
