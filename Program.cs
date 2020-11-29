using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            List<string> tasks = new List<string>();
            List<string> completedTasks = new List<string>();
            AddTask(tasks);
            ShowTasks(tasks);
            Menu(tasks,completedTasks);


        }

        static private void Welcome()
        {
            Console.WriteLine("Välkommen till Att-Göra-Listan");
            Console.WriteLine("Börja med att skapa några uppgifter.");
            Console.WriteLine("Lägg till en uppgift i taget, (skriv 'q' för att avsluta)");
        }

        static private void AddTask(List<string> tasks)
        {
            bool addTaskloop = true;
            while (addTaskloop)
            {
                for (int i = 0; i <= tasks.Count; i++)
                {
                    Console.Write("Uppgift {0}: ", i + 1);
                    string dataToList = Console.ReadLine();
                    if (dataToList != "q")
                    {
                        tasks.Add(dataToList);
                    }
                    else addTaskloop = false;
                }
            }
         
        }
        
        static private void ShowTasks(List<string> tasks)
        {
            Console.WriteLine("__________________");
            Console.WriteLine("Visa uppgifter: ");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.Write(i+1 + ": ");
                Console.WriteLine(tasks[i]);
            }
        }

        static private void Menu(List<string> tasks,List<string> completedTasks)
        {
            string choise;
            do
            {
                Console.WriteLine("Välj något av följande alternativ: ");
                Console.WriteLine("1. Lägg till uppgift");
                Console.WriteLine("2. Visa alla uppgifter");
                Console.WriteLine("q. Avsluta programmet");
                choise = Console.ReadLine();

                if (choise == "1")
                {
                    Console.WriteLine("Du har valt att lägga till en ny uppgift:");
                    Console.Write(tasks.Count + 1 + ": ");
                    string nyItem = Console.ReadLine();
                    tasks.Add(nyItem);
                }
                else if (choise == "2")
                {
                    ShowTasks(tasks);
                }
            } while (choise != "q");
        }

      
    }
}
