/*Список задач (ToDo-list):
● написать приложение для ввода списка задач;
● задачу описать классом ToDo с полями Title и IsDone ;
● на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить
из него массив имеющихся задач и вывести их на экран;
● если задача выполнена, вывести перед её названием строку «[x]»;
● вывести порядковый номер для каждой задачи;
● при вводе пользователем порядкового номера задачи отметить задачу с этим
порядковым номером как выполненную;
● записать актуальный массив задач в файл tasks.json/xml/bin.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Lesson_5_5
{
    class Program
    {
        static void SaveTasksArray(ToDo[] taskArray)
        {
            string json = JsonSerializer.Serialize(taskArray);
            File.WriteAllText("tasks.json", json);
        }

        static ToDo[] GetTasksArray()
        {
            string readerjson = File.ReadAllText("tasks.json");
            ToDo[] readerTask = JsonSerializer.Deserialize<ToDo[]>(readerjson);
            return readerTask;
        }

        static void PrintTasks(ToDo[] readerTask)
        {
            for (int i = 0; i < readerTask.Length; i++)
            {
                if (readerTask[i].isDone)
                {
                    Console.WriteLine($"{i + 1}. [x] {readerTask[i].Title} ");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. {readerTask[i].Title} ");
                }

            }
        }


        static void Main(string[] args)
        {
            ToDo task1 = new ToDo();
            task1.Title = "купить хлеб";
            task1.isDone = false;

            ToDo task2 = new ToDo();
            task2.Title = "сделать дз";
            task2.isDone = true;

            ToDo task3 = new ToDo();
            task3.Title = "захватить мир";
            task3.isDone = false;
            
            ToDo[] taskArray = { task1, task2, task3 };

            if (File.Exists("tasks.json"))
            {
                while (true)
                {
                    SaveTasksArray(taskArray);

                    PrintTasks(GetTasksArray());

                    Console.WriteLine("Введите номер выполненной задачи. Для выхода введите 0.");
                    int numberOfCompletedTask = Convert.ToInt32(Console.ReadLine());
                    
                    if (numberOfCompletedTask == 0)
                        return;

                    taskArray[numberOfCompletedTask - 1].isDone = true;

                }
                

            }
            else
            {
                Console.WriteLine("file not found");
            }

            Console.ReadLine();



            
        }
    }
}
