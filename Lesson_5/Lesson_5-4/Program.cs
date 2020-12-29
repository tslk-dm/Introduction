/*
 Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с
рекурсией и без.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5_4_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string workDir = Console.ReadLine();
            
            if (Directory.Exists(workDir))
            {

                string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);

                for (int i = 0; i < entries.Length; i++)
                {
                    File.WriteAllText("directory.txt", entries[i]);
                }
                
            }
            

            Console.ReadLine();
        }
    }
}
