//Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "userData.txt";
              
            File.WriteAllText(filename, Console.ReadLine());
            
        }
    }
}
