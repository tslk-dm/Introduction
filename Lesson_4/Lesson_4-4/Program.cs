using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_4
{
    class Program
    {
        static int Fibonachi(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        static void Main(string[] args)
        {
            int  number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Fibonachi({number}) = {Fibonachi(number)}");
            Console.ReadLine();
        }
    }
}
