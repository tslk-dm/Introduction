//Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный
//файл.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "BytesFile.bin";
            string binaryString = Console.ReadLine();

            string[] binaryStringArray = (binaryString.Split(' '));

            byte[] binaryBytesArray = new byte[binaryStringArray.Length];
            for(int i = 0; i < binaryStringArray.Length; i++)
            {
                binaryBytesArray[i] = Convert.ToByte(binaryStringArray[i]);
            }
            File.WriteAllBytes(filename, binaryBytesArray);         

        }

    }
}
