//Написать программу, которая при старте дописывает текущее время в файл
//«startup.txt».

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "TimeNow.txt";
            File.AppendAllText(filename, DateTime.Now.ToString("HH:mm:ss"));
            File.AppendAllText(filename, Environment.NewLine);
        }
    }
}
