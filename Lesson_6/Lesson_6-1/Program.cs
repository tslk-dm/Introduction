/*
Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и
позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов с
помощью указания его ID или имени процесса. В качестве примера можно использовать консольные
утилиты Windows tasklist и taskkill .
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_6_1
{
    class Program
    {
        static void KillProcessesByName(string processesName)
        {
            Process[] processesForKillByName = Process.GetProcessesByName(processesName);
            for (int i = 0; i < processesForKillByName.Length; i++)
            {
                processesForKillByName[i].Kill();
            }
            KillingProcesses();
        }
        static void KillProcessesById(int processesId)
        {
            Process processesForKillById = Process.GetProcessById(processesId);
            processesForKillById.Kill();
            System.Threading.Thread.Sleep(1000);
            KillingProcesses();
        }

        static void PrintProsesses()
        {
            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. \t ID: {processes[i].Id} \t  Name: {processes[i].ProcessName}");
            }
        }

        static void KillingProcesses()
        {
            Console.Clear();
            string[] deleting = { "Удаление процесса.", "Удаление процесса..", "Удаление процесса..." };
            const int numberOfRepetitions = 2;
            for (int i = 0; i < deleting.Length * numberOfRepetitions; i++)
            {
                Console.WriteLine(deleting[i % deleting.Length]);
                System.Threading.Thread.Sleep(300);
                Console.Clear();
            }
            
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Список процессов:");
                PrintProsesses();
                Console.WriteLine("Для удаления введите имя или id процесса");
                
                string processesName = Console.ReadLine();
                if (int.TryParse(processesName, out int processesId))
                {
                    //введен Id
                    KillProcessesById(processesId);
                }
                else
                {
                    //введен Name
                    KillProcessesByName(processesName);
                }
                
            }
            
        }
    }
}
