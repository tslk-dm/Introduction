/*
 «Морской бой» — вывести на экран массив 10х10, 
 состоящий из символов X и O, где Х —
 элементы кораблей, а О — свободные клетки.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_4
{
    class Program
    {
        


        static void PrintField(char[,] field)
        {
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
            for (int i = 0; i < field.GetLength(0); i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static char[,] GetField(char[,] field, int value_i, int value_j, int direction, int length)
        {

            bool flag = true;

            if (direction == 0) //вертикаль
            {

                //проверка на возможность постановки корабля
                if (value_i + length <= field.GetLength(0))
                {
                    for (int i = value_i; i < value_i + length; i++)
                    {
                        flag = CheckPoint(field, i, value_j); //проверяет точку и ее окрестность 
                        if (!flag)
                        {
                            Console.WriteLine();
                            Console.WriteLine("ОШИБКА! Пересечение с другим кораблем!");
                            Console.WriteLine();
                            break;
                        }

                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("ОШИБКА! Пересечение границы карты!");
                    Console.WriteLine();
                    flag = false;
                }

                //если корабль поставить можно - ставим
                if (flag)
                {
                    //заполнение поля
                    while (length > 0)
                    {
                        field[value_i, value_j] = 'X';
                        value_i++;
                        length--;
                    }
                }
            }
            else
            {
                //проверка
                if (value_j + length <= field.GetLength(1))
                {
                    for (int j = value_j; j < value_j + length; j++)
                    {
                        flag = CheckPoint(field, value_i, j);
                        if (!flag)
                        {
                            Console.WriteLine();
                            Console.WriteLine("ОШИБКА! Пересечение с другим кораблем!");
                            Console.WriteLine();
                            break;
                        }

                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("ОШИБКА! Пересечение границы карты!");
                    Console.WriteLine();
                    flag = false;
                }

                if (flag)
                {
                    //заполнение поля
                    while (length > 0)
                    {
                        field[value_i, value_j] = 'X';
                        value_j++;
                        length--;
                    }
                }
            }
            return field;
        }

        static bool CheckPoint(char[,] field, int value_i, int value_j)
        {
            if ((value_i == 0) && (value_j == 0))  //левая верхняя
            {
                if ((field[value_i, value_j] == 'X') || (field[value_i, value_j + 1] == 'X') || (field[value_i + 1, value_j] == 'X') || (field[value_i + 1, value_j + 1] == 'X'))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if ((value_i == 0) && (value_j == 9)) //правая верхняя
            {
                if ((field[value_i, value_j] == 'X') || (field[value_i, value_j - 1] == 'X') || (field[value_i + 1, value_j] == 'X') || (field[value_i + 1, value_j - 1] == 'X'))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if ((value_i == 9) && (value_j == 9)) //правая нижня
            {
                if ((field[value_i, value_j] == 'X') || (field[value_i, value_j - 1] == 'X') || (field[value_i - 1, value_j] == 'X') || (field[value_i - 1, value_j - 1] == 'X'))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if ((value_i == 9) && (value_j == 0)) // левая нижняя
            {
                if ((field[value_i, value_j] == 'X') || (field[value_i, value_j + 1] == 'X') || (field[value_i - 1, value_j] == 'X') || (field[value_i - 1, value_j + 1] == 'X'))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (value_j == 0) //левая граница
            {
                if ((field[value_i, value_j] == 'X') || (field[value_i - 1, value_j] == 'X') || (field[value_i + 1, value_j] == 'X') || (field[value_i, value_j + 1] == 'X') || (field[value_i + 1, value_j + 1] == 'X') || (field[value_i - 1, value_j + 1] == 'X'))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (value_j == 9) //правая граница
            {
                if ((field[value_i, value_j] == 'X') || (field[value_i + 1, value_j] == 'X') || (field[value_i - 1, value_j] == 'X') || (field[value_i, value_j - 1] == 'X') || (field[value_i - 1, value_j - 1] == 'X') || (field[value_i + 1, value_j - 1] == 'X'))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (value_i == 0) //верхняя граница
            {
                if ((field[value_i, value_j] == 'X') || (field[value_i + 1, value_j] == 'X') || (field[value_i, value_j - 1] == 'X') || (field[value_i, value_j + 1] == 'X') || (field[value_i + 1, value_j + 1] == 'X') || (field[value_i + 1, value_j - 1] == 'X'))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (value_i == 9) //нижняя граница
            {
                if ((field[value_i, value_j] == 'X') || (field[value_i - 1, value_j] == 'X') || (field[value_i, value_j - 1] == 'X') || (field[value_i, value_j + 1] == 'X') || (field[value_i - 1, value_j - 1] == 'X') || (field[value_i - 1, value_j + 1] == 'X'))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if ((field[value_i, value_j] == 'X') || (field[value_i - 1, value_j] == 'X') || (field[value_i + 1, value_j] == 'X') || (field[value_i, value_j - 1] == 'X') || (field[value_i, value_j + 1] == 'X') || (field[value_i + 1, value_j + 1] == 'X') || (field[value_i - 1, value_j - 1] == 'X') || (field[value_i + 1, value_j - 1] == 'X') || (field[value_i - 1, value_j + 1] == 'X'))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        static void Main(string[] args)
        {
            char[,] field = new char[10, 10];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = '.';
                }
            }

            PrintField(field);
            while (true)
            {

                Console.Write("Напишите координату по вертикали от 0 до 9: ");
                int value_i = Convert.ToInt32(Console.ReadLine());
                Console.Write("Напишите координату по горизонтали от 0 до 9: ");
                int value_j = Convert.ToInt32(Console.ReadLine());
                Console.Write("Напишите направление 0-вниз, 1-вправо: ");
                int direction = Convert.ToInt32(Console.ReadLine());
                Console.Write("Напишите длину корабля: ");
                int length = Convert.ToInt32(Console.ReadLine());
                PrintField(GetField(field, value_i, value_j, direction, length));
                Console.WriteLine();

            }

            
        }
    }
}
