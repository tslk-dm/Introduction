//Написать программу, выводящую элементы двухмерного массива по диагонали.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[5, 5];

            int num = 1;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = num;
                    num++;
                }
            } 

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j <myArray.GetLength(0); j++)
                {
                    if (i == j)
                    Console.Write(myArray[i, j] + "\t");
                }
            }

            Console.ReadLine();
        }
    }
}
