using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        static public void AddTask(List<string> tasks)
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
                Console.Write("Uppgift ");
                Console.Write(i+1 + ": ");
                Console.WriteLine(tasks[i]);
            }
        }

        static private void Menu(List<string> tasks,List<string> completedTasks)
        {
            string choise;
            do
            {
                Console.WriteLine("_____________________________");
                Console.WriteLine("Välj något av följande alternativ: ");
                Console.WriteLine("1. Lägg till uppgift");
                Console.WriteLine("2. Visa alla uppgifter");
                Console.WriteLine("3. Klarmarkera uppgiften");
                Console.WriteLine("4. Visa avklarade uppgifter");
                Console.WriteLine("5. Ta bort en uppgift");
                Console.WriteLine("q. Avsluta programmet");
                choise = Console.ReadLine();

                if (choise == "1")
                {
                    Console.WriteLine("Du har valt att lägga till en ny uppgift:");
                    Console.Write("Uppgift ");
                    Console.Write(tasks.Count + 1 + ": ");
                    string nyItem = Console.ReadLine();
                    tasks.Add(nyItem);
                }
                else if (choise == "2")
                {
                    ShowTasks(tasks);
                }else if (choise == "3")
                {
                    DoneTasks(tasks,completedTasks);
                } else if (choise == "4")
                {
                    ShowTasks(completedTasks);
                } else if (choise == "5")
                {
                    // Ta bort en uppgift
                    Console.Write("Vilken uppgift vill du ta bort? Uppgift nr: ");
                    int delete = Convert.ToInt32(Console.ReadLine());
                    tasks.Remove(tasks[delete-1]);
                }
            } while (choise != "q");
        }

        static private void DoneTasks(List<string> tasks, List<string> complatedTasks) // klarmarkerar uppgiften
        {
            Console.Write("VIlken uppgift vill du klarmarkera? Uppgift nu: ");
            int moveToDone = Convert.ToInt32(Console.ReadLine());
            string item = tasks[moveToDone-1];
            complatedTasks.Add(item);
            tasks.Remove(tasks[moveToDone - 1]);
        }

    }
}
