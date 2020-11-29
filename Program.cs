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
            AddTask(tasks);
            ShowTasks(tasks);


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

      
    }
}
